using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhDLL
{
    public class CrossThreadDisplay : IDisposable
    {
        // class to display data on GUI when called from a thread other than GUI's thread

        ///////////////////////////////////////
        // FIELDS AND PROPERTIES
        ///////////////////////////////////////
        Form myForm;

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        ///////////////////////////////////////
        // DELEGATES
        ///////////////////////////////////////
        // Delegates for cross-thread processing
        delegate void TextboxDelegate(string text, TextBox tb);
        delegate void LabelDelegate(string text, Label lb);
        delegate void ListboxDelegate(Object o, ListBox lb);
        delegate void VoidListboxDelegate(ListBox lb);

        ///////////////////////////////////////
        // CONSTRUCTORS
        ///////////////////////////////////////
        public CrossThreadDisplay(Form f)
        {
            myForm = f;
        }
        
        ///////////////////////////////////////
        // METHODS
        ///////////////////////////////////////
        
        // Set text to textbox
        public void SetTextBox(string text, TextBox tb)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (tb.InvokeRequired)
            {
                TextboxDelegate d = new TextboxDelegate(SetTextBox);
                myForm.Invoke(d, new object[] { text, tb });
            }
            else
            {
                tb.Text = text;
            }
        }
        // Clearing the given listbox
        public void ClearListbox(ListBox lb)
        {
            if (lb.InvokeRequired)
            {
                VoidListboxDelegate d = new VoidListboxDelegate(ClearListbox);
                myForm.Invoke(d, new object[] { lb });
            }
            else
            {
                lb.Items.Clear();
            }
        }

        // Set text to label
        public void SetText(string text, Label lb)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (lb.InvokeRequired)
            {
                LabelDelegate d = new LabelDelegate(SetText);
                myForm.Invoke(d, new object[] { text, lb });
            }
            else
            {
                lb.Text = text;
                if (text == "OK")
                {
                    lb.ForeColor = Color.DarkGreen;
                }
                else if (text == "NOK")
                {
                    lb.ForeColor = Color.DarkRed;
                }
            }
        }

        // Display an article in a given listbox
        public void DisplayLoanArticle(Object o, ListBox lb)
        {
            List<LoanArticle> list = (List<LoanArticle>)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayLoanArticle);
                myForm.Invoke(d, new object[] { list, lb });
            }
            else
            {
                lb.Items.Clear();
                foreach (LoanArticle a in list)
                {
                    lb.Items.Add((a) + " at loan stand " + a.ShopName);
                }
            }
        }

        // Add loan article to a listbox
        public void AddLoanArticleToLB(Object o, ListBox lb)
        {
            LoanArticle a = (LoanArticle)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayLoanArticle);
                myForm.Invoke(d, new object[] { a, lb });
            }
            else
            {
                lb.Items.Add(a);
            }
        }

        // Display reservation
        public void DisplayReservation(Object o, ListBox lb)
        {
            Reservation r = (Reservation)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayArticle);
                myForm.Invoke(d, new object[] { r, lb });
            }
            else
            {
                lb.Items.Clear();
                lb.Items.Add("RESERVATION NR. " + r.ReservNr);
                lb.Items.Add("Reserved on: " + r.ReservDate);
                lb.Items.Add("Reserved spot: " + r.Spot.SpotName);
                lb.Items.Add("Period: " + r.StartDate + " to " + r.EndDate);
                lb.Items.Add("CAMPER: " + r.Reserver.FirstName + ", " + r.Reserver.LastName.ToUpper());
                lb.Items.Add("Phone: " + r.Reserver.Phone);
            }
        }

        // Display an article in a given listbox
        public void DisplayArticle(Object o, ListBox lb)
        {
            List<Article> list = (List<Article>)o;

            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayArticle);
                myForm.Invoke(d, new object[] { list, lb });
            }
            else
            {
                lb.Items.Clear();
                foreach (Article a in list)
                {
                    lb.Items.Add(a);
                }
            }
        }

        // Change color of label
        public void ChangeLabelColor(Label lb, Color c)
        {
            if (lb.InvokeRequired)
            {
                ListboxDelegate d = new ListboxDelegate(DisplayArticle);
                myForm.Invoke(d, new object[] { lb, c });
            }
            else
            {
                lb.ForeColor = c;
            }
        }

        ///////////////////////////////////////
        // IMPLEMENTING DISPOSE
        ///////////////////////////////////////
        public void Dispose()
        {
            Dispose(true);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }

        ~CrossThreadDisplay()
        {
            Dispose(false);
        }
    }
}
