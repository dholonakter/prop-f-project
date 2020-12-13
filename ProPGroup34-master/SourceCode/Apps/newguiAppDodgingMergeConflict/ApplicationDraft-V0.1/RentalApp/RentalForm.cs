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
using MySql;
using Phidget22;
using Phidget22.Events;
using System.Globalization;

namespace RentalApp
{
    public partial class RentalForm : Form
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////
        LoanOrder o; // to keep data of current loan order
        DataHelper data; // to get data from db 
        bool borrow; // to see if the customer is borrow or returning
        Shop selectedShop; // the current shop
        Visitor v; // the current visitor
        RFID myRFIDReader; // rfid reader 
        DateTime maximumReturnDate; // a fixed maximum return date

        // delegate for rfid reader
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        ///////////////////////////////////////
        // STARTUP
        ///////////////////////////////////////
        public RentalForm(Shop s)
        {
            InitializeComponent();
            selectedShop = s;
            ResetGUI();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            // init values
            borrow = true;
            data = new DataHelper();
            myRFIDReader = new RFID();
            myRFIDReader.Tag += ScanVisitor;
            o = new LoanOrder(selectedShop);

            // init
            maximumReturnDate = DateTime.Now.AddDays(3);

            myRFIDReader.Open();

            // GUI
            labelMessageB.Text = "You will return this by " + returnDatePicker.Value;
            labelShopName.Text = "Loan Stand " + selectedShop.ShopName;
            sideHighlight.Height = borrowBtn.Height;
            sideHighlight.Top = borrowBtn.Top;
            borrowPanel.BringToFront();
        }

