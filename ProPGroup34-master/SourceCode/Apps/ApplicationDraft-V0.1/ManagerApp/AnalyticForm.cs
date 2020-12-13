using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ThanhDLL;

namespace ManagerApp
{
    public partial class AnalyticForm : Form,ILogger
    {
        DataHelper dh;

        public AnalyticForm()
        {
            InitializeComponent();
        }

        private void AnalyticForm_Load(object sender, EventArgs e)
        {
            dh = new DataHelper(this);
            fillChart();
            //FillComboBoxShop();
            //comboBoxShop.SelectedIndex = -1;
            timerUpdate.Start();
        }

        /* SHELVED IDEA
        private void FillComboBoxShop()
        {
            DataTable dt = dh.DataTableFromSQL("SELECT ShopNr, ShopName FROM SHOP");

            comboBoxShop.ValueMember = "ShopNr";
            comboBoxShop.DisplayMember = "ShopName";
            comboBoxShop.DataSource = dt;
        }*/

        private void fillChart()
        {
            // income per day
            chartIncomePerDay.Titles.Clear();
            chartIncomePerDay.DataSource = dh.GetDataset("select date_format(date(all_order.OrderDate), '%d/%m') 'OrderDate', sum(Subtotal) 'Revenue' from all_order group by date(all_order.OrderDate)");
            //set the member of the chart data source used to data bind to the X-values of the series  
            chartIncomePerDay.Series["Income"].XValueMember = "OrderDate";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chartIncomePerDay.Series["Income"].YValueMembers = "Revenue";
            chartIncomePerDay.Titles.Add("Total earned per day");

            // income by type
            chartIncomePerType.Titles.Clear();
            DataSet ds = dh.GetDataset("select (select sum(Subtotal) from all_order where IsLoanable = 1) 'Loan', (select sum(Subtotal) from all_order where IsLoanable = 0) 'Store' from dual ");
            chartIncomePerType.Series["Income"].Points.AddXY("Loan", ds.Tables[0].Rows[0]["Loan"].ToString());
            chartIncomePerType.Series["Income"].Points.AddXY("Store", ds.Tables[0].Rows[0]["Store"].ToString());
            chartIncomePerType.Titles.Add("Total earned by shop type");

            // nr of tickets per day
            chartTicketsPerDay.Titles.Clear();
            chartTicketsPerDay.DataSource = dh.GetDataset("select date_format(date(ticket.TicketDate), '%d/%m') 'TicketDate', COUNT(*) 'NumberSold' from ticket group by date(ticket.TicketDate)");
            //set the member of the chart data source used to data bind to the X-values of the series  
            chartTicketsPerDay.Series["Income"].XValueMember = "TicketDate";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chartTicketsPerDay.Series["Income"].YValueMembers = "NumberSold";
            chartTicketsPerDay.Titles.Add("Total of tickets sold per day");

        }
        private void FillIncomePerHour()
        {
            chartIncomePerHour.Titles.Clear(); // clearing titles
            chartIncomePerHour.DataSource = dh.GetDataset("select hour(all_order.OrderDate) 'Hour', sum(Subtotal) 'Revenue' " +
                "from all_order where date(all_order.OrderDate) = '" + (dateTimePicker1.Value.ToString("yyyy-MM-dd")) + "' " +
            "group by hour(all_order.OrderDate) ");

            if (((DataSet)chartIncomePerHour.DataSource).Tables[0].Rows.Count != 0)
            {
                chartIncomePerHour.Series["Income"].XValueMember = "Revenue";
                chartIncomePerHour.Series["Income"].YValueMembers = "Hour";
                chartIncomePerHour.Titles.Add("Total earned per hour of " + (dateTimePicker1.Value.ToString("dd/MM")));
            }
            else
            {
                chartIncomePerHour.Titles.Add("No data");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillIncomePerHour();
        }

        /* SHELVED IDEA 
        private void FillIncomeShop()
        {
            if (comboBoxShop.SelectedIndex != -1)
            {
                chartIncomeShop.Titles.Clear();
                chartIncomeShop.DataSource = dh.GetDataset("select DATE_FORMAT(all_order.OrderDate,'%d/%m') 'OrderDate', sum(Subtotal) 'Revenue' from all_order " +
                    "where all_order.ShopNr = " + comboBoxShop.SelectedValue.ToString() + " group by OrderDate ");
                if (((DataSet)chartIncomeShop.DataSource).Tables[0].Rows.Count != 0)
                {
                    chartIncomeShop.Series["Income"].XValueMember = "OrderDate";
                    chartIncomeShop.Series["Income"].YValueMembers = "Revenue";
                    if (chartIncomeShop.Titles.Count == 0)
                    {
                        chartIncomeShop.Titles.Add("Total earned per day of " + comboBoxShop.SelectedText);
                    }
                }
                else
                {
                    chartIncomeShop.Titles.Add("No data");
                }
            }
        }*/

        private void ClearChart(Chart c)
        {
            foreach (var series in c.Series)
            {
                series.Points.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearChart(chartIncomePerHour);
            ClearChart(chartIncomePerDay);
            ClearChart(chartIncomePerType);
            ClearChart(chartTicketsPerDay);

            //FillComboBoxShop();
            FillIncomePerHour();
            //FillIncomeShop();
            fillChart();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            ClearChart(chartIncomePerHour);
            ClearChart(chartIncomePerDay);
            ClearChart(chartIncomePerType);
            ClearChart(chartTicketsPerDay);

            //FillComboBoxShop();
            FillIncomePerHour();
            //FillIncomeShop();
            fillChart();
        }

        private void AnalyticForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Dispose();
            home.Show();
        }

        public void LogMessage(string message)
        {

        }
    }
}
