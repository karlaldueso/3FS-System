using _3FS_System.Helpers;
using _3FS_System.Models;
using _3FS_System.Repositories;
using _3FS_System.DataSet;
using Microsoft.Reporting.WinForms;
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
                case 0: //Sales per Item (Amount)
                    reportChart.DataSource = reportrepository.GetReport_SalesPerItem(startdateTime.Value.Date, enddateTime.Value.Date);
                    if (reportChart.Series.IndexOf("Sales") != -1)
                    {
                        if (reportChart.Titles.IndexOf("GraphicReport") != -1)
                        {
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Sales";
                            reportChart.Titles["GraphicReport"].Text = "Sales per Item (Amount)";
                        }
                        else
                        {
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Sales";
                            reportChart.Titles.Add("GraphicReport");
                            reportChart.Titles["GraphicReport"].Text = "Sales per Item (Amount)";
                        }

                    }
                    else
                    {
                        if (reportChart.Titles.IndexOf("GraphicReport") != -1)
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Sales";
                            reportChart.Titles["GraphicReport"].Text = "Sales per Item (Amount)";
                        }
                        else
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Sales";
                            reportChart.Titles.Add("GraphicReport");
                            reportChart.Titles["GraphicReport"].Text = "Sales per Item (Amount)";
                        }
                    }
                    reportChart.Series["Sales"].IsValueShownAsLabel = true;
                    reportChart.Series["Sales"].LabelFormat = default;
                    reportChart.Series["Sales"].LabelFormat = "P{0:N2}";
                    reportChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    reportChart.ChartAreas["ChartArea1"].RecalculateAxesScale();

                    dataGridView1.DataSource = reportrepository.GetReport_SalesPerItem(startdateTime.Value.Date, enddateTime.Value.Date);
                    ReportDataSource rds0 = new ReportDataSource("SalesPerItem", dataGridView1.DataSource);
                    Microsoft.Reporting.WinForms.ReportParameter[] para0 = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("rBeginDate", startdateTime.Value.Date.ToString("yyyy/MM/dd")),
                        new Microsoft.Reporting.WinForms.ReportParameter("rEndDate", enddateTime.Value.Date.ToString("yyyy/MM/dd")),
                    };
                    reportViewer1.LocalReport.ReportEmbeddedResource = "_3FS_System.Reports.SalesPerItem.rdlc";
                    reportViewer1.LocalReport.SetParameters(para0);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds0);
                    reportViewer1.RefreshReport();
                    break;
                case 1: //Sales per Item (Qty)
                    reportChart.DataSource = reportrepository.GetReport_SalesPerItem(startdateTime.Value.Date, enddateTime.Value.Date);
                    if (reportChart.Series.IndexOf("Sales") != -1)
                    {
                        if (reportChart.Titles.IndexOf("GraphicReport") != -1)
                        {
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles["GraphicReport"].Text = "Quantity Sold per Item";
                        }
                        else
                        {
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles.Add("GraphicReport");
                            reportChart.Titles["GraphicReport"].Text = "Quantity Sold per Item";
                        }

                    }
                    else
                    {
                        if (reportChart.Titles.IndexOf("Sales per Item") != -1)
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles["GraphicReport"].Text = "Quantity Sold per Item";
                        }
                        else
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "Item";
                            reportChart.Series["Sales"].YValueMembers = "Quantity";
                            reportChart.Titles.Add("GraphicReport");
                            reportChart.Titles["GraphicReport"].Text = "Quantity Sold per Item";
                        }
                    }
                    reportChart.Series["Sales"].IsValueShownAsLabel = true;
                    reportChart.Series["Sales"].LabelFormat = default;
                    reportChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    reportChart.ChartAreas["ChartArea1"].RecalculateAxesScale();

                    dataGridView1.DataSource = reportrepository.GetReport_SalesPerItem(startdateTime.Value.Date, enddateTime.Value.Date);
                    ReportDataSource rds1 = new ReportDataSource("SalesPerItem", dataGridView1.DataSource);
                    Microsoft.Reporting.WinForms.ReportParameter[] para1 = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("rBeginDate", startdateTime.Value.Date.ToString("yyyy/MM/dd")),
                        new Microsoft.Reporting.WinForms.ReportParameter("rEndDate", enddateTime.Value.Date.ToString("yyyy/MM/dd")),
                    };
                    reportViewer1.LocalReport.ReportEmbeddedResource = "_3FS_System.Reports.SalesPerItem.rdlc";
                    reportViewer1.LocalReport.SetParameters(para1);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds1);
                    reportViewer1.RefreshReport();
                    break;
                case 2: //Sales per Receipt (Amount)
                    SalesRepository salesRepository = new SalesRepository();
                    reportChart.DataSource = salesRepository.GetSale_ByDateRange(startdateTime.Value.Date, enddateTime.Value.Date);
                    if (reportChart.Series.IndexOf("Sales") != -1)
                    {
                        if (reportChart.Titles.IndexOf("GraphicReport") != -1)
                        {
                            reportChart.Series["Sales"].XValueMember = "ReceiptNum";
                            reportChart.Series["Sales"].YValueMembers = "AmountPaid";
                            reportChart.Titles["GraphicReport"].Text = "Sales per Receipt";
                        }
                        else
                        {
                            reportChart.Series["Sales"].XValueMember = "ReceiptNum";
                            reportChart.Series["Sales"].YValueMembers = "AmountPaid";
                            reportChart.Titles.Add("GraphicReport");
                            reportChart.Titles["GraphicReport"].Text = "Sales per Receipt";
                        }

                    }
                    else
                    {
                        if (reportChart.Titles.IndexOf("GraphicReport") != -1)
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "ReceiptNum";
                            reportChart.Series["Sales"].YValueMembers = "AmountPaid";
                            reportChart.Titles["GraphicReport"].Text = "Sales per Receipt";
                        }
                        else
                        {
                            reportChart.Series.Add("Sales");
                            reportChart.Series["Sales"].XValueMember = "ReceiptNum";
                            reportChart.Series["Sales"].YValueMembers = "AmountPaid";
                            reportChart.Titles.Add("GraphicReport");
                            reportChart.Titles["GraphicReport"].Text = "Sales per Receipt";
                        }
                    }
                    reportChart.Series["Sales"].IsValueShownAsLabel = true;
                    reportChart.Series["Sales"].LabelFormat = default;
                    reportChart.Series["Sales"].LabelFormat = "P{0:N2}";
                    reportChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    reportChart.ChartAreas["ChartArea1"].RecalculateAxesScale();

                    dataGridView1.DataSource = salesRepository.GetSale_ByDateRange(startdateTime.Value.Date, enddateTime.Value.Date);
                    ReportDataSource rds2 = new ReportDataSource("Sales", dataGridView1.DataSource);
                    Microsoft.Reporting.WinForms.ReportParameter[] para2 = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("rBeginDate", startdateTime.Value.Date.ToString("yyyy/MM/dd")),
                        new Microsoft.Reporting.WinForms.ReportParameter("rEndDate", enddateTime.Value.Date.ToString("yyyy/MM/dd")),
                    };
                    reportViewer1.LocalReport.ReportEmbeddedResource = "_3FS_System.Reports.SalesPerReceipt.rdlc";
                    reportViewer1.LocalReport.SetParameters(para2);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds2);
                    reportViewer1.RefreshReport();
                    break;
                case 3:                 
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            } 
        }
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //SalesRepository salesRepository = new SalesRepository();
            ////PerReceipt s = new PerReceipt();
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(salesRepository.GetSale_ByDateRange(startdateTime.Value.Date, enddateTime.Value.Date));
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
