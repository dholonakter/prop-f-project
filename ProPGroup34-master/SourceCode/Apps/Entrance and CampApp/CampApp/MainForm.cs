using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace CampApp
{
    public partial class CampRegistrationForm : Form, ILogger
    {
        # region private
        private const string DEFAULT_LABEL_TEXT = "....................................................................";
        private RFID myRFIDReader;
        private DatabaseHelper databaseHelper;
        private ParticipantManager participantManager;
        private ParticipantRole? selectedParticipantRole;

        private CampSpot selectedCampSpot;
        private double selectedAmount;
        private Participant selectedParticipant;
        #endregion

        #region Constructor
        public CampRegistrationForm()
        {
            InitializeComponent();
            try
            {
                databaseHelper = new DatabaseHelper(this);
                myRFIDReader = new RFID();
                participantManager = new ParticipantManager();
            }
            catch (PhidgetException)
            {
                LogMessage(ErrorType.RFID, "startup: so far so good.");
            }
        }
        #endregion

        #region ILogger Implementation
        public void LogMessage(ErrorType errorType, string message)
        {
            lbxLogMessage.Items.Add(errorType + ":" + message);
        }
        private void ResetReservationFormControls()
        {
            lblFulName.Text = DEFAULT_LABEL_TEXT;
            lblrfid.Text = DEFAULT_LABEL_TEXT;
            lblCurrentBalance.Text = DEFAULT_LABEL_TEXT;
        
        }

        private void SetGroupLeaderInfo(Visitor visitor)
        {      
            if (visitor != null)
            {
                lblFulName.Text = visitor.FullName;
                lblrfid.Text = visitor.RFID;
                lblCurrentBalance.Text = visitor.Balance.ToString();
            }
            else
            {
                ResetReservationFormControls();
               lblReserveMessage.Text="Invalid card";
            }
            
        }
        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            participantManager.AddParticipant(databaseHelper.FindVisitor(e.Tag));
            if (participantManager.GetAllParticipant().Count > 0)
            {
                List<Participant> allParticipant = participantManager.GetAllParticipant();
                SetGroupLeaderInfo(allParticipant[0]);

                List<Participant> members = new List<Participant>();
                foreach (Participant participant in participantManager.GetAllParticipant())
                {
                    if(participant.Role==ParticipantRole.Member)
                    {
                        members.Add(participant);
                    }
                }
                AddToMembersListBox(members.ToArray());

        //AddToMembersListBox(participantManager.GetAllParticipant().Skip(1).ToArray());
            }
        }

        private void AddToMembersListBox(Visitor[] visitors)
        {
            lbxMembers.Items.Clear();
            if(visitors!=null)
            {
                foreach (Visitor visitor in visitors)
                {
                    lbxMembers.Items.Add(visitor);
                }
                
            }
        }
        #endregion

        # region Private Method
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                myRFIDReader.Tag += new RFIDTagEventHandler(ProcessThisTag);
                myRFIDReader.Open();
                LogMessage(ErrorType.RFID, "Open");

                cbxSpotName.Items.Clear();
                cbxParticipantRole.Items.Clear();
     
                cbxSpotName.Items.AddRange(databaseHelper.GetAllCampSpot().ToArray());
                cbxParticipantRole.Items.Add(ParticipantRole.Leader);
                cbxParticipantRole.Items.Add(ParticipantRole.Member);
                //comboBox3.Items.AddRange(databaseHelper.GetAllLocationName().ToArray());


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

        private bool InputValidation()
        {
            return !String.IsNullOrEmpty(dtpStartDate.Text) &&
                   !String.IsNullOrEmpty(dtpEndDate.Text) &&
                   !String.IsNullOrEmpty(nmUpNrOfMember.Text) &&
                   !String.IsNullOrEmpty(cbxSelectedAmount.Text);
        }


        private void btnReservation_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;
            int totalMember;

            if (InputValidation())
            {
                startDate = dtpStartDate.Value; //Convert.ToDateTime(dtpStartDate.Text);
                endDate = dtpEndDate.Value; //Convert.ToDateTime(dtpEndDate.Text);
                totalMember = Convert.ToInt32(nmUpNrOfMember.Value);
                Reservation reservation = new Reservation(startDate,endDate,totalMember,selectedCampSpot.Id,selectedCampSpot.LocationId,lblrfid.Text,true);
                participantManager.UpdateAllParticipants(selectedParticipantRole.Value, selectedAmount);
                //participantManager.UpdateParticipantByRFIDCode(lblrfid.Text,selectedParticipantRole.Value,)
                if (databaseHelper.CampReservation(reservation, participantManager.GetAllParticipant()))
                {
                    AddToMembersListBox(participantManager.GetAllParticipant().ToArray());
                 
                    lblReserveMessage.Text = "Reserved Successfully";

                }
                else
                {
                    lblReserveMessage.Text = "Unable to reserve";

                }
            }
            else
            {
                MessageBox.Show("Not All Fields are complete!!!");
            }
        }

        private void cbxParticipantRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            if (combox != null)
            {
                 selectedParticipantRole = combox.SelectedItem as ParticipantRole?;
            }
        }

        private void cbxSelectedAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            if (combox != null)
            {
                selectedAmount = Convert.ToDouble(combox.SelectedItem);
            }
        }

        private void cbxSpotName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            if (combox != null)
            {
                selectedCampSpot = combox.SelectedItem as CampSpot;
                if (selectedCampSpot != null)
                {
                    CampApp.Location foundLocation = databaseHelper.GetLocation(selectedCampSpot.LocationId);

                   lblLocationName.Text = foundLocation.LocationName;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            participantManager.RemoveAllParticipant();
            lbxMembers.Items.Clear();
        }

        private void lbxMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null)
            {
                selectedParticipant = listBox.SelectedItem as Participant;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            participantManager.RemoveAllParticipant();
            AddToMembersListBox(participantManager.GetAllParticipant().ToArray());
        }

        private void btnRemoveParticipant_Click(object sender, EventArgs e)
        {
            participantManager.RemoveParticipant(selectedParticipant);
            AddToMembersListBox(participantManager.GetAllParticipant().ToArray());
        }
        #endregion

    }
}
