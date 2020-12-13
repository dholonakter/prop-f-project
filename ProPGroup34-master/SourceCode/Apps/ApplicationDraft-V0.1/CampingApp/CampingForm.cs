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
using Phidget22;
using Phidget22.Events;
using System.Threading;

namespace CampingApp
{
    public partial class CampingForm : Form,ILogger
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

        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);

        public CampingForm()
        {
            InitializeComponent();
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
            searchPanel.Visible = false;
            checkoutPanel.Visible = false;
            checkinPanel.Visible = true;
            dh = new DataHelper(this);


            // clear gui
            lbCheckIn.Text = "";
            labelStatusIn.Text = "STATUS";

            // Switching delegate's method
            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += CheckIn;
            r = null;
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();
            searchPanel.Visible = false;
            checkoutPanel.Visible = true;
            checkinPanel.Visible = false;
            dh = new DataHelper(this);


            // clear gui
            lbCheckOut.Text = "";
            labelStatusOut.Text = "STATUS";

            // Switching delegate's method
            myRFIDReader.Tag -= CheckIn;
            myRFIDReader.Tag += CheckOut;
            r = null;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();

            searchPanel.Visible = true;
            checkoutPanel.Visible = false;
            checkinPanel.Visible = false;
            dh = new DataHelper(this);


            // Display data onto gridview
            campTable = new BindingSource();
            try
            {
                campTable.DataSource = dh.DataTableFromSQL("SELECT * FROM reservation_info");
                dataGridViewCamp.DataSource = campTable;
            }
            catch(Exception)
            {
                LogMessage("DataTableFromSQL: Error while querying the reservation");
            }
            
            r = null;
        }

        private void CampingForm_Load(object sender, EventArgs e)
        {
            // Connecting to DB
            //show the checkin panel visible
            checkoutPanel.Visible = false;
            searchPanel.Visible = false;

            dh = new DataHelper(this);


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
                 LogMessage("Failure to connect to RFID reader");
            }
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
                display.SetText(r.ToString(), lbCheckIn);

                if (r.Paid) // if endDate is earlier than now
                {
                    if (DateTime.Compare(r.EndDate, DateTime.Now) > 0)
                    {
                        display.SetText("OK", labelStatusIn);

                        if (!visitor.IsInCamp)
                        {
                            r.NrCheckedIn += 1;
                            visitor.IsInCamp = true;
                        }
                        else
                        {
                            MessageBox.Show("Visitor is already checked in");
                        }

                        if (dh.UpdateSelectedReservation(r) != -1 && dh.UpdateSelectedVisitor(visitor) != -1)
                        {
                            display.SetText(r.ToString(), lbCheckIn); //update reservation info on lb
                            r = null;
                        }
                    }
                    else
                    {
                        display.SetText("EXPIRED", labelStatusIn);
                    }
                    
                }
                else
                {
                    display.SetText("NOT PAID", labelStatusIn);
                }
            }
            else
            {
                MessageBox.Show("No reservation found");
            }
        }

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
                        display.SetText("OK", labelStatusOut);
                        display.SetText(r.ToString(), lbCheckOut); //update reservation info on lb
                        r = null;
                    }
                    else
                    {
                        r.NrCheckedIn += 1; //revert
                        MessageBox.Show("Error while checking out");
                    }
                }
                else
                {
                    MessageBox.Show("Visitor is already checked out");
                }
            }
            else
            {
                MessageBox.Show("No reservation found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (r != null && labelStatusIn.Text == "NOT OK") // only in cases where it's unpaid and not expired
            {
                r.ChangeStatus();
                if (dh.UpdateSelectedReservation(r) != -1)
                {
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText("OK", labelStatusIn);
                        display.SetText(r.ToString(), lbCheckIn);
                        r = null;
                    }
                }
                else
                {
                    r.ChangeStatus(); // revert
                    MessageBox.Show("Error while updating status");
                }
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)campTable.DataSource))
            {
                MessageBox.Show("Data updated");
                dataGridViewCamp.Refresh();
            }
            else
            {
                MessageBox.Show("Error while updating data");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelMonitor.Text = "";
            int i;

            if (int.TryParse(textBoxResrvID.Text, out i))
            {
                r = dh.FindReservationByNr(i.ToString());
                if (r != null)
                {
                    labelMonitor.Text = r.ToString();
                }
                else
                {
                    MessageBox.Show("Reservation not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }


        public void LogMessage(string message)
        {
            if (checkinPanel.Visible)
            {
                lbxCheckInMessage.Items.Add(message);
            }
            if (searchPanel.Visible)
            {
                lbMonitorMessage.Items.Add(message);

            }
            if (checkoutPanel.Visible)
            {
                lbxCheckoutMessage.Items.Add(message);
            }
        }
    }
}
