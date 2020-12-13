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

// webcam and qr
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using System.Media;
using MySql.Data.MySqlClient;

namespace EntranceApp
{
    public partial class EntranceForm : Form,ILogger
    {
        ///////////////////////////////////////
        // DECLARATIONS
        ///////////////////////////////////////

        // Variables
        Ticket t;
        Visitor visitor;
        DataHelper dh;
        BindingSource visitorTable;
        RFID myRFIDReader;

        // Delegates for RFID
        public delegate void ProcessTag(object sender, RFIDTagEventArgs e);//where you will used this method

        //  qr
        QrCodeEncodingOptions options = new QrCodeEncodingOptions();
        WebCam wCam;

       //sound for success and error
        SoundPlayer successSound = new SoundPlayer("../../../connect.wav");
        SoundPlayer errorSound = new SoundPlayer("../../../error.wav");


        ///////////////////////////////////////
        // STARTUP STUFF
        ///////////////////////////////////////
        public void ShowDeviceAttached(object sender, AttachEventArgs e)
        {
            LogMessage("RFID Reader Attached: Serial nr." + myRFIDReader.DeviceSerialNumber);
        }

        public void ShowDeviceDetached(object sender, DetachEventArgs e)
        {
            LogMessage("RFID Reader Detached: Serial nr." + myRFIDReader.DeviceSerialNumber);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            //show the first one panel checkIn visible
            ticketPanel.Visible = false;
            checkoutPanel.Visible = false;
            searchPanel.Visible = false;

            // Connecting to DB
            dh = new DataHelper(this);

            // Connecting RFID reader
            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Attach += new AttachEventHandler(ShowDeviceAttached);
                myRFIDReader.Detach += new DetachEventHandler(ShowDeviceDetached);
                myRFIDReader.Open();
            }
            catch (PhidgetException)
            {
                LogMessage("Failure to connect to RFID reader");
            }
           
        }

