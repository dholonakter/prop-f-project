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
    public partial class StockForm : Form,ILogger
    {
        DataHelper dh;
        BindingSource dataTable;
        string sql;


        public StockForm()
        {
            InitializeComponent();
            dh = new DataHelper(this);
            timerUpdate.Start();
            sql = "select ArticleNr, ShopName, ShopNr, ArticleName, Price, Available, IsLoanable, DepositValue from all_article";
            Display(sql);
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
            timerUpdate.Start();
            sql = "select ArticleNr, ShopName, ShopNr, ArticleName, Price, Available, IsLoanable from all_article where Available < " + Convert.ToInt32(numericUpDown1.Value);
            Display(sql);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            timerUpdate.Start();
            sql = "select ArticleNr, ShopName, ShopNr, ArticleName, Price, Available, IsLoanable from all_article";
            Display(sql);
        }
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            Display(sql);
        }

        private void dataGridViewInventory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            timerUpdate.Start();
        }

        private void dataGridViewInventory_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            timerUpdate.Stop();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        public void LogMessage(string message)
        {
            lbxInventoryMessage.Items.Add(message);
        }
    }
}
