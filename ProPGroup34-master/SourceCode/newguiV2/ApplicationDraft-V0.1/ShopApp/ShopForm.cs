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
    public partial class ShopForm : Form
    {

        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////
        int pagination = 0;
        Order o;
        DataHelper data;
        Shop selectedShop;
        Visitor v;
        RFID myRFIDReader;

        List<StoreArticle> allProducts;
        List<Button> buttons;
        List<Label> labels;

        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        // borrowed code
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        ///////////////////////////////////////
        // STARTUP
        ///////////////////////////////////////

        public ShopForm(Shop s)
        {
            InitializeComponent();
            if (s != null)
            {
                selectedShop = s;
            }
            else
            {
                MessageBox.Show("You are logged in as admin");
            }
        }
        private int compareButtons(Button x, Button y)
        {
            int idOfX = Convert.ToInt32(x.Name.Substring(13));
            int idOfY = Convert.ToInt32(y.Name.Substring(13));
            return idOfX.CompareTo(idOfY);
        }

        private int compareLabels(Label x, Label y)
        {
            int idOfX = Convert.ToInt32(x.Name.Substring(12));
            int idOfY = Convert.ToInt32(y.Name.Substring(12));
            return idOfX.CompareTo(idOfY);
        }
        
        private void ShopForm_Load(object sender, EventArgs e)
        {
            // init values
            o = new Order(selectedShop);
            data = new DataHelper();
            myRFIDReader = new RFID();
            myRFIDReader.Tag += new RFIDTagEventHandler(Pay);
            myRFIDReader.Open();

            buttons = new List<Button>();
            labels = new List<Label>();
            allProducts = data.GetAllStoreArticles(selectedShop);
            allProducts.Sort();


            labelShopName.Text = "Store " + selectedShop.ShopName;

            // GUI
            sideHighlight.Height = orderBtn.Height;
            sideHighlight.Top = orderBtn.Top;
            productPanel.BringToFront();

            // Store all the product buttons
            var buttonsInForms = GetAll(this, typeof(Button));
            foreach (Button b in buttonsInForms)
            {
                if (b.Name.StartsWith("productButton"))
                {
                    b.Text = ""; // clear text;
                    buttons.Add(b);
                }
            }

            buttons.Sort(new Comparison<Button>(compareButtons));

            // Store all the labels
            var labelsInForms = GetAll(this, typeof(Label));
            foreach (Label l in labelsInForms)
            {
                if (l.Name.StartsWith("productLabel"))
                {
                    l.Text = ""; // clear text
                    labels.Add(l);
                }
            }

            labels.Sort(new Comparison<Label>(compareLabels));

            DisplayProducts();
        }


        ///////////////////////////////////////
        // RFID EVENTS HANDLERS
        ///////////////////////////////////////
        private void Pay(object sender, RFIDTagEventArgs e)
        {
            timerScanCard.Stop();
            buttonConfirm.Text = "Confirm";

            // Find a visitor
            v = data.FindVisitorByTag(e.Tag);
            
            if (v != null)
            {
                // Create order
                o.OrderDate = DateTime.Now;
                o.VisitorNr = v.IdNr;

                if (data.CreateNewOrder(o) == 1 && data.AddStoreOrderLine(o) != -1)
                {
                    o.OrderNr = data.GetRightOrderNr(o);
                    labelOrderInfo.Text += "\nOrder nr. " + o.OrderNr + " processed";
                }

                // Pay up babey
                
                if (v.Credit < o.GetSum())
                {
                    labelOrderInfo.Text = ("Visitor does not have enough credit.");
                }
                else
                {
                    v.Credit -= o.GetSum();
                    data.UpdateSelectedVisitor(v);
                }


            }
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = orderBtn.Height;
            sideHighlight.Top = orderBtn.Top;
            productPanel.BringToFront();
        }
        
        private void productBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = stockBtn.Height;
            sideHighlight.Top = stockBtn.Top;
            startPanel.BringToFront();
        }

        private void ClearProducts()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Visible = false;
                labels[i].Visible = false;
            }
        }

        public void DisplayProducts()
        {
            
            int stopNumber = allProducts.Count > buttons.Count ? buttons.Count : allProducts.Count;


            ClearProducts();

            for (int i = 0; i < stopNumber; i++)
            {
                if (i + buttons.Count * pagination > allProducts.Count - 1)
                {
                    break;
                }

                buttons[i].Visible = true;
                labels[i].Visible = true;

                // index backwards due to recursion method
                buttons[i].Image = System.Drawing.Image.FromFile("../../img/" + allProducts[i + buttons.Count * pagination].ImgFile);
                labels[i].Text = allProducts[i + buttons.Count * pagination].ArticleName;

                if (allProducts[i + buttons.Count * pagination].Category == "Food")
                {
                    buttons[i].BackColor = Color.LightSalmon;
                }
                else if (allProducts[i + buttons.Count * pagination].Category == "Drink")
                {
                    buttons[i].BackColor = Color.LightGreen;
                }
                else if (allProducts[i + buttons.Count * pagination].Category == "Uncategorized")
                {
                    buttons[i].BackColor = Color.Silver;
                }
            }
        }

        public void DisplayOrderItems()
        {
            itemLbx.Items.Clear();
            for (int i = 0; i < o.Articles.Count; i++)
            {
                itemLbx.Items.Add(o.Articles[i] + "; Quantity: " + o.Quantity[i]);
            }
            labelOrderInfo.Text = "Total: €" + o.GetSum().ToString("0.00");
        }
        
        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.original.Show();
        }
        

        private void AddArticle(Button button)
        {
            int idOfButton = Convert.ToInt32(button.Name.Substring(13)); // gets the id from the control's name
            if (o != null)
            {
                o.AddArticle(allProducts[idOfButton - 1], 1);
                DisplayOrderItems();
            }
        }

        private void productButton1_Click(object sender, EventArgs e)
        {
            AddArticle((Button)sender);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (itemLbx.SelectedIndex != -1)
            {
                int selectedIndex = itemLbx.SelectedIndex;
                if (o.Quantity[selectedIndex] - 1 == 0)
                {
                    itemLbx.Items.Remove(itemLbx.SelectedItem);
                }
                o.SetQuantity(o.Articles[selectedIndex], o.Quantity[selectedIndex] - 1);
                DisplayOrderItems();
            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            if (itemLbx.SelectedIndex != -1)
            {
                int selectedIndex = itemLbx.SelectedIndex;
                o.SetQuantity(o.Articles[selectedIndex], o.Quantity[selectedIndex] + 1);
                DisplayOrderItems();
            }
        }
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            o = new Order(selectedShop);
            itemLbx.Items.Clear();
            labelOrderInfo.Text = "";
        }

        private void timerScanCard_Tick(object sender, EventArgs e)
        {
            o = new Order(selectedShop);
            itemLbx.Items.Clear();
            labelOrderInfo.Text = "";
            timerScanCard.Stop();
            buttonConfirm.Text = "Confirm";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            buttonConfirm.Text = "Await scan";
            timerScanCard.Start();
        }

        private void DisplayListOfArticles(List<StoreArticle> foundArticles)
        {
            logsInfoLbx.Items.Clear();
            if (foundArticles.Count != 0)
            {
                foreach (StoreArticle a in foundArticles)
                {
                    logsInfoLbx.Items.Add(a);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No articles found");
            }
        }

        private void viewHistoryBtn_Click(object sender, EventArgs e)
        {
            StoreArticle selectedItem = (StoreArticle)logsInfoLbx.SelectedItem;
            if (selectedItem != null)
            {
                List<Order> foundOrders = data.GetStoreArticleOrderHistory(selectedShop, selectedItem);
                logsInfoLbx.Items.Clear();
                if (foundOrders.Count != 0)
                {
                    foreach (Order o in foundOrders)
                    {
                        Visitor buyer = data.FindVisitorByNr(o.VisitorNr);
                        logsInfoLbx.Items.Add("Order nr." + o.OrderNr + " on " + o.OrderDate
                            + "; Sold to: " + buyer.FirstName + ", " + buyer.LastName.ToUpper()
                            + "; Phone nr. " + buyer.Phone);
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No order found");
                }
            }
        }

        private void viewStockBtn_Click(object sender, EventArgs e)
        {
            List<StoreArticle> foundArticles = data.GetAllStoreArticles(selectedShop);
            DisplayListOfArticles(foundArticles);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            if (itemNameRbtn.Checked)
            {
                List<StoreArticle> foundArticles = data.GetStoreArticlesContaining(selectedShop, textBoxSearch.Text);
                DisplayListOfArticles(foundArticles);
            }
            else if (itemNrRbtn.Checked)
            {
                StoreArticle foundArticle = data.FindStoreArticleByNr(Convert.ToInt32(textBoxSearch.Text), selectedShop);
                if (foundArticle != null)
                {
                    logsInfoLbx.Items.Add(foundArticle);
                }
                else
                {
                    logsInfoLbx.Items.Add("No articles found");
                }
            }
            else if (personNameRbtn.Checked)
            {
                List<Visitor> visitorsWithName = data.FindVisitorByName(textBoxSearch.Text);
                List<Order> foundOrders = data.GetStoreArticleWithVisitorNrs(selectedShop, visitorsWithName);
                logsInfoLbx.Items.Clear();
                if (foundOrders.Count != 0)
                {
                    foreach (Order o in foundOrders)
                    {
                        Visitor buyer = data.FindVisitorByNr(o.VisitorNr);
                        foreach(Article a in o.Articles)
                        {
                            logsInfoLbx.Items.Add("Order nr." + o.OrderNr + " on " + o.OrderDate
                            + "; Article nr. " + a.ArticleNr + ": "  + a.ArticleName
                            + "; Sold to: " + buyer.FirstName + ", " + buyer.LastName.ToUpper()
                            + "; Phone nr. " + buyer.Phone);
                        }
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No order found");
                }
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pagination++;
            DisplayProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagination--;
            DisplayProducts();
        }
    }
}
