using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
            sideHighlight.Height = costumeBtn.Height;
            sideHighlight.Top = costumeBtn.Top;
            costumesControl1.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void costumeBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = costumeBtn.Height;
            sideHighlight.Top = costumeBtn.Top;
            costumesControl1.BringToFront();
        }

        private void chargeBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = chargeBtn.Height;
            sideHighlight.Top = chargeBtn.Top;
            chargersControl1.BringToFront();
        }

        private void cameraBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = cameraBtn.Height;
            sideHighlight.Top = cameraBtn.Top;
            cameraControl1.BringToFront();
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = otherBtn.Height;
            sideHighlight.Top = otherBtn.Top;
            otherControl1.BringToFront();
        }

        private void otherControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
