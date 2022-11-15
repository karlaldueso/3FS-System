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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startdateTime = new System.Windows.Forms.DateTimePicker();
            this.enddateTime = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
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
            "Sales",
            "Expenses",
            "Collectibles",
            "Payables",
            "Inventory"});
            this.comboBox1.Location = new System.Drawing.Point(38, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Choose Category";
            // 
            // reportChart
            // 
            chartArea2.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.reportChart.Legends.Add(legend2);
            this.reportChart.Location = new System.Drawing.Point(265, 52);
            this.reportChart.Name = "reportChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sales";
            this.reportChart.Series.Add(series2);
            this.reportChart.Size = new System.Drawing.Size(699, 405);
            this.reportChart.TabIndex = 2;
            this.reportChart.Text = "chart1";
            title2.Name = "Sales per Item";
            this.reportChart.Titles.Add(title2);
            // 
            // startdateTime
            // 
            this.startdateTime.Location = new System.Drawing.Point(38, 101);
            this.startdateTime.Name = "startdateTime";
            this.startdateTime.Size = new System.Drawing.Size(200, 20);
            this.startdateTime.TabIndex = 3;
            this.startdateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // enddateTime
            // 
            this.enddateTime.Location = new System.Drawing.Point(38, 156);
            this.enddateTime.Name = "enddateTime";
            this.enddateTime.Size = new System.Drawing.Size(200, 20);
            this.enddateTime.TabIndex = 4;
            this.enddateTime.ValueChanged += new System.EventHandler(this.enddateTime_ValueChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 469);
            this.Controls.Add(this.enddateTime);
            this.Controls.Add(this.startdateTime);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.Text = "Reports";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
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
    }
}