using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainShop
{
    public partial class mainShopForm : Form
    {
        public mainShopForm()
        {
            InitializeComponent();
        }
        #region GUICODE
        private void ChangeColor(object o, Color c)
        {
            if (o is Button)
            {
                Button b = (Button)o;
                b.BackColor = c;
            }
            else if (o is Label)
            {
                Label l = (Label)o;
                l.BackColor = c;
            }
        }
        private void ShowButtonText(Button b, string t)
        {
            b.ImageAlign = ContentAlignment.TopCenter;
            b.Text = t;
            b.TextAlign = ContentAlignment.TopCenter;
        }
        private void ResetButtonText(Button b)
        {
            b.ResetText();
            b.ImageAlign = ContentAlignment.MiddleCenter;
        }
        #endregion
        private void mainShopForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productForm product = new productForm();
            product.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cartForm cart = new cartForm();
            cart.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "See products");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(3, 231, 115));
            ResetButtonText((Button)sender);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "See cart");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(255, 110, 64));
            ResetButtonText((Button)sender);
        }
    }
}
