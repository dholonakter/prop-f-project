using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;

namespace ManagerApp
{
    public partial class Login : Form
    {
        DataHelper dh;
        SoundPlayer sound = new SoundPlayer("../../../error.wav");

        public Login()
        {
            InitializeComponent();
            dh = new DataHelper();
        }



        private void ValidateLogin()
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                if (tbUsername.Text.StartsWith("admin") && dh.CheckCredentials(tbUsername.Text, tbPassword.Text) == 1)
                {
                    Form mf = new HomeForm();
                    mf.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login failed");
                    sound.Play();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateLogin();
            this.SendToBack();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter pressed
            {
                ValidateLogin();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
