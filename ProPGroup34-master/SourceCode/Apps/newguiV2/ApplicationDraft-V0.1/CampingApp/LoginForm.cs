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

namespace CampingApp
{
    public partial class LoginForm : Form
    {
        DataHelper dh;

        public delegate void OnLoggedIn(object sender, EventArgs e);
        public event OnLoggedIn LoggedInHandler;

        public LoginForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.OK;
            dh = new DataHelper();
        }

        private void ValidateLogin()
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                if (tbUsername.Text.StartsWith("admin") && dh.CheckCredentials(tbUsername.Text, tbPassword.Text) == 1)
                {
                    if (LoggedInHandler != null)
                    {
                        this.LoggedInHandler(this, null); // fire them events
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }
    }
}
