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
    public partial class CampForm : Form
    {
        DataHelper dh;
        BindingSource campTable;
        string sql;

        public CampForm()
        {
            InitializeComponent();

            dh = new DataHelper();
            ShowAll();
        }

        private void Display(string sql)
        {
            // Display data onto gridview
            campTable = new BindingSource();
            campTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewCamp.DataSource = campTable;

            // hide foreign keys
            dataGridViewCamp.Columns[0].Visible = false;
            dataGridViewCamp.Columns[2].Visible = false;

            dataGridViewCamp.Refresh();
        }

        private void ShowAll()
        {
            sql = "Select * FROM all_SPOT";
            Display(sql);
            foreach (DataGridViewRow row in dataGridViewCamp.Rows)
            {
                if (Convert.ToInt32(row.Cells["IsFree"].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)campTable.DataSource))
            {
                dataGridViewCamp.Refresh();
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM all_SPOT WHERE ToBeServiced = 1";
            Display(sql);
        }

        private void buttonAvailable_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM all_SPOT WHERE IsFree = 1";
            Display(sql);
        }

        private void buttonBooked_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM all_spot where IsFree = 0";
            Display(sql);
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void dataGridViewCamp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewCamp_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)campTable.DataSource))
            {
                dataGridViewCamp.Refresh();
            }
        }
    }
}
