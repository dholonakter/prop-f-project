using BuyTicketApp;
using Phidget22;
using Phidget22.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntranceApp
{
    public partial class MainForm : Form,ILogger
    {
        #region Public Constants
        public const string lblDefaultText = "...........................";
        #endregion

        #region Private Fields
        private RFID myRFIDReader;
        private DatabaseHelper databaseHelper;
        private Visitor foundVisitor;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            try
            {
                databaseHelper = new DatabaseHelper(this);
                myRFIDReader = new RFID();

            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "startup: so far so good.");
            }
        }
        #endregion

        #region  private Method
        /// <summary>
        /// the information of visitor can not be empty in textbox
        /// </summary>
        /// <returns></returns>
        private bool InputValidation()
        {
            return !String.IsNullOrEmpty(tbName.Text) &&
                   !String.IsNullOrEmpty(tbEmailAddress.Text) &&
                   !String.IsNullOrEmpty(tbPhoneNumber.Text) &&
                   !String.IsNullOrEmpty(tbrfid.Text) &&
                   !String.IsNullOrEmpty(cbxSelectedAmount.Text);
        }
        private void ResetBuyTicketsGroupControls()
        {
            tbName.Text = string.Empty;
            tbEmailAddress.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbrfid.Text = string.Empty;
            lblCardLinkedStatus.Text = lblDefaultText;
            cbxSelectedAmount.Text = string.Empty;
    
        }

        private void SetTextBoxTextWhenVisitorIsFound(Visitor visitor)
        {
            if (visitor != null)
            {
                tbName.Text = visitor.FullName;
                tbEmailAddress.Text = visitor.EmailAddress;
                tbPhoneNumber.Text = visitor.PhoneNumber.ToString();
                tbrfid.Text = visitor.RFID;
                cbxSelectedAmount.Text = visitor.Balance.ToString();
                if (visitor.IsCardLinked)
                {
                    ShowSuccessMessage("Card is Linked");
                    
                }
                else
                {
                    ShowErrorMessage("Card is not linked");
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            lblCardLinkedStatus.Text = message;
            lblCardLinkedStatus.BackColor = Color.Red;
        }
        private void ShowSuccessMessage(string message)
        {
            lblCardLinkedStatus.BackColor = Color.Green;
            lblCardLinkedStatus.Text = message;
        }
        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            tbrfid.Text = e.Tag;
            foundVisitor = databaseHelper.FindVisitor(e.Tag);
            SetTextBoxTextWhenVisitorIsFound(foundVisitor);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
                myRFIDReader.Open();
                if (myRFIDReader.Attached)
                {
                    LogMessage(ErrorType.RFID, "Open");

                }
                else if (myRFIDReader.Attached==false)
                {
                    LogMessage(ErrorType.RFID, "Not attached");
                }
            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "Something went wrong");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myRFIDReader.Tag -= new RFIDTagEventHandler(ProcessThisTag);
            myRFIDReader.Close();
            LogMessage(ErrorType.RFID, "Closed");

        }



        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnLinkCard_Click(object sender, EventArgs e)
        {
            string name, email, rfidCode;
            int phone;
            double balance;

            if (InputValidation())
            {
                name = tbName.Text;
                email = tbEmailAddress.Text;
                phone = int.Parse(tbPhoneNumber.Text);
                rfidCode = tbrfid.Text;
                balance = Convert.ToDouble(cbxSelectedAmount.Text);
                if (databaseHelper.LinKCard(name, email, phone, balance, rfidCode))
                {
                    
                    ShowSuccessMessage("Linked Successfully");

                }
                else
                {
                    ShowErrorMessage("Unable to link card");

                }
            }
            else
            {
                MessageBox.Show("Not All Fields are complete!!!");
            }
    }

        private void btnUnLinkCard_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
           
                if (databaseHelper.UnlinkCard(foundVisitor))
                {
                    lblCardLinkedStatus.Text = "UnLinked Successfully";
                    ShowSuccessMessage("UnLinked Successfully");
                }
                else
                {
                    lblCardLinkedStatus.Text = "Card is not Linked yet";
                    ShowErrorMessage("Unable to unlink card");
                }
            }
            else
            {
                MessageBox.Show("Not All Fields are complete!!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetBuyTicketsGroupControls();
           
        }
        #endregion

        #region ILogger Implementation
        public void LogMessage(ErrorType errorType, string message)
        {
            lbxLogMessage.Items.Add(errorType + ":" + message);
        }
        #endregion

    }
}
