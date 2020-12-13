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
    public partial class ManagerForm : Form
    {
        /////////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        DataHelper dh;
        Form selectedForm;


        public ManagerForm()
        {
            InitializeComponent();
            sideHighlight.Height = eventBtn.Height;
            sideHighlight.Top = eventBtn.Top;
            //eventPanel.BringToFront();

            dh = new DataHelper();
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = eventBtn.Height;
            sideHighlight.Top = eventBtn.Top;

            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new VisitorForm();
            selectedForm.Show();
            selectedForm.Focus();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = shopBtn.Height;
            sideHighlight.Top = shopBtn.Top;

            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new ShopForm();
            selectedForm.Show();
            selectedForm.Focus();
        }

        private void campBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = campBtn.Height;
            sideHighlight.Top = campBtn.Top;

            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new CampForm();
            selectedForm.Show();
            selectedForm.Focus();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = inventoryBtn.Height;
            sideHighlight.Top = inventoryBtn.Top;

            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new StockForm();
            selectedForm.Show();
            selectedForm.Focus();
        }

        private void analyticBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = analyticBtn.Height;
            sideHighlight.Top = analyticBtn.Top;

            if (selectedForm != null)
            {
                selectedForm.Dispose();
            }
            selectedForm = new AnalyticForm();
            selectedForm.Show();
            selectedForm.Focus();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = transBtn.Height;
            sideHighlight.Top = transBtn.Top;
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = staffBtn.Height;
            sideHighlight.Top = staffBtn.Top;
           
           
        }
    }
}