        ///////////////////////////////////////
        // GUI
        ///////////////////////////////////////
        private void ResetGUI()
        {
            labelVisitorB.Text = "";
            labelVisitorR.Text = "";
            labelMessageB.Text = "";
            labelMessageR.Text = "";
            labelInfoR.Text = "";
            loanInfoLbx.Items.Clear();
            returnLbx.Items.Clear();
            o = new LoanOrder(selectedShop);
        }
        private void monitorBtn_Click(object sender, EventArgs e)
        {
            ResetGUI();
            sideHighlight.Height = borrowBtn.Height;
            sideHighlight.Top = borrowBtn.Top;
            startPanel.BringToFront();
        }
        private void productBtn_Click(object sender, EventArgs e)
        {
            ResetGUI();
            sideHighlight.Height = borrowBtn.Height;
            sideHighlight.Top = borrowBtn.Top;
            borrowPanel.BringToFront();

            // switchy switch
            borrow = true;
            myRFIDReader.Tag -= ScanToBorrow;
            myRFIDReader.Tag -= ScanToReturn;
            myRFIDReader.Tag += ScanVisitor;
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            ResetGUI();
            sideHighlight.Height = returnBtn.Height;
            sideHighlight.Top = returnBtn.Top;
            returnPanel.BringToFront();

            // switchy switch
            borrow = false;
            myRFIDReader.Tag -= ScanToBorrow;
            myRFIDReader.Tag -= ScanToReturn;
            myRFIDReader.Tag += ScanVisitor;
        }
        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.original.Show();
        }

        ///////////////////////////////////////
        // RFID EVENTS HANDLERS
        ///////////////////////////////////////
        private void ScanVisitor(object sender, RFIDTagEventArgs e)
        {
            o = new LoanOrder(selectedShop);
            v = data.FindVisitorByTag(e.Tag);
            if (v != null)
            {
                using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                {
                    string infoVisitor = "Visitor nr. " + v.IdNr + ": " + v.FirstName + ", " + v.LastName.ToUpper();
                    display.SetText(infoVisitor, labelVisitorB);
                    display.SetText(infoVisitor, labelVisitorR);
                }

                if (MessageBox.Show("Please start scanning your items", "Confirm", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    myRFIDReader.Tag -= ScanVisitor;
                    if (borrow)
                    {
                        myRFIDReader.Tag += ScanToBorrow;
                    }
                    else
                    {
                        myRFIDReader.Tag += ScanToReturn;
                    }
                }
            }
        }

        private void ScanToBorrow(object sender, RFIDTagEventArgs e)
        {
            LoanArticle a = data.FindLoanArticleByTag(e.Tag);

            try
            {
                if (o.ExistsArticle(a))
                {
                    MessageBox.Show("Items already added");
                }
                else
                {
                    o.AddArticle(a, 1); // borrowing 1 article
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.DisplayArticle(o.Articles, loanInfoLbx);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Item not found");
            }
        }

        private void ScanToReturn(object sender, RFIDTagEventArgs e)
        {
            if (v != null)
            {
                LoanArticle a = data.FindLoanArticleByTag(e.Tag);
                v = data.FindVisitorByNr(data.GetVisitorNrForLoanArticle(a));
                labelMessageR.Text = "Article successfully scanned";
                DateTime returnDateOfItem = data.GetReturnDateForLoanArticle(a);
                double fee = a.DepositValue - a.Price;

                labelInfoR.Text = a.ToString();
                labelInfoR.Text += "\nReturn date: " + returnDateOfItem;
                labelInfoR.Text += "\nDeposit value: " + a.DepositValue;
                labelInfoR.Text += "\nLoaning price: " + a.Price;

                if (returnDateOfItem != DateTime.MinValue) // if found a return date
                {
                    if (returnDateOfItem.CompareTo(DateTime.Now) < 0) // if return date is earlier than now
                    {
                        fee -= 10; // 10 credits fine
                        labelInfoR.Text += "\nLate fine: 10 credits";
                    }
                    v.Credit += fee;
                    data.UpdateSelectedVisitor(v);
                    labelInfoR.Text += "\nTotal credits returned: " + fee;
                    a.Available = 1;

                    if (data.UpdateLoanArticle(a) != -1)
                    {
                        labelMessageR.Text = "Article successfully returned";
                    }

                }
            }
        }

        private void ScanRFID(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag != null)
            {
                CrossThreadDisplay display = new CrossThreadDisplay(this);
                display.SetTextBox(e.Tag, textBoxSearch);
            }
        }

        ///////////////////////////////////////
        // BORROW PANEL
        ///////////////////////////////////////
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // reset
            myRFIDReader.Tag -= ScanToBorrow;
            myRFIDReader.Tag -= ScanToReturn;
            myRFIDReader.Tag += ScanVisitor;

            if (MessageBox.Show("Confirm payment?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (borrow)
                {

                    o.ReturnDate = returnDatePicker.Value;
                    if (v.Credit < o.GetLoanDeposit())
                    {
                        MessageBox.Show("Visitor does not have enough credit.");
                    }
                    else
                    {
                        v.Credit -= o.GetLoanDeposit();
                        o.OrderDate = DateTime.Now;
                        o.VisitorNr = v.IdNr;

                        if (data.CreateNewOrder(o) == 1 && data.AddLoanOrderLine(o) != -1 && data.UpdateSelectedVisitor(v) != -1)
                        {
                            //labelBorrowInfo.Text = o.GetDepositReceipt();
                            labelMessageB.Text = "Loan successful!";
                            labelVisitorB.Text = v.ToString();
                        }
                    }
                }
                else
                {
                    if (v.Credit + o.GetLoanDeposit() < o.GetLoanFee())
                    {
                        MessageBox.Show("Visitor does not have enough credit.");
                    }
                    else
                    {
                        // return deposit take fees
                        v.Credit = v.Credit + o.GetLoanDeposit() - o.GetLoanFee();
                        o.OrderDate = DateTime.Now; // the date of the "return order" 

                        if (data.ProcessLoanReturn(o, v.IdNr.ToString()) != -1 && data.UpdateSelectedVisitor(v) != -1)
                        {

                        }
                    }
                }
            }
            o = new LoanOrder(selectedShop);
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (loanInfoLbx.SelectedIndex != -1)
            {
                o.SetQuantity((Article)loanInfoLbx.SelectedItem, 0);
                loanInfoLbx.Items.Remove(loanInfoLbx.SelectedItem);
            }
        }
        private void returnDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (returnDatePicker.Value > maximumReturnDate)
            {
                labelMessageB.Text = "Return date too far away";
                labelMessageB.ForeColor = Color.DarkRed;
            }
            else
            {
                labelMessageB.Text = "You will return this by " + returnDatePicker.Value;
                labelMessageB.ForeColor = Color.DimGray;
            }
        }


        ///////////////////////////////////////
        // LOGS PANEL
        ///////////////////////////////////////
        private void DisplayListOfArticles(List<LoanArticle> foundArticles)
        {
            logsInfoLbx.Items.Clear();
            if (foundArticles.Count != 0)
            {
                foreach (LoanArticle a in foundArticles)
                {
                    logsInfoLbx.Items.Add(a);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No articles found");
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();

            if(itemNameRbtn.Checked)
            {
                List<LoanArticle> foundArticles = data.GetLoanArticlesContaining(selectedShop.ShopNr, textBoxSearch.Text);
                DisplayListOfArticles(foundArticles);
            }
            else if (itemNrRbtn.Checked)
            {
                LoanArticle foundArticle = data.FindLoanArticleByNr(Convert.ToInt32(textBoxSearch.Text), selectedShop.ShopNr);
                if (foundArticle != null)
                {
                    logsInfoLbx.Items.Add(foundArticle);
                }
                else
                {
                    logsInfoLbx.Items.Add("No articles found");
                }
            }
            else if (personNameRbtn.Checked)
            {
                List<Visitor> visitorsWithName = data.FindVisitorByName(textBoxSearch.Text);
                List<LoanOrder> foundOrders = data.GetLoanArticleWithVisitorNrs(selectedShop, visitorsWithName);
                logsInfoLbx.Items.Clear();
                if (foundOrders.Count != 0)
                {
                    foreach (LoanOrder o in foundOrders)
                    {
                        Visitor loaner = data.FindVisitorByNr(o.VisitorNr);
                        logsInfoLbx.Items.Add("Order nr." + o.OrderNr + " on " + o.OrderDate
                            + "; Loaned to: " + loaner.FirstName + ", " + loaner.LastName.ToUpper()
                            + "; Phone nr. " + loaner.Phone);
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No order found");
                }
            }
            else if (personNrRbtn.Checked)
            {
                List<Visitor> foundVisitor = new List<Visitor>();
                foundVisitor.Add(data.FindVisitorByNr(Convert.ToInt32(textBoxSearch.Text)));
                List<LoanOrder> foundOrders = data.GetLoanArticleWithVisitorNrs(selectedShop, foundVisitor);
                logsInfoLbx.Items.Clear();
                if (foundOrders.Count != 0)
                {
                    foreach (LoanOrder o in foundOrders)
                    {
                        Visitor loaner = data.FindVisitorByNr(o.VisitorNr);
                        logsInfoLbx.Items.Add("Order nr." + o.OrderNr + " on " + o.OrderDate
                            + "; Loaned to: " + loaner.FirstName + ", " + loaner.LastName.ToUpper()
                            + "; Phone nr. " + loaner.Phone);
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No order found");
                }
            }
        }
        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            List<LoanArticle> foundArticles = data.GetAllLoanArticles(selectedShop.ShopNr);
            DisplayListOfArticles(foundArticles);
        }

        private void currentBtn_Click(object sender, EventArgs e)
        {
            List<LoanArticle> foundArticles = data.GetLoaningArticles(selectedShop.ShopNr);
            DisplayListOfArticles(foundArticles);
        }

        private void viewLogsBtn_Click(object sender, EventArgs e)
        {
            LoanArticle selectedItem = (LoanArticle)logsInfoLbx.SelectedItem;
            if (selectedItem != null)
            {
                List<LoanOrder> foundOrders = data.GetLoanArticleOrderHistory(selectedShop, selectedItem);
                logsInfoLbx.Items.Clear();
                if (foundOrders.Count != 0)
                {
                    foreach (LoanOrder o in foundOrders)
                    {
                        Visitor loaner = data.FindVisitorByNr(o.VisitorNr);
                        logsInfoLbx.Items.Add("Order nr." + o.OrderNr + " on " + o.OrderDate
                            + "; Loaned to: " + loaner.FirstName + ", " + loaner.LastName.ToUpper()
                            + "; Phone nr. " + loaner.Phone);
                    }
                }
                else
                {
                    logsInfoLbx.Items.Add("No order found");
                }
            }
            
        }
    }
}
