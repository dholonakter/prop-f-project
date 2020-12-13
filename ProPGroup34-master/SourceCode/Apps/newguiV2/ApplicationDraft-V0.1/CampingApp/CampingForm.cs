using Phidget22;
using Phidget22.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ThanhDLL;

namespace CampingApp
{
    public partial class CampingForm : Form
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Visitor visitor;
        Reservation r;
        DataHelper dh;
        BindingSource campTable;
        RFID myRFIDReader;
        bool admin;

        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);


        ///////////////////////////////////////
        // GUI THINGS
        ///////////////////////////////////////


        public CampingForm()
        {
            InitializeComponent();
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
        }

        private void ResetGUI()
        {
            labelStatusIn.Text = "";
            checkoutStatusLbl.Text = "";
            labelMessageIn.Text = "";
            checkoutMessageLbl.Text = "";
            logsInfoLbx.Items.Clear();
            checkoutInfoLbx.Items.Clear();
            checkoutInfoLbx.Items.Clear();
            buttonOverride.Text = "Override";
            admin = false;
            visitor = null;
            r = null;
        }


        private void checkinBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();

            // Switching delegate's method
            ResetGUI();
            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += CheckIn;
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();

            // Switching delegate's method
            ResetGUI();
            myRFIDReader.Tag -= CheckIn;
            myRFIDReader.Tag += CheckOut;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

            ResetGUI();
        }

        private void CampingForm_Load(object sender, EventArgs e)
        {
            // Connecting to DB
            dh = new DataHelper();
            admin = false;

            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Open();
                // Switching delegate's method
                myRFIDReader.Tag -= CheckOut;
                myRFIDReader.Tag += CheckIn;
                r = null;

            }
            catch (PhidgetException)
            {
                MessageBox.Show("Failure to connect to RFID reader");
            }

            // Switching delegate's method
            ResetGUI();
            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += CheckIn;
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 

        private void CheckIn(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            visitor = dh.FindVisitorByTag(e.Tag);
            r = dh.FindReservationByVisitor(visitor);

            if (r != null)
            {
                display.DisplayReservation(r, listBoxCheckIn);

                if (!admin)
                {
                    if (r.Paid)
                    {
                        if (DateTime.Compare(r.EndDate, DateTime.Now) > 0) // if endDate is earlier than now
                        {
                            display.SetText("OK", labelStatusIn);

                            if (!visitor.IsInCamp)
                            {
                                r.NrCheckedIn += 1;
                                visitor.IsInCamp = true;
                                if (dh.UpdateSelectedReservation(r) != -1 && dh.UpdateSelectedVisitor(visitor) != -1)
                                {
                                    display.SetText("Checked in successful!", labelMessageIn);
                                }
                            }
                            else
                            {
                                display.SetText("NOK", labelStatusIn);
                                display.SetText("Already checked in", labelMessageIn);
                            }
                        }
                        else
                        {
                            display.SetText("NOK", labelStatusIn);
                            display.SetText("The reservation's end date is past", labelMessageIn);
                        }

                    }
                    else
                    {
                        display.SetText("NOK", labelStatusIn);
                        display.SetText("The reservation is not paid", labelMessageIn);
                    }
                }
                else
                {
                    if (!visitor.IsInCamp)
                    {
                        r.NrCheckedIn += 1;
                        visitor.IsInCamp = true;
                        if (dh.UpdateSelectedReservation(r) != -1 && dh.UpdateSelectedVisitor(visitor) != -1)
                        {
                            display.SetText("OK", labelStatusIn);
                            display.SetText("Checked in successful!", labelMessageIn);
                        }
                    }
                    else
                    {
                        display.SetText("NOK", labelStatusIn);
                        display.SetText("Already checked in", labelMessageIn);
                    }
                }
            }
            else
            {
                display.SetText("No reservation found", labelMessageIn);
            }
        }


        ///////////////////////////////////////
        // CHECK OUT PANEL
        /////////////////////////////////////// 


        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            visitor = dh.FindVisitorByTag(e.Tag);
            r = dh.FindReservationByVisitor(visitor);

            if (r != null)
            {
                if (visitor.IsInCamp)
                {
                    r.NrCheckedIn -= 1;
                    visitor.IsInCamp = false;
                    if (dh.UpdateSelectedReservation(r) != -1 && dh.UpdateSelectedVisitor(visitor) != -1)
                    {
                        display.DisplayReservation(r, checkoutInfoLbx);
                        display.SetText("OK", checkoutStatusLbl);
                        display.SetText("Checked out successful", checkoutMessageLbl);
                        r = null;
                    }
                    else
                    {
                        r.NrCheckedIn += 1; //revert
                        display.SetText("NOK", checkoutStatusLbl);
                        display.SetText("Please try scanning card again", checkoutMessageLbl);
                    }
                }
                else
                {
                    display.SetText("NOK", checkoutStatusLbl);
                    display.SetText("Already checked out", checkoutMessageLbl);
                }
            }
            else
            {
                display.SetText("No reservation found", checkoutMessageLbl);
            }
        }



        ///////////////////////////////////////
        // SEARCH PANEL
        ///////////////////////////////////////



        private void DisplayReservation(Reservation r, ListBox lb)
        {
            lb.Items.Clear();
            lb.Items.Add("RESERVATION NR. " + r.ReservNr);
            lb.Items.Add("Reserved on: " + r.ReservDate);
            lb.Items.Add("Reserved spot: " + r.Spot.SpotName);
            lb.Items.Add("Period: " + r.StartDate + " to " + r.EndDate);
            lb.Items.Add("Status: " + r.NrCheckedIn + "/" + r.NrOfRegistered + " checked in");
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            if (nameRbtn.Checked)
            {
                List<Visitor> visitors = dh.FindVisitorByName(textBoxSearch.Text);
                if (visitors.Count != 0)
                {
                    foreach (Visitor v in visitors)
                    {
                        r = dh.FindReservationByVisitor(v);
                        if (r != null)
                        {
                            logsInfoLbx.Items.Add("RESERVATION NR. " + r.ReservNr +
                            "; Reserved spot: " + r.Spot.SpotName +
                            "; Reserved by: " + r.Reserver.FirstName + ", " + r.Reserver.LastName.ToUpper());
                        }
                        else
                        {
                            logsInfoLbx.Items.Add("Cannot find reservation");
                        }
                    }
                }
                viewLogsBtn.Enabled = false;
                viewLogsBtn.BackColor = Color.LightGray;
            }
            else if (reservationRbtn.Checked)
            {
                r = dh.FindReservationByNr(textBoxSearch.Text);
                logsInfoLbx.Items.Add(r);
                viewLogsBtn.Enabled = true;
                viewLogsBtn.BackColor = Color.DimGray;
            }
        }

        ///////////////////////////////////////
        // OTHER CONTROLS
        /////////////////////////////////////// 

        private void ShowUserDetails(ListBox lb)
        {
            if (visitor != null)
            {
                lb.Items.Clear();
                lb.Items.Add("VISITOR NR. " + visitor.IdNr);
                lb.Items.Add("Name: " + visitor.FirstName + ", " + visitor.LastName);
                lb.Items.Add("Phone: " + visitor.Phone);
                lb.Items.Add("Is In Camp: " + (visitor.IsInCamp ? "Yes" : "No"));
            }
        }

        private void buttonUserDetails_Click(object sender, EventArgs e)
        {
            ShowUserDetails(listBoxCheckIn);
        }

        private void checkoutDetailsBtn_Click(object sender, EventArgs e)
        {
            ShowUserDetails(checkoutInfoLbx);
        }

        private void viewLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            
            if (r != null)
            {
                List<int> campersNr = dh.FindCampersNr(r);
                List<Visitor> visitors = new List<Visitor>();
                foreach (int number in campersNr)
                {
                    visitors.Add(dh.FindVisitorByNr(number));
                }
                for (int i = 0; i < visitors.Count; i++)
                {
                    logsInfoLbx.Items.Add("Nr. " + (i + 1) + ": " + visitors[i].FirstName + ", " + visitors[i].LastName.ToUpper()
                        + "; Phone: " + visitors[i].Phone);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("Please search for a reservation first");
            }
        }

        private void checkinLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Reservation> foundReservations = dh.FindFullyPresentReservations();
            if (foundReservations != null)
            {
                foreach (Reservation r in foundReservations)
                {
                    logsInfoLbx.Items.Add(r);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No reservation found");
            }

        }

        private void checkoutLogsBtn_Click(object sender, EventArgs e)
        {
            logsInfoLbx.Items.Clear();
            List<Reservation> foundReservations = dh.FindNotFullyPresentReservations();
            if (foundReservations != null)
            {
                foreach (Reservation r in foundReservations)
                {
                    logsInfoLbx.Items.Add(r);
                }
            }
            else
            {
                logsInfoLbx.Items.Add("No reservation found");
            }
        }
        private void CheckInOverride(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in as admin");
            admin = true;
            buttonOverride.Text = "Revoke admin rights";
            ((Form)sender).Close();
        }

        private void buttonOverride_Click(object sender, EventArgs e)
        {
            if (!admin)
            {
                LoginForm testDialog = new LoginForm();
                testDialog.LoggedInHandler += CheckInOverride;
                testDialog.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Revoke admin rights on this user?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    admin = false;
                    buttonOverride.Text = "Override";
                }
            }
        }

        private void buttonConfirmPayment_Click(object sender, EventArgs e)
        {
            if (r != null)
            {
                r.ChangeStatus();
                if (dh.UpdateSelectedReservation(r) != -1)
                {
                    DisplayReservation(r, listBoxCheckIn);
                }
            }
        }
    }
}
