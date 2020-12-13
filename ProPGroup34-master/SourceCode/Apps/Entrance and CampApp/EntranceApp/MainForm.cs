using System;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using System.Drawing;
using EntranceApp.Helper;
using EntranceApp.Models;

namespace EntranceApp
{
    public partial class MainForm : Form, ILogger
    {
        #region Public Constants
        public const string lblDefaultText = "...........................";
        #endregion

        #region Private Fields
        private DatabaseHelper dh;
        private RFID myRFIDReader;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            try
            {
                dh = new DatabaseHelper(this);
                myRFIDReader = new RFID();

            }
            catch (PhidgetException)
            {
                lbxLogMessage.Items.Add("startup: so far so good.");

            }
        }
        #endregion

        #region Private Methods
        private void ShowErrorMessage(string message)
        {
            lblMessage.Text = "Cannot find visitor";
            lblMessage.BackColor = Color.Red;
        }
        private void ShowSuccessMessage(string message)
        {
            lblMessage.BackColor = Color.Green;
            lblMessage.Text = message;
        }
        private void ResetControlsBackColor()
        {
            lblMessage.BackColor = SystemColors.Control;
            btnCheckIn.BackColor = SystemColors.Control;
            btnCheckOut.BackColor = SystemColors.Control;
        }
        private void SetLabelsTextOfCheckInCheckOutGroupBox(Visitor visitor)
        {
            if (visitor != null)
            {
                lblFullName.Text = visitor.FullName;
                lblEmailAddress.Text = visitor.EmailAddress;
                lblRFIDCode.Text = visitor.RFID;
                if (visitor.IsCheckedIn)
                {
                    ShowSuccessMessage("Check In Success");
                    btnCheckIn.BackColor = Color.Green;
                    btnCheckOut.BackColor = SystemColors.Control;
                }
                else
                {
                    ShowSuccessMessage("Check Out Success");
                    btnCheckOut.BackColor = Color.Green;
                    btnCheckIn.BackColor = SystemColors.Control;
                }
            }
        }
        private void CheckInorCheckout(string rfid)//Rfid rfid)
        {
            if (!String.IsNullOrEmpty(rfid))//rfid != null)
            {
                Visitor checkinvisitor;

                if (dh.MakeCheckInOrOut(rfid, out checkinvisitor))//rfid.Code, out checkedInVisitor))
                {
                    SetLabelsTextOfCheckInCheckOutGroupBox(checkinvisitor);
                    timerResetControls.Start();
                }
                else
                {
                    ResetControlsBackColor();
                    ShowErrorMessage("Cannot find vistor");
                    timerResetControls.Start();
                }
            }
        }


        #endregion

        #region Private Event Handlers Methods
        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
               CheckInorCheckout(e.Tag);
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
                myRFIDReader.Open();
                LogMessage(ErrorType.RFID, "Open");
            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "No RFID-reader opened");
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

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            lbxLogMessage.Items.Clear();
        }
        #endregion

        #region ILogger Implementation
        public void LogMessage(ErrorType errorType, string message)
        {
            lbxLogMessage.Items.Add(errorType + ":" + message);
        }
        #endregion
        private void ResetControls()
        {
            lblFullName.Text = lblDefaultText;
            lblEmailAddress.Text = lblDefaultText;
            lblRFIDCode.Text = lblDefaultText;
            lblMessage.Text = lblDefaultText;
            lblMessage.BackColor = SystemColors.Control;
            btnCheckIn.BackColor = SystemColors.Control;
            btnCheckOut.BackColor = SystemColors.Control;
        }

        private void timerResetControls_Tick(object sender, EventArgs e)
        {
            ResetControls();
            timerResetControls.Stop();

        }
    }
}
