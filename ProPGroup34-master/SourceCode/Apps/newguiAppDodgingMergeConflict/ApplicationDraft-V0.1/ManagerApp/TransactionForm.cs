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
    public partial class TransactionForm : Form
    {
        DataHelper dh;
        FileSystemWatcher watcher;

        public TransactionForm()
        {
            InitializeComponent();
            dh = new DataHelper();
            buttonChange.Text = "Intialize";
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Dispose();
            home.Show();
        }
        
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            string path = e.FullPath; // change path to process logs
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
            }
            using (CrossThreadDisplay display = new CrossThreadDisplay(this))
            {
                display.SetText("Last added logs on " + DateTime.Now, labelStatus);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string path;
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                fd.ShowDialog();
                path = fd.SelectedPath;
            }
            watcher = new FileSystemWatcher()
            {
                Path = path,
                Filter = "*.txt"
            };
            watcher.EnableRaisingEvents = true;
            watcher.Created += new FileSystemEventHandler(OnChanged);

            labelLocation.Text = path;
            buttonChange.Text = "Change";
        }
    }
}
