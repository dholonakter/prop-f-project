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

namespace ManagerApp
{
    public partial class ShopForm : Form
    {
        DataHelper dh;
        BindingSource dataTable;
        string sql;

        public ShopForm()
        {
            InitializeComponent();
            dh = new DataHelper();
        }

        private void Display(string sql)
        {
            // Display data onto gridview
            dataTable = new BindingSource();
            dataTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewShop.DataSource = dataTable;
            dataGridViewShop.Refresh();
        }

        private void buttonMostPurchased_Click(object sender, EventArgs e)
        {
            sql = "select s.ShopName, ArticleNr, COUNT(*) 'Nr. of purchases' from all_order o, shop s where o.ShopNr = s.ShopNr group by o.ShopNr, ArticleNr, ShopName";
            Display(sql);
            dataGridViewShop.ReadOnly = true;
        }

        private void buttonTop5_Click(object sender, EventArgs e)
        {
            sql = "select s.ShopName, sum(Subtotal) 'Total earned' from all_order o, shop s where o.ShopNr = s.ShopNr group by o.ShopNr, ShopName LIMIT 5";
            dataGridViewShop.ReadOnly = true;
            Display(sql);
        }

        private void buttonAllStands_Click(object sender, EventArgs e)
        {
            sql = "select ShopNr, ShopName, LocationNr, LocationName from all_shop where IsStore = 0";
            dataGridViewShop.ReadOnly = false;
            Display(sql);
        }

        private void buttonAllStores_Click(object sender, EventArgs e)
        {
            dataGridViewShop.ReadOnly = false;
            Display("select ShopNr, ShopName, LocationNr, LocationName from all_shop where IsStore = 1");
        }

        private void buttonAllShops_Click(object sender, EventArgs e)
        {
            sql = "select ShopNr, ShopName, LocationName, IsStore from all_shop";
            dataGridViewShop.ReadOnly = false;
            Display(sql);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)dataTable.DataSource))
            {
                dataGridViewShop.Refresh();
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            //Display(sql);
        }

        private void dataGridViewShop_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dataGridViewShop_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
