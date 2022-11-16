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

            //reportChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //reportChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void chart_report(object sender, EventArgs e)
        {
            ReportRepository reportrepository = new ReportRepository();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    reportChart.DataSource = reportrepository.GetReport_SalesPerItem(startdateTime.Value.Date, enddateTime.Value.Date);
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
                    reportChart.Series["Sales"].IsValueShownAsLabel = true;
                    reportChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    reportChart.ChartAreas["ChartArea1"].RecalculateAxesScale();
                    break;
                case 1:
                    reportChart.DataSource = reportrepository.GetReport_SalesPerItem(startdateTime.Value.Date, enddateTime.Value.Date);
                    if (reportChart.Series.IndexOf("Sales") != -1)
                    {
                        if (reportChart.Titles.IndexOf("Sales per Item") != -1)
                        {
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles["Sales per Item"].Text = "Quantity Sold per Item";
                        }
                        else
                        {
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles.Add("Sales per Item");
                            reportChart.Titles["Sales per Item"].Text = "Quantity Sold per Item";
                        }

                    }
                    else
                    {
                        if (reportChart.Titles.IndexOf("Sales per Item") != -1)
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles["Sales per Item"].Text = "Quantity Sold per Item";
                        }
                        else
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles.Add("Sales per Item");
                            reportChart.Titles["Sales per Item"].Text = "Quantity Sold per Item";
                        }
                    }
                    reportChart.Series["Sales"].IsValueShownAsLabel = true;
                    reportChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    reportChart.ChartAreas["ChartArea1"].RecalculateAxesScale();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }



        }
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
