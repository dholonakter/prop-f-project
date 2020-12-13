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

namespace CampEntranceApp
{
    public partial class CampEntrance : Form, ILogger
    {

        #region Private Fields
        private DatabaseHelper dh;
        private RFID myRFIDReader;
        #region Public Constants
        public const string lblDefaultText = "...........................";
        #endregion

        #endregion

        #region Constructor
        public CampEntrance()
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

        #region Private Event Handlers Methods
        private void ShowErrorMessage(string message)
        {
            lblStatus.Text = "not paid yet";
            lblStatus.BackColor = Color.Red;
        }
        private void ShowSuccessMessage(string message)
        {
            lblStatus.BackColor = Color.Green;
            lblStatus.Text = message;
        }
        private void ResetControlsBackColor()
        {
            lblStatus.BackColor = SystemColors.Control;
            btnCheckIn.BackColor = SystemColors.Control;
            btnCheckOut.BackColor = SystemColors.Control;
        }
        private void SetLabelsTextOfCheckInCheckOutGroupBox(Participant participant)
        {
            if (participant != null)
            {
                lblFirstName.Text = participant.FirstName;
                lbLastName.Text = participant.LastName;
                lblRFIDCode.Text = participant.RFID;
                if (participant.IsCheckedIn)
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
        private void CheckInOrCheckout(string rfid)
        {
            if (!String.IsNullOrEmpty(rfid))
            {
                Participant checkinvisitor = dh.GetParticipant(rfid);
                if (checkinvisitor != null)
                {
                    if (dh.CheckInOrCheckout(checkinvisitor))//rfid.Code, out checkedInVisitor))
                    {
                        SetLabelsTextOfCheckInCheckOutGroupBox(checkinvisitor);
                        timerResetControls.Start();
                    }
                    else
                    {
                        ResetControlsBackColor();
                        ShowErrorMessage("Not paid yet");
                        timerResetControls.Start();
                    }
                }
                else
                {
                    ResetControlsBackColor();
                    ShowErrorMessage("Cannot find participant");
                    timerResetControls.Start();
                }
            }
        }


        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            CheckInOrCheckout(e.Tag);
        }



        private void Form1_Load(object sender, EventArgs e)
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myRFIDReader.Tag -= new RFIDTagEventHandler(ProcessThisTag);
            myRFIDReader.Close();
            LogMessage(ErrorType.RFID, "Closed");

        }

        private void ResetControls()
        {
            lblFirstName.Text = lblDefaultText;
            lbLastName.Text = lblDefaultText;
            lblRFIDCode.Text = lblDefaultText;
            lblStatus.Text = lblDefaultText;
            lblStatus.BackColor = SystemColors.Control;
            btnCheckIn.BackColor = SystemColors.Control;
            btnCheckOut.BackColor = SystemColors.Control;
        }

        private void timerResetControls_Tick(object sender, EventArgs e)
        {
            timerResetControls.Stop();
            ResetControls();
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
    }
}