using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhDLL;

namespace ManagerApp
{
    public partial class TransactionForm : Form,ILogger
    {
        DataHelper dh;
        BindingSource logTable;


        public TransactionForm()
        {
            InitializeComponent();
            dh = new DataHelper(this);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string path = "";
            listBoxDetails.Items.Clear();

            using (FileDialog fd = new OpenFileDialog())
            {
                fd.ShowDialog();
                path = fd.FileName;
            }

            if (path != "")
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);

                    while (!sr.EndOfStream)
                    {
                        listBoxDetails.Items.Add(sr.ReadLine());
                    }

                    if (sr != null)
                    {
                        sr.Close();
                    }
                }

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);

                    string startPeriod;
                    string endPeriod;
                    string receiverNr;

                    receiverNr = Convert.ToString(sr.ReadLine());
                    startPeriod = Convert.ToString(sr.ReadLine());
                    endPeriod = Convert.ToString(sr.ReadLine());

                    int max = Convert.ToInt32(sr.ReadLine());

                    for (int i = 0; i < max; i++)
                    {
                        string temp = sr.ReadLine();

                        string[] parsed = temp.Split(' ');

                        dh.CreateNewLog(new Log(startPeriod, endPeriod, parsed[0].Trim(), receiverNr, Convert.ToDouble(parsed[1].Trim())));
                    }

                    if (sr != null)
                    {
                        sr.Close();
                    }

                    if (MessageBox.Show("Log added to database") == DialogResult.OK)
                    {
                        DisplayLog();
                    }
                }
                
            }
        }
        private void DisplayLog()
        {
            // Display data onto gridview
            logTable = new BindingSource();
            try
            {
                logTable.DataSource = dh.DataTableFromSQL("SELECT * FROM ATM_LOG");
                dataGridView1.DataSource = logTable;
                dataGridView1.Refresh();
            }
            catch(Exception)
            {
                LogMessage("Something went wrong while displaying");
            }
        }
        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Dispose();
            home.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DisplayLog();
        }

        public void LogMessage(string message)
        {
            lbxTransctionMessage.Items.Add(message);
        }
    }
}
