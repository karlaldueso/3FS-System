using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3FS_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _ = new DataAccess();
            ReportRepository reportrepository = new ReportRepository();
            reportChart.DataSource = reportrepository.GetReport_SalesPerItem(dateTimePicker1.Value.Date);

            if (reportChart.Series.IndexOf("Sales") != -1)
            {
                if (reportChart.Titles.IndexOf("Sales per Item") != -1)
                {
                    reportChart.Series["Sales"].XValueMember = "Item";
                    reportChart.Series["Sales"].YValueMembers = "Sales";
                    reportChart.Titles["Sales per Item"].Text = "Sales per Item";
                }
                else
                {
                    reportChart.Series["Sales"].XValueMember = "Item";
                    reportChart.Series["Sales"].YValueMembers = "Sales";
                    reportChart.Titles.Add("Sales per Item");
                    reportChart.Titles["Sales per Item"].Text = "Sales per Item";
                }
                    
            }
            else
            {
                if (reportChart.Titles.IndexOf("Sales per Item") != -1)
                {
                    reportChart.Series.Add("Sales");
                    reportChart.Series["Sales"].XValueMember = "Item";
                    reportChart.Series["Sales"].YValueMembers = "Sales";
                    reportChart.Titles["Sales per Item"].Text = "Sales per Item";
                }
                else
                {
                    reportChart.Series.Add("Sales");
                    reportChart.Series["Sales"].XValueMember = "Item";
                    reportChart.Series["Sales"].YValueMembers = "Sales";
                    reportChart.Titles.Add("Sales per Item");
                    reportChart.Titles["Sales per Item"].Text = "Sales per Item";
                }
            }
            



        }
    }
}
