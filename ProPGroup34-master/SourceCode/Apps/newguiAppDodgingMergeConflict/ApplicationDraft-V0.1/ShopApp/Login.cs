using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;

namespace ShopApp
{
    public partial class Login : Form
    {
        DataHelper dh;

        public Login()
        {
            InitializeComponent();
            dh = new DataHelper();
        }
        private void ValidateLogin()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text.StartsWith("store") || textBox1.Text.StartsWith("admin"))
                {
                    if (dh.CheckCredentials(textBox1.Text, textBox2.Text) == 1)
                    {
                        // username should follow format: shop[shopNr] 
                        // the following code extracts the shopNr
                        string nr = Regex.Match(textBox1.Text, @"\d+").Value; // love and respect for regular expressions
                        this.Hide();
                        Form mf;
                        if (textBox1.Text.StartsWith("admin"))
                        {
                            mf = new ShopForm(null);
                        }
                        else
                        {
                            mf = new ShopForm(dh.GetShopByNr(Convert.ToInt32(nr)));
                        }
                        mf.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter pressed
            {
                ValidateLogin();
            }
        }
    }
}
