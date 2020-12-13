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
    public partial class StockControl : UserControl
    {
        DataHelper dh;
        BindingSource dataTable;

        public StockControl()
        {
            InitializeComponent();
            dh = new DataHelper();
            Display("select a.ArticleNr, s.ShopName, a.ArticleName, a.Price, a.Available, a.IsLoanable from article a, shop s where a.ShopNr = s.ShopNr ");
        }

        private void Display(string sql)
        {
            // Display data onto gridview
            dataTable = new BindingSource();
            dataTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewInventory.DataSource = dataTable;
            dataGridViewInventory.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)dataTable.DataSource))
            {
                dataGridViewInventory.Refresh();
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Display("select a.ArticleNr, s.ShopName, a.ArticleName, a.Price, a.Available, a.IsLoanable from article a, shop s where a.ShopNr = s.ShopNr " +
               "and a.Available < " + Convert.ToInt32(textBox1.Text));
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            Display("select a.ArticleNr, s.ShopName, a.ArticleName, a.Price, a.Available, a.IsLoanable from article a, shop s where a.ShopNr = s.ShopNr ");
        }

    }
}
