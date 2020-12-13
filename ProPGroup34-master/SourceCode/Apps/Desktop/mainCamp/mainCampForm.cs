using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainCamp
{
    public partial class mainCampForm : Form
    {
        public mainCampForm()
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
        #endregion
        private void button2_Click(object sender, EventArgs e)
        {
            checkInCampForm checkInCamp = new checkInCampForm();
            checkInCamp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            campStatusForm campStatus = new campStatusForm();
            campStatus.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "Check in");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(3, 231, 115));
            ResetButtonText((Button)sender);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ShowButtonText((Button)sender, "Camp status");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(242, 173, 89));
            ResetButtonText((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monitorCampForm monitorCamp = new monitorCampForm();
            monitorCamp.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.PaleTurquoise);
            ShowButtonText((Button)sender, "Monitor reservations");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ChangeColor(sender, Color.FromArgb(36, 198, 221));
            ResetButtonText((Button)sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
