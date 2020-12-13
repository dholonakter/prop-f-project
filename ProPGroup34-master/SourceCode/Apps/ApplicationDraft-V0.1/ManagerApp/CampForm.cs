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
    public partial class CampForm : Form,ILogger
    {
        DataHelper dh;
        BindingSource campTable;
        string sql;

        public CampForm()
        {
            InitializeComponent();

            dh = new DataHelper(this);
            ShowAll();
        }

        private void Display(string sql)
        {
            // Display data onto gridview
            campTable = new BindingSource();
            campTable.DataSource = dh.DataTableFromSQL(sql);
            dataGridViewCamp.DataSource = campTable;
            dataGridViewCamp.Columns[0].Visible = false;
            dataGridViewCamp.Refresh();
        }

        private void ShowAll()
        {
            sql = "Select * FROM all_SPOT";
            Display(sql);
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
            timerUpdate.Start();
            sql = "SELECT * FROM all_SPOT WHERE ToBeServiced = 1";
            Display(sql);
        }

        private void buttonAvailable_Click(object sender, EventArgs e)
        {
            timerUpdate.Start();
            sql = "SELECT * FROM free_spots";
            Display(sql);
        }

        private void buttonBooked_Click(object sender, EventArgs e)
        {
            timerUpdate.Start();
            sql = "SELECT * FROM all_spot s WHERE exists (select 1 from camping_reservation r where r.SpotNr = s.SpotNr)";
            Display(sql);
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            Display(sql);
        }

        private void dataGridViewCamp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            timerUpdate.Start();
        }

        private void dataGridViewCamp_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
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
            lbxCampMessage.Items.Add(message);
        }
    }
}
