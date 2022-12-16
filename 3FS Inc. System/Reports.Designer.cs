namespace _3FS_System
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startdateTime = new System.Windows.Forms.DateTimePicker();
            this.enddateTime = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printReportToolStripMenuItem
            // 
            this.printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            this.printReportToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printReportToolStripMenuItem.Text = "&Print";
            this.printReportToolStripMenuItem.Click += new System.EventHandler(this.printReportToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sales (Amount)",
            "Sales (Qty)",
            "Expenses",
            "Collectibles",
            "Payables",
            "Inventory"});
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Choose Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.chart_report);
            // 
            // reportChart
            // 
            this.reportChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.reportChart.Legends.Add(legend1);
            this.reportChart.Location = new System.Drawing.Point(0, 54);
            this.reportChart.Name = "reportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.reportChart.Series.Add(series1);
            this.reportChart.Size = new System.Drawing.Size(528, 502);
            this.reportChart.TabIndex = 2;
            this.reportChart.Text = "chart1";
            title1.Name = "Sales per Item";
            this.reportChart.Titles.Add(title1);
            // 
            // startdateTime
            // 
            this.startdateTime.Location = new System.Drawing.Point(139, 28);
            this.startdateTime.Name = "startdateTime";
            this.startdateTime.Size = new System.Drawing.Size(185, 20);
            this.startdateTime.TabIndex = 3;
            this.startdateTime.ValueChanged += new System.EventHandler(this.chart_report);
            // 
            // enddateTime
            // 
            this.enddateTime.Location = new System.Drawing.Point(330, 28);
            this.enddateTime.Name = "enddateTime";
            this.enddateTime.Size = new System.Drawing.Size(185, 20);
            this.enddateTime.TabIndex = 4;
            this.enddateTime.ValueChanged += new System.EventHandler(this.chart_report);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_3FS_System.Reports.SalesPerReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(549, 299);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(543, 190);
            this.reportViewer1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(549, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 191);
            this.dataGridView1.TabIndex = 8;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.enddateTime);
            this.Controls.Add(this.startdateTime);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printReportToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.DateTimePicker startdateTime;
        private System.Windows.Forms.DateTimePicker enddateTime;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}