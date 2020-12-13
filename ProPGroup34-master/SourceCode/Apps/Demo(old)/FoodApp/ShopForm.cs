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
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            sideHighlight.Height = foodBtn.Height;
            sideHighlight.Top = foodBtn.Top;
            foodCustomControl1.BringToFront();
        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = foodBtn.Height;
            sideHighlight.Top = foodBtn.Top;
            foodCustomControl1.BringToFront();
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = snackBtn.Height;
            sideHighlight.Top = snackBtn.Top;
            snacksCustomControl1.BringToFront();
        }

        private void drinkBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = drinkBtn.Height;
            sideHighlight.Top = drinkBtn.Top;
            drinksCustomControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
