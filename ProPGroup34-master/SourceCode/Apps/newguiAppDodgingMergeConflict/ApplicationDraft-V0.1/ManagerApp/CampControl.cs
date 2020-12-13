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
    public partial class CampControl : UserControl
    {
        DataHelper dh;
        BindingSource campTable;
        public CampControl()
        {
            InitializeComponent();

            dh = new DataHelper();
            ShowAll();
            }
            private void ShowAll()
            {
                // Display data onto gridview
                campTable = new BindingSource();
                campTable.DataSource = dh.DataTableFromSQL("SELECT * FROM CAMPING_SPOT");
                dataGridViewCamp.DataSource = campTable;
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
                // Display data onto gridview
                campTable = new BindingSource();
                campTable.DataSource = dh.DataTableFromSQL("SELECT * FROM CAMPING_SPOT WHERE ToBeServiced = 1");
                dataGridViewCamp.DataSource = campTable;
                dataGridViewCamp.Refresh();
            }

            private void buttonAvailable_Click(object sender, EventArgs e)
            {
                // Display data onto gridview
                campTable = new BindingSource();
                campTable.DataSource = dh.DataTableFromSQL("SELECT * FROM camping_spot s WHERE not exists (select 1 from camping_reservation r where r.SpotNr = s.SpotNr)");
                dataGridViewCamp.DataSource = campTable;
                dataGridViewCamp.Refresh();
            }

            private void buttonBooked_Click(object sender, EventArgs e)
            {
                // Display data onto gridview
                campTable = new BindingSource();
                campTable.DataSource = dh.DataTableFromSQL("SELECT * FROM camping_spot s WHERE exists (select 1 from camping_reservation r where r.SpotNr = s.SpotNr)");
                dataGridViewCamp.DataSource = campTable;
                dataGridViewCamp.Refresh();
            }

            private void buttonAll_Click(object sender, EventArgs e)
            {
                ShowAll();
            }
        }
}
