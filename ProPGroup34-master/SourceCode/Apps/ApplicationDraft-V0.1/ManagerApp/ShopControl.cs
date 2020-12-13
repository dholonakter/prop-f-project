using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class ShopControl : UserControl
    {
        DataHelper dh;
        BindingSource dataTable;
        public ShopControl()
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
                Display("select s.ShopName, ArticleNr, COUNT(*) 'Nr. of purchases' from all_order o, shop s where o.ShopNr = s.ShopNr group by o.ShopNr, ArticleNr, ShopName");
                dataGridViewShop.ReadOnly = true;
            }

            private void buttonTop5_Click(object sender, EventArgs e)
            {
                dataGridViewShop.ReadOnly = true;
                Display("select s.ShopName, sum(Subtotal) 'Total earned' from all_order o, shop s where o.ShopNr = s.ShopNr group by o.ShopNr, ShopName LIMIT 5");
            }

            private void buttonAllStands_Click(object sender, EventArgs e)
            {
                dataGridViewShop.ReadOnly = false;
                Display("select ShopNr, ShopName, LocationNr, LocationName from list_of_stands");
            }

            private void buttonAllStores_Click(object sender, EventArgs e)
            {
                dataGridViewShop.ReadOnly = false;
                Display("select ShopNr, ShopName, LocationNr, LocationName from list_of_stores");
            }

            private void buttonAllShops_Click(object sender, EventArgs e)
            {
                dataGridViewShop.ReadOnly = false;
                Display("select s.ShopNr, s.ShopName, l.LocationName, s.IsStore from shop s , location l where s.LocationNr = l.LocationNr");
            }

            private void buttonSave_Click(object sender, EventArgs e)
            {
                if (dh.UpdateTable((DataTable)dataTable.DataSource))
                {
                    dataGridViewShop.Refresh();
                }
            }
        }
}
