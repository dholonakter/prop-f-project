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
    public partial class StaffForm : Form,ILogger
    {
        DataHelper dh;
        BindingSource staffTable;
        string sql;

        public StaffForm()
        {
            InitializeComponent();
            dh = new DataHelper(this);
            FillComboBox();
            ShowAll();
        }

        private void Display(string sql)
        {
            // Display data onto gridview
            staffTable = new BindingSource();
            staffTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewStaff.DataSource = staffTable;
            dataGridViewStaff.Columns[0].Visible = false;
            dataGridViewStaff.Refresh();
            labelSum.Text = "The sum of their monthly salary is: €" + GetSumSalary().ToString("0.00");
        }

        private void FillComboBox()
        {
            DataTable dt = dh.DataTableFromSQL("SELECT JobDescription FROM Job");
            comboBoxTitle.ValueMember = "JobDescription";
            comboBoxTitle.DisplayMember = "JobDescription";
            comboBoxTitle.DataSource = dt;
        }

        private double GetSumSalary()
        {
            double sum = 0;
            for (int i = 0; i <= dataGridViewStaff.RowCount - 1; i++)
            {
                sum += Convert.ToDouble(dataGridViewStaff.Rows[i].Cells[7].Value);
            }
            return sum;
        }

        private void ShowAll()
        {
            sql = "Select * from staff"; // dont you love it when you havev iews
            Display(sql);
            labelCount.Text = "You have in total " + (dataGridViewStaff.RowCount - 1) + " people"; // minus empty row from hell
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            sql = "select * from staff where JobDescription = '" + comboBoxTitle.SelectedValue + "'";
            Display(sql);
            labelCount.Text = "You have " + (dataGridViewStaff.RowCount - 1) + " people in this position"; // minus empty row from hell
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)staffTable.DataSource))
            {
                dataGridViewStaff.Refresh();
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        public void LogMessage(string message)
        {
        }
    }
}
