using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainApp
{
    public partial class mainEntranceForm : Form
    {
        #region GUICODE
        private void ChangeColor (object o, Color c)
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
        private void ShowButtonText (Button b, string t)
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
        public mainEntranceForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            monitorForm monitor = new monitorForm();
            monitor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.PaleTurquoise);
            ShowButtonText((Button)sender, "Monitor visitors");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(36, 198, 221));
            ResetButtonText((Button)sender);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.SeaGreen);
            ShowButtonText((Button)sender, "Check in");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(3, 231, 115));
            ResetButtonText((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkInForm checkIn = new checkInForm();
            checkIn.Show();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.IndianRed);
            ShowButtonText((Button)sender, "Check out");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(244, 91, 28));
            ResetButtonText((Button)sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            checkOutForm checkOut = new checkOutForm();
            checkOut.Show();
        }
    }
}
