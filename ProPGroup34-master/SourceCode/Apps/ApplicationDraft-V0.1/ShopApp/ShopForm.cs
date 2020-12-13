using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;
using MySql;
using Phidget22;
using Phidget22.Events;

namespace ShopApp
{
    public partial class ShopForm : Form,ILogger
    {
        Order o;
        DataHelper data;
        Shop selectedShop;
        Visitor v;
        RFID myRFIDReader;

        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);


        public ShopForm(Shop s)
        {
            InitializeComponent();
            if (s != null)
            {
                selectedShop = s;
                labelAdminShop.Hide();
                comboBoxShop.Hide();
            }
            else
            {
                MessageBox.Show("You are logged in as admin");
            }
        }

        private void Pay(object sender, RFIDTagEventArgs e)
        {
            v = data.FindVisitorByTag(e.Tag);
            if (v != null)
            {
                o.VisitorNr = v.IdNr;
                if (v.Credit < o.GetSum())
                {
                    MessageBox.Show("Visitor does not have enough credit.");
                }
                else
                {
                    v.Credit -= o.GetSum();
                    ProcessOrder();
                    data.UpdateSelectedVisitor(v);
                }
            }
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = overviewBtn.Height;
            sideHighlight.Top = overviewBtn.Top;
            startPanel.BringToFront();
            startPanel.Visible = true;
            productPanel.Visible = false;
            data = new DataHelper(this);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = productBtn.Height;
            sideHighlight.Top = productBtn.Top;
            productPanel.BringToFront();
            startPanel.Visible = false;
            productPanel.Visible = true;
            data = new DataHelper(this);

            if (selectedShop == null) // if admin is logged on 
            {
                foodRbtn.Enabled = false;
                drinkRbtn.Enabled = false;
                quantitySelec.Enabled = false;
            }
            else
            {
                DisplayProducts();
            }
        }

        public void DisplayProducts()
        {
            if (selectedShop != null)
            {
                CrossThreadDisplay display = new CrossThreadDisplay(this);
                if (foodRbtn.Checked)
                {
                    display.DisplayArticle(data.GetFoodArticles(selectedShop.ShopNr), itemLbx);
                }
                else
                {
                    display.DisplayArticle(data.GetDrinkArticles(selectedShop.ShopNr), itemLbx);
                }
                display.Dispose();
            }
        }

        public void DisplayOrderItems()
        {
            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i]);
            }
        }


        private void ShopForm_Load(object sender, EventArgs e)
        {
            // init values
            o = new Order(selectedShop);
            data = new DataHelper(this);
            myRFIDReader = new RFID();

            myRFIDReader.Tag += new RFIDTagEventHandler(Pay);
            myRFIDReader.Open();

            if (selectedShop == null)
            {
                DataTable dt = data.DataTableFromSQL("SELECT ShopNr, ShopName FROM SHOP");

                comboBoxShop.ValueMember = "ShopNr";
                comboBoxShop.DisplayMember = "ShopName";
                comboBoxShop.DataSource = dt;
            }
            else
            {
                labelShopName.Text = "Store " + selectedShop.ShopName;
            }

            // GUI
            sideHighlight.Height = overviewBtn.Height;
            sideHighlight.Top = overviewBtn.Top;
            startPanel.BringToFront();
            startPanel.Visible = true;
            productPanel.Visible = false;
        }

        private void foodRbtn_CheckedChanged(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void quantitySelec_ValueChanged(object sender, EventArgs e)
        {
            if (itemLbx.SelectedItem != null && o.Articles.Contains((Article)itemLbx.SelectedItem))
            {
                int amount = Convert.ToInt32(quantitySelec.Value);
                if (((Article)itemLbx.SelectedItem).Available - amount <= 0)
                {
                    o.SetQuantity((Article)itemLbx.SelectedItem, ((Article)itemLbx.SelectedItem).Available);
                }
                else
                {
                    o.SetQuantity((Article)itemLbx.SelectedItem, amount);
                }

                labelOrderInfo.Text = o.ToString();
            }
        }

        private void itemLbx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (((Article)itemLbx.SelectedItem).Available > 0)
                {
                    o.AddArticle((Article)itemLbx.SelectedItem, 1);
                    labelOrderInfo.Text = o.ToString();
                    UpdateNumericUpDown();
                }
                else
                {
                    MessageBox.Show("Item is out of stock");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an item before double clicking");
            }
        }

        private void itemLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumericUpDown();
        }
        private void UpdateNumericUpDown()
        {
            if (itemLbx.SelectedItem != null)
            {
                if (o.Articles.Contains((Article)itemLbx.SelectedItem))
                {
                    quantitySelec.Value = o.Quantity[o.Articles.IndexOf((Article)itemLbx.SelectedItem)];
                }
            }
        }
        private void ProcessOrder()
        {
            if(MessageBox.Show("Confirm payment", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                o.OrderDate = DateTime.Now;

                if (data.CreateNewStoreOrder(o) == 1 && data.AddStoreOrderLine(o) != -1)
                {
                    DisplayProducts();
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText(o.ToString(), labelOrderInfo);
                    }
                    o = new Order(selectedShop);
                }
            }
            else
            {
                o = new Order(selectedShop);

            }
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.original.Show();
        }

        private void comboBoxShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShop = data.GetShopByNr(comboBoxShop.SelectedValue.ToString());
            labelShopName.Text = "Store " + selectedShop.ShopName;
            DisplayProducts();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            o = new Order(selectedShop);
            labelOrderInfo.Text = o.ToString();
        }

        public void LogMessage(string message)
        {
            if (startPanel.Visible)
            {
                lbxOverviewMessage.Items.Add(message);
            }
            if (productPanel.Visible)
            {
                lbProductMessage.Items.Add(message);
            }
        }

        private void btnOverviewClear_Click(object sender, EventArgs e)
        {
            lbxOverviewMessage.Items.Clear();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            lbProductMessage.Items.Clear();
        }
    }
}
