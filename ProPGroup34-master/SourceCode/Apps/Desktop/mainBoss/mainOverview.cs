using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainBoss
{
    public partial class mainOverview : Form
    {
        public mainOverview()
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
            b.ImageAlign = ContentAlignment.MiddleCenter;
            b.Text = t;
            b.TextAlign = ContentAlignment.BottomCenter;
        }
        private void ResetButtonText(Button b)
        {
            b.ResetText();
            b.ImageAlign = ContentAlignment.MiddleCenter;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(button4, Color.FromArgb(54, 104, 58)); // camp
            ChangeColor(button6, Color.FromArgb(117, 87, 42)); // staff
            ChangeColor(button1, Color.FromArgb(25, 65, 84)); // shops
            ShowButtonText((Button)sender, "Event");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(button2, Color.FromArgb(48, 66, 107)); // event
            ChangeColor(button6, Color.FromArgb(117, 87, 42)); // staff
            ChangeColor(button1, Color.FromArgb(25, 65, 84)); // shops
            ShowButtonText((Button)sender, "Camps");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(button2, Color.FromArgb(48, 66, 107)); // event
            ChangeColor(button6, Color.FromArgb(117, 87, 42)); // staff
            ChangeColor(button4, Color.FromArgb(54, 104, 58)); // camp
            ShowButtonText((Button)sender, "Stores");
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(button2, Color.FromArgb(48, 66, 107)); // event
            ChangeColor(button1, Color.FromArgb(25, 65, 84)); // shops
            ChangeColor(button4, Color.FromArgb(54, 104, 58)); // camp
            ShowButtonText((Button)sender, "Staff");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonText((Button)sender);
            ChangeColor(button4, Color.FromArgb(102, 187, 106)); // camp
            ChangeColor(button6, Color.FromArgb(255, 191, 96)); // staff
            ChangeColor(button1, Color.FromArgb(79, 195, 247)); // shops
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonText((Button)sender);
            ChangeColor(button6, Color.FromArgb(255, 191, 96)); // staff
            ChangeColor(button2, Color.FromArgb(89, 118, 185)); // event
            ChangeColor(button1, Color.FromArgb(79, 195, 247)); // shops
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonText((Button)sender);
            ChangeColor(button4, Color.FromArgb(102, 187, 106)); // camp
            ChangeColor(button6, Color.FromArgb(255, 191, 96)); // staff
            ChangeColor(button2, Color.FromArgb(89, 118, 185)); // event
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ResetButtonText((Button)sender);
            ChangeColor(button4, Color.FromArgb(102, 187, 106)); // camp
            ChangeColor(button1, Color.FromArgb(79, 195, 247)); // shops
            ChangeColor(button2, Color.FromArgb(89, 118, 185)); // event
        }
        #endregion

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void mainOverview_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            overviewEvent viewEvent = new overviewEvent();
            viewEvent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            overviewShop viewShop = new overviewShop();
            viewShop.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            overviewStaff viewStaff = new overviewStaff();
            viewStaff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            overviewCamp viewCamp = new overviewCamp();
            viewCamp.Show();
        }
    }
}
