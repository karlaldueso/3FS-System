namespace _3FS_Inc._System
{
    partial class Main
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
            this.maintab = new System.Windows.Forms.TabControl();
            this.sales_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventory_tab = new System.Windows.Forms.TabPage();
            this.pettycash_tab = new System.Windows.Forms.TabPage();
            this.payables_tab = new System.Windows.Forms.TabPage();
            this.collectibles_tab = new System.Windows.Forms.TabPage();
            this.profiles_tab = new System.Windows.Forms.TabPage();
            this.reports_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maintab.SuspendLayout();
            this.sales_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintab
            // 
            this.maintab.Controls.Add(this.sales_tab);
            this.maintab.Controls.Add(this.inventory_tab);
            this.maintab.Controls.Add(this.pettycash_tab);
            this.maintab.Controls.Add(this.payables_tab);
            this.maintab.Controls.Add(this.collectibles_tab);
            this.maintab.Controls.Add(this.profiles_tab);
            this.maintab.Controls.Add(this.reports_tab);
            this.maintab.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maintab.Location = new System.Drawing.Point(3, 3);
            this.maintab.Name = "maintab";
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(1132, 532);
            this.maintab.TabIndex = 0;
            this.maintab.Selected += new System.Windows.Forms.TabControlEventHandler(this.maintab_Selected);
            // 
            // sales_tab
            // 
            this.sales_tab.Controls.Add(this.dataGridView1);
            this.sales_tab.Location = new System.Drawing.Point(4, 37);
            this.sales_tab.Name = "sales_tab";
            this.sales_tab.Padding = new System.Windows.Forms.Padding(3);
            this.sales_tab.Size = new System.Drawing.Size(1124, 491);
            this.sales_tab.TabIndex = 0;
            this.sales_tab.Tag = "";
            this.sales_tab.Text = "Sales";
            this.sales_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(679, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // inventory_tab
            // 
            this.inventory_tab.Location = new System.Drawing.Point(4, 37);
            this.inventory_tab.Name = "inventory_tab";
            this.inventory_tab.Padding = new System.Windows.Forms.Padding(3);
            this.inventory_tab.Size = new System.Drawing.Size(1124, 491);
            this.inventory_tab.TabIndex = 1;
            this.inventory_tab.Tag = "";
            this.inventory_tab.Text = "Inventory";
            this.inventory_tab.UseVisualStyleBackColor = true;
            // 
            // pettycash_tab
            // 
            this.pettycash_tab.Location = new System.Drawing.Point(4, 37);
            this.pettycash_tab.Name = "pettycash_tab";
            this.pettycash_tab.Size = new System.Drawing.Size(1124, 491);
            this.pettycash_tab.TabIndex = 5;
            this.pettycash_tab.Tag = "";
            this.pettycash_tab.Text = "Petty Cash";
            this.pettycash_tab.UseVisualStyleBackColor = true;
            // 
            // payables_tab
            // 
            this.payables_tab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.payables_tab.Location = new System.Drawing.Point(4, 37);
            this.payables_tab.Name = "payables_tab";
            this.payables_tab.Padding = new System.Windows.Forms.Padding(3);
            this.payables_tab.Size = new System.Drawing.Size(1124, 491);
            this.payables_tab.TabIndex = 3;
            this.payables_tab.Tag = "";
            this.payables_tab.Text = "Payables";
            this.payables_tab.UseVisualStyleBackColor = true;
            // 
            // collectibles_tab
            // 
            this.collectibles_tab.Location = new System.Drawing.Point(4, 37);
            this.collectibles_tab.Name = "collectibles_tab";
            this.collectibles_tab.Padding = new System.Windows.Forms.Padding(3);
            this.collectibles_tab.Size = new System.Drawing.Size(1124, 491);
            this.collectibles_tab.TabIndex = 2;
            this.collectibles_tab.Tag = "";
            this.collectibles_tab.Text = "Collectibles";
            this.collectibles_tab.UseVisualStyleBackColor = true;
            // 
            // profiles_tab
            // 
            this.profiles_tab.Location = new System.Drawing.Point(4, 37);
            this.profiles_tab.Name = "profiles_tab";
            this.profiles_tab.Size = new System.Drawing.Size(1124, 491);
            this.profiles_tab.TabIndex = 6;
            this.profiles_tab.Tag = "";
            this.profiles_tab.Text = "Profiles ";
            this.profiles_tab.UseVisualStyleBackColor = true;
            // 
            // reports_tab
            // 
            this.reports_tab.Location = new System.Drawing.Point(4, 37);
            this.reports_tab.Name = "reports_tab";
            this.reports_tab.Size = new System.Drawing.Size(1124, 491);
            this.reports_tab.TabIndex = 4;
            this.reports_tab.Tag = "";
            this.reports_tab.Text = "Reports";
            this.reports_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.maintab, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 538);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "3FS Inc. System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.maintab.ResumeLayout(false);
            this.sales_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl maintab;
        private TabPage sales_tab;
        private TabPage inventory_tab;
        private TabPage collectibles_tab;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage payables_tab;
        private TabPage reports_tab;
        private TabPage pettycash_tab;
        private TabPage profiles_tab;
        private DataGridView dataGridView1;
    }
}