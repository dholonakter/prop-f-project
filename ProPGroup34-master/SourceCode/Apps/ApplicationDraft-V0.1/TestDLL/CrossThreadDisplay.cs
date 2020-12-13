using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhDLL
{
    public class CrossThreadDisplay : IDisposable
    {
        Form myForm;
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public CrossThreadDisplay(Form f)
        {
            myForm = f;
        }

        // Delegates for cross-thread processing
        delegate void LabelDelegate(string text, Label lb);
        delegate void ListboxDelegate(Object o, ListBox lb);
        delegate void VoidListboxDelegate(ListBox lb);

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
                    lb.Items.Add("#" + a.ArticleNr + " - " + a.ArticleName + " at " + a.ShopName);
                }
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
