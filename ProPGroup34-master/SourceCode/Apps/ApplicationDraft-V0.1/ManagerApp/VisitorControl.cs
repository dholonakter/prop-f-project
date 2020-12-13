using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;


namespace ManagerApp
{
    public partial class VisitorControl : UserControl
    {
        DataHelper dh;
        BindingSource visitorTable;
        public VisitorControl()
        {
            InitializeComponent();
            dh = new DataHelper();

            // Display data onto gridview
            visitorTable = new BindingSource();
            visitorTable.DataSource = dh.DataTableFromSQL("SELECT FirstName, LastName, Phone, Email, UserPassword, RFIDNr, Credit, CheckedIn, SpotNr" +
                " FROM VISITOR");
            dataGridViewVisitor.DataSource = visitorTable;

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            int totalPresent = dh.CountRowTable("VISITOR");
            labelTotalVisitors.Text = "Total visitors: " + (totalPresent + dh.CountRowTable("DELETED_VISITOR")).ToString();
            labelTotalPresent.Text = "Total present: " + totalPresent.ToString();
            labelTotalBalance.Text = "Total balance: " + dh.GetTotalBalance();
            labelTotalSpent.Text = "Total spent: " + dh.GetTotalSpent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)visitorTable.DataSource))
            {
                dataGridViewVisitor.Refresh();
                UpdateLabels();
            }
        }
    }
}