        ///////////////////////////////////////
        // GUI THINGS
        ///////////////////////////////////////
        public EntranceForm()
        {
            InitializeComponent();
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
        }
        /// <summary>
        /// Information can not be empty in textbox
        /// </summary>
        /// <returns></returns>
        private bool InputValidation()
        {
            return !String.IsNullOrEmpty(tbFirstName.Text) &&
                    !String.IsNullOrEmpty(tbLastName.Text) &&
                    ! String.IsNullOrEmpty(tbEmailAddress.Text) &&
                     !String.IsNullOrEmpty(tbPhoneNumber.Text) &&
                     !String.IsNullOrEmpty(cbxSelectedAmount.Text);
        }
     

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = ticketsBtn.Height;
            sideHighlight.Top = ticketsBtn.Top;
            ticketPanel.BringToFront();
            //when the ticket button will be clicked,it will show the only related buy ticket
            //error in listbox of ticket panel and it same as another panel.
            ticketPanel.Visible = true;
            searchPanel.Visible = false;
            checkoutPanel.Visible = false;
            checkinPanel.Visible = false;
            dh = new DataHelper(this);

        }

        private void checkinBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkinBtn.Height;
            sideHighlight.Top = checkinBtn.Top;
            checkinPanel.BringToFront();
            checkinPanel.Visible = true;
            ticketPanel.Visible = false;
            searchPanel.Visible = false;
            checkoutPanel.Visible = false;
            // Connecting to DB
            dh = new DataHelper(this);
            // Switching delegate's method
            myRFIDReader.Tag -= CheckOut;
            myRFIDReader.Tag += CheckIn;
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = checkoutBtn.Height;
            sideHighlight.Top = checkoutBtn.Top;
            checkoutPanel.BringToFront();
            checkoutPanel.Visible = true;
            ticketPanel.Visible = false;
            searchPanel.Visible = false;
            checkinPanel.Visible = false;
            // Connecting to DB
            dh = new DataHelper(this);
            // Switching delegate's method
            myRFIDReader.Tag -= CheckIn;
            myRFIDReader.Tag += CheckOut;
        }

        private void monitorBtn_Click(object sender, EventArgs e)
        {
            sideHighlight.Height = monitorBtn.Height;
            sideHighlight.Top = monitorBtn.Top;
            searchPanel.BringToFront();
            searchPanel.Visible = true;
            checkoutPanel.Visible = false;
            checkinPanel.Visible = false;
            ticketPanel.Visible = false;
            // Connecting to DB
            dh = new DataHelper(this);

            // Display data onto gridview
            visitorTable = new BindingSource();
            try
            {
                visitorTable.DataSource = dh.DataTableFromSQL("SELECT * FROM VISITOR");  
                dataGridVisitor.DataSource = visitorTable;
            }
            catch(Exception)
            {
                LogMessage("DataTableFromSQL: Error while querying");
            }
    
       
        }

        ///////////////////////////////////////
        // SEARCH PANEL
        ///////////////////////////////////////
        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (dh.UpdateTable((DataTable)visitorTable.DataSource))
            {
                 LogMessage("Data updated");
                 dataGridVisitor.Refresh();
            }
            else
            {
                 LogMessage("Error while updating data");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            labelMonitor.Text = "";
            int i;
            if (int.TryParse(textBoxSearch.Text, out i))
            {
                visitor = dh.FindVisitorByNr(i);
                if (visitor != null)
                {
                    labelMonitor.Text = visitor.ToString();
                }
                else
                {
                    MessageBox.Show("Visitor not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }

        ///////////////////////////////////////
        // CHECK IN PANEL
        /////////////////////////////////////// 

        private void CheckIn(object sender, RFIDTagEventArgs e)
        {
            if (visitor != null) // if there's a visitor
            {
                if (dh.existsRFID(e.Tag) == null)
                {
                    visitor.CheckInWith(e.Tag);

                    if (dh.UpdateSelectedVisitor(visitor) != -1)
                    {
                        using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                        {
                            display.SetText(e.Tag, labelTagNr);
                            display.SetText(t.ToString(), lbCheckIn);
                            display.SetText(visitor.ToString(), labelVisitorInfo);
                            display.SetText("OK", statusIn);
                        }
                        successSound.Play();
                    }
                    else
                    {
                        visitor.CheckOut(); // undo the task
                        MessageBox.Show("Error while checking in");
                    }
                }
                else
                {
                    MessageBox.Show("RFID already used");
                }
            }
        }

        ///////////////////////////////////////
        // CHECK OUT PANEL
        /////////////////////////////////////// 
        private void CheckOut(object sender, RFIDTagEventArgs e)
        {
            CrossThreadDisplay display = new CrossThreadDisplay(this);
            Visitor v = dh.FindVisitorByTag(e.Tag);
            dh.FindUnreturnedItems(v);

            if (v.CanLeave())
            {
                if (dh.MoveToDeletedVisitor(v) != -1)
                {
                    display.SetText("OK", labelStatusOut);
                }
                else
                {
                    v.CheckInWith(visitor.RFIDNr); // undo the task
                    MessageBox.Show("Error while checking out");
                }
            }
            else
            {
                errorSound.Play();
                display.DisplayLoanArticle(v.ArticlesBorrowed, lbCheckOut);
                display.SetText(v.ToString(), labelVisitor);
                display.SetText("NOT OK", labelStatusOut);
            }
            display.Dispose();
        }

        ///////////////////////////////////////
        // THANH TEST
        /////////////////////////////////////// 

        private void StartWebcam()
        {
            wCam = new WebCam { Container = pictureBoxSource };
            wCam.OpenConnection();
            webCamTimer = new System.Windows.Forms.Timer();
            webCamTimer.Tick += webCamTimer_Tick;
            webCamTimer.Interval = 200;
            webCamTimer.Start();
            labelStatusIn.Text = "No QR";
            lbCheckIn.Text = "No ticket found";
            labelVisitorInfo.Text = "No visitor found";
            buttonStartWC.Text = "Stop webcam";
        }

        private void StopWebcam()
        {
            webCamTimer.Stop();
            webCamTimer = null;
            wCam.Dispose();
            wCam = null;
            buttonStartWC.Text = "Start webcam";
        }

        private void webCamTimer_Tick(object sender, EventArgs e)
        {
            if (wCam != null)
            {
                var bitmap = wCam.GetCurrentImage();
                if (bitmap == null)
                    return;
                var reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                CrossThreadDisplay display = new CrossThreadDisplay(this);

                if (result != null)
                {
                    // Find their ticket
                    try {
                        t = dh.GetTicket(Convert.ToInt32(result.Text));

                        if (t != null) // if ticket exists
                        {
                            visitor = dh.FindVisitorByNr(t.BuyerNr);
                            display.SetText(t.ToString(), lbCheckIn);
                            display.SetText(visitor.ToString(), labelVisitorInfo);

                            if (t.Paid)
                            {
                                display.SetText("OK", labelStatusIn);
                                t = null;
                            }
                            else
                            {
                                errorSound.Play();
                                display.SetText("UNPAID", labelStatusIn);
                            }

                            StopWebcam();
                        }
                        else
                        {
                            MessageBox.Show("Ticket not found");
                        }
                    }
                    catch (System.FormatException)
                    {
                        LogMessage("invalid ticket");
                    }
               }
            
                else
                {
                    labelStatusIn.Text = "No QR";
                }
             
            }
        }

        private void buttonStartWC_Click(object sender, EventArgs e)
        {
            if (wCam == null)
            {
                StartWebcam();
            }
            else
            {
                StopWebcam();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t != null && !t.Paid)
            {
                t.ChangeStatus();
                if (dh.UpdateSelectedTicket(t) != -1)
                {
                    using (CrossThreadDisplay display = new CrossThreadDisplay(this))
                    {
                        display.SetText(t.ToString(), lbCheckIn);
                        display.SetText("OK", labelStatusIn);
                    }
                }
                else
                {
                    t.ChangeStatus(); // revert
                    LogMessage("Error while updating status");
                }
            }
            else
            {
                MessageBox.Show("Ticket not found or already paid");
            }
        }

        public void LogMessage(string message)
        {
            if (ticketPanel.Visible)
            {
                lbxLogMessage.Items.Add(message);

            }
            if (checkinPanel.Visible)
            {
                lbxCheckInLogMessage.Items.Add(message);
            }
            if (searchPanel.Visible)
            {
                lbMonitorMessage.Items.Add(message);

            }
            if (checkoutPanel.Visible)
            {
                lbxCheckOutMessage.Items.Add(message);
            }
        }

        private void btnClearTicketLog_Click(object sender, EventArgs e)
        {
            lbxLogMessage.Items.Clear();
        }

        private void btnCheckOutClear_Click(object sender, EventArgs e)
        {
            lbxCheckOutMessage.Items.Clear();

        }

        private void btnCheckInClear_Click(object sender, EventArgs e)
        {
            lbxCheckInLogMessage.Items.Clear();

        }

        private void btnClearLogMonitor_Click(object sender, EventArgs e)
        {
            lbMonitorMessage.Items.Clear();
        }

       
    }
}
