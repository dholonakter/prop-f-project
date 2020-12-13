using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class HomeForm : Form
    {
        Form selectedForm;

        public HomeForm()
        {
            InitializeComponent();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.home.Focus();
        }

        private void visitorBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new VisitorForm();
            selectedForm.Show();
            selectedForm.BringToFront();
            this.Dispose();
        }

        private void campBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new CampForm();
            selectedForm.Show();
            selectedForm.BringToFront();
            this.Dispose();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new StaffForm();
            selectedForm.Show();
            selectedForm.BringToFront();
            this.Dispose();
        }


        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new TransactionForm();
            selectedForm.Show();
            selectedForm.BringToFront();
            this.Dispose();
        }



    }
}
