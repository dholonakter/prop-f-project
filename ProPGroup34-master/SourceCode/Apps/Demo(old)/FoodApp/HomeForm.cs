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
    public partial class HomeForm : Form
    {


        public HomeForm()
        {
            InitializeComponent();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shop = new ShopForm();
            shop.Show();
        }

        private void rentalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentalForm rental = new RentalForm();
            rental.Show();
        }

        private void campBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CampingForm camp = new CampingForm();
            camp.Show();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntranceForm entrance = new EntranceForm();
            entrance.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewForm admin = new AdminViewForm();
            admin.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
