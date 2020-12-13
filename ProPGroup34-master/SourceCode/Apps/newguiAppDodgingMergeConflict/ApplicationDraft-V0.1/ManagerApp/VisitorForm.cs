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
using Phidget22;
using Phidget22.Events;

namespace ManagerApp
{
    public partial class VisitorForm : Form
    {
        DataHelper dh;
        BindingSource visitorTable;
        RFID myRFIDReader;
        string sql;

        public VisitorForm()
        {
            InitializeComponent();
            dh = new DataHelper();
            myRFIDReader = new RFID();

            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += ScanRFID; 
                myRFIDReader.Open();

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failure to connect to RFID reader");
            }


            // startup display

            Display("SELECT IdNr, FirstName, LastName, Phone, Email, UserPassword, RFIDNr, Credit, CheckedIn, IsInCamp" + " FROM VISITOR");

            chartVisitor.Titles.Clear();
            DataSet ds = dh.GetDataset("select (select count(*) from visitor where CheckedIn = 1) 'Present', "
                + "(select count(*) from deleted_visitor) 'Left', "
                + "(select count(*) from visitor where CheckedIn = 0) 'NotCheckedIn' "
                + " from dual ");
            chartVisitor.Series["Visitors"].Points.AddXY("Present", ds.Tables[0].Rows[0]["Present"].ToString());
            chartVisitor.Series["Visitors"].Points.AddXY("Left", ds.Tables[0].Rows[0]["Left"].ToString());
            chartVisitor.Series["Visitors"].Points.AddXY("Not checked in", ds.Tables[0].Rows[0]["NotCheckedIn"].ToString());
            chartVisitor.Titles.Add("Visitors");

            UpdateLabels();
        }
        private void ScanRFID(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag != null)
            {
                CrossThreadDisplay display = new CrossThreadDisplay(this);
                display.SetTextBox(e.Tag, textBoxSearch);
            }
        }
        private void Display(string sql)
        {
            // Display data onto gridview
            visitorTable = new BindingSource();
            visitorTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewVisitor.DataSource = visitorTable;
            dataGridViewVisitor.Columns[0].Visible = false;
            dataGridViewVisitor.Refresh();
        }

        private void UpdateLabels()
        {
            int totalPresent = dh.CountRowTable("VISITOR");
            labelTotalVisitors.Text = "Total visitors: " + (totalPresent + dh.CountRowTable("DELETED_VISITOR")).ToString();
            //labelTotalPresent.Text = "Total present: " + totalPresent.ToString();
            labelTotalBalance.Text = "Total balance: " + dh.GetTotalBalance().ToString("0.00");
            //labelTotalSpent.Text = "Total spent: " + dh.GetTotalSpent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)visitorTable.DataSource))
            {
                dataGridViewVisitor.Refresh();
                UpdateLabels();
            }
        }

        private void dataGridViewVisitor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewVisitor_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            sql = "SELECT IdNr, FirstName, LastName, Phone, Email, UserPassword, RFIDNr, Credit, CheckedIn, IsInCamp" + " FROM VISITOR";
            Display(sql);
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewVisitor.CurrentRow.Cells[0].Value != null)
            {
                int selectedIdNr = Convert.ToInt32(dataGridViewVisitor.CurrentRow.Cells[0].Value);
                Visitor v = dh.FindVisitorByNr(selectedIdNr);
                sql = "select o.OrderNr, o.OrderDate, s.ShopName, s.LocationName from shop_order o, all_shop s where o.ShopNr = s.ShopNr and o.VisitorNr = " + v.IdNr;
                Display(sql);
            }
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Display(sql);
            UpdateLabels();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (nameRbtn.Checked)
            {
                string name = textBoxSearch.Text;
                Display("SELECT * FROM VISITOR WHERE FirstName LIKE '%" + name + "%' OR LastName LIKE '%" + name + "%'");
            }
            else if (tagRbtn.Checked)
            {
                string rfidNr = textBoxSearch.Text;
                Display("SELECT * FROM VISITOR WHERE RFIDNr = '" + rfidNr + "'");
            }
            textBoxSearch.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT * FROM visitor where CheckedIn = 1";
            Display(sql);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM deleted_visitor";
            Display(sql);
        }
    }
}
