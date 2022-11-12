namespace _3FS_System
{
    partial class Sales
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
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.addItem = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.TextBox();
            this.namesearchlabel = new System.Windows.Forms.Label();
            this.searchBrandName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.receiptnumTextbox = new System.Windows.Forms.TextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.grandtotalTextbox = new System.Windows.Forms.TextBox();
            this.grandtotalLabel = new System.Windows.Forms.Label();
            this.removeitemButton = new System.Windows.Forms.Button();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.searchCustomerTextbox = new System.Windows.Forms.TextBox();
            this.amountPaidTextbox = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSales = new System.Windows.Forms.TextBox();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridItems
            // 
            this.dataGridItems.AllowUserToAddRows = false;
            this.dataGridItems.AllowUserToDeleteRows = false;
            this.dataGridItems.AllowUserToResizeColumns = false;
            this.dataGridItems.AllowUserToResizeRows = false;
            this.dataGridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemNum,
            this.Qty,
            this.Unit,
            this.ItemName,
            this.Brand,
            this.SRP,
            this.Capital,
            this.UnitPrice,
            this.SubTotal});
            this.dataGridItems.Location = new System.Drawing.Point(4, 4);
            this.dataGridItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersVisible = false;
            this.dataGridItems.RowHeadersWidth = 51;
            this.dataGridItems.Size = new System.Drawing.Size(569, 192);
            this.dataGridItems.TabIndex = 0;
            this.dataGridItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItems_CellEnter);
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AllowUserToAddRows = false;
            this.dataGridInventory.AllowUserToDeleteRows = false;
            this.dataGridInventory.AllowUserToResizeColumns = false;
            this.dataGridInventory.AllowUserToResizeRows = false;
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(276, 50);
            this.dataGridInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.ReadOnly = true;
            this.dataGridInventory.RowHeadersVisible = false;
            this.dataGridInventory.RowHeadersWidth = 51;
            this.dataGridInventory.Size = new System.Drawing.Size(803, 163);
            this.dataGridInventory.TabIndex = 1;
            this.dataGridInventory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInventory_CellContentDoubleClick);
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = global::_3FS_System.Properties.Settings.Default.FormBackground;
            this.searchpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchpanel.Controls.Add(this.addItem);
            this.searchpanel.Controls.Add(this.searchName);
            this.searchpanel.Controls.Add(this.namesearchlabel);
            this.searchpanel.Controls.Add(this.searchBrandName);
            this.searchpanel.Controls.Add(this.label11);
            this.searchpanel.Controls.Add(this.brandlabel);
            this.searchpanel.Location = new System.Drawing.Point(7, 50);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(261, 163);
            this.searchpanel.TabIndex = 39;
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.White;
            this.addItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.ForeColor = System.Drawing.Color.Black;
            this.addItem.Location = new System.Drawing.Point(60, 107);
            this.addItem.Margin = new System.Windows.Forms.Padding(4);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(139, 36);
            this.addItem.TabIndex = 33;
            this.addItem.Text = "ADD ITEM";
            this.addItem.UseVisualStyleBackColor = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.White;
            this.searchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName.ForeColor = System.Drawing.Color.Black;
            this.searchName.Location = new System.Drawing.Point(107, 44);
            this.searchName.Margin = new System.Windows.Forms.Padding(4);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(132, 24);
            this.searchName.TabIndex = 28;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
            // 
            // namesearchlabel
            // 
            this.namesearchlabel.AutoSize = true;
            this.namesearchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesearchlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namesearchlabel.Location = new System.Drawing.Point(47, 46);
            this.namesearchlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namesearchlabel.Name = "namesearchlabel";
            this.namesearchlabel.Size = new System.Drawing.Size(52, 18);
            this.namesearchlabel.TabIndex = 29;
            this.namesearchlabel.Text = "Name:";
            // 
            // searchBrandName
            // 
            this.searchBrandName.BackColor = System.Drawing.Color.White;
            this.searchBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBrandName.ForeColor = System.Drawing.Color.Black;
            this.searchBrandName.Location = new System.Drawing.Point(107, 75);
            this.searchBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.searchBrandName.Name = "searchBrandName";
            this.searchBrandName.Size = new System.Drawing.Size(132, 24);
            this.searchBrandName.TabIndex = 30;
            this.searchBrandName.TextChanged += new System.EventHandler(this.searchBrandName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(9, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Search";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brandlabel.Location = new System.Drawing.Point(4, 77);
            this.brandlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(95, 18);
            this.brandlabel.TabIndex = 31;
            this.brandlabel.Text = "Brand Name:";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.White;
            this.doneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.Black;
            this.doneButton.Location = new System.Drawing.Point(27, 192);
            this.doneButton.Margin = new System.Windows.Forms.Padding(4);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(149, 34);
            this.doneButton.TabIndex = 42;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // receiptnumTextbox
            // 
            this.receiptnumTextbox.BackColor = System.Drawing.Color.White;
            this.receiptnumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.receiptnumTextbox.ForeColor = System.Drawing.Color.Black;
            this.receiptnumTextbox.Location = new System.Drawing.Point(0, 31);
            this.receiptnumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.receiptnumTextbox.Name = "receiptnumTextbox";
            this.receiptnumTextbox.Size = new System.Drawing.Size(200, 29);
            this.receiptnumTextbox.TabIndex = 43;
            this.receiptnumTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.receiptLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptLabel.Location = new System.Drawing.Point(3, 4);
            this.receiptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(91, 20);
            this.receiptLabel.TabIndex = 44;
            this.receiptLabel.Text = "Receipt #:";
            // 
            // grandtotalTextbox
            // 
            this.grandtotalTextbox.BackColor = System.Drawing.Color.White;
            this.grandtotalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalTextbox.ForeColor = System.Drawing.Color.Black;
            this.grandtotalTextbox.Location = new System.Drawing.Point(403, 203);
            this.grandtotalTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.grandtotalTextbox.Name = "grandtotalTextbox";
            this.grandtotalTextbox.ReadOnly = true;
            this.grandtotalTextbox.Size = new System.Drawing.Size(168, 29);
            this.grandtotalTextbox.TabIndex = 45;
            this.grandtotalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grandtotalLabel
            // 
            this.grandtotalLabel.AutoSize = true;
            this.grandtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grandtotalLabel.Location = new System.Drawing.Point(249, 209);
            this.grandtotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grandtotalLabel.Name = "grandtotalLabel";
            this.grandtotalLabel.Size = new System.Drawing.Size(109, 20);
            this.grandtotalLabel.TabIndex = 46;
            this.grandtotalLabel.Text = "Grand Total:";
            // 
            // removeitemButton
            // 
            this.removeitemButton.BackColor = System.Drawing.Color.White;
            this.removeitemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.removeitemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeitemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeitemButton.ForeColor = System.Drawing.Color.Black;
            this.removeitemButton.Location = new System.Drawing.Point(4, 203);
            this.removeitemButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeitemButton.Name = "removeitemButton";
            this.removeitemButton.Size = new System.Drawing.Size(150, 36);
            this.removeitemButton.TabIndex = 47;
            this.removeitemButton.Text = "Remove Item";
            this.removeitemButton.UseVisualStyleBackColor = false;
            this.removeitemButton.Click += new System.EventHandler(this.removeitemButton_Click);
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToResizeColumns = false;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(12, 75);
            this.dataGridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.Size = new System.Drawing.Size(261, 164);
            this.dataGridCustomers.TabIndex = 49;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerLabel.Location = new System.Drawing.Point(4, 39);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(67, 16);
            this.customerLabel.TabIndex = 50;
            this.customerLabel.Text = "Customer:";
            // 
            // searchCustomerTextbox
            // 
            this.searchCustomerTextbox.BackColor = System.Drawing.Color.White;
            this.searchCustomerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchCustomerTextbox.ForeColor = System.Drawing.Color.Black;
            this.searchCustomerTextbox.Location = new System.Drawing.Point(80, 32);
            this.searchCustomerTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchCustomerTextbox.Name = "searchCustomerTextbox";
            this.searchCustomerTextbox.Size = new System.Drawing.Size(188, 29);
            this.searchCustomerTextbox.TabIndex = 51;
            this.searchCustomerTextbox.TextChanged += new System.EventHandler(this.searchCustomerTextbox_TextChanged);
            // 
            // amountPaidTextbox
            // 
            this.amountPaidTextbox.BackColor = System.Drawing.Color.White;
            this.amountPaidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidTextbox.ForeColor = System.Drawing.Color.Black;
            this.amountPaidTextbox.Location = new System.Drawing.Point(27, 149);
            this.amountPaidTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.amountPaidTextbox.Name = "amountPaidTextbox";
            this.amountPaidTextbox.Size = new System.Drawing.Size(148, 29);
            this.amountPaidTextbox.TabIndex = 53;
            this.amountPaidTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountPaid
            // 
            this.amountPaid.AutoSize = true;
            this.amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amountPaid.Location = new System.Drawing.Point(24, 121);
            this.amountPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(116, 20);
            this.amountPaid.TabIndex = 54;
            this.amountPaid.Text = "Amount Paid:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridItems);
            this.panel1.Controls.Add(this.grandtotalTextbox);
            this.panel1.Controls.Add(this.removeitemButton);
            this.panel1.Controls.Add(this.grandtotalLabel);
            this.panel1.Location = new System.Drawing.Point(311, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 248);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.receiptLabel);
            this.panel2.Controls.Add(this.doneButton);
            this.panel2.Controls.Add(this.amountPaidTextbox);
            this.panel2.Controls.Add(this.receiptnumTextbox);
            this.panel2.Controls.Add(this.amountPaid);
            this.panel2.Location = new System.Drawing.Point(900, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 248);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.searchCustomerTextbox);
            this.panel3.Controls.Add(this.dataGridCustomers);
            this.panel3.Controls.Add(this.customerLabel);
            this.panel3.Location = new System.Drawing.Point(16, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 248);
            this.panel3.TabIndex = 57;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gold;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Gold;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridInventory);
            this.panel4.Controls.Add(this.searchpanel);
            this.panel4.Location = new System.Drawing.Point(16, 284);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 219);
            this.panel4.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Inventory";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = global::_3FS_System.Properties.Settings.Default.FormBackground;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiptsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // receiptsToolStripMenuItem
            // 
            this.receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            this.receiptsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.receiptsToolStripMenuItem.Text = "Receipts";
            this.receiptsToolStripMenuItem.Click += new System.EventHandler(this.receiptsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 543);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(632, 52);
            this.label2.TabIndex = 56;
            this.label2.Text = "TOTAL SALES FOR TODAY:";
            // 
            // totalSales
            // 
            this.totalSales.BackColor = System.Drawing.Color.White;
            this.totalSales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSales.ForeColor = System.Drawing.Color.Black;
            this.totalSales.Location = new System.Drawing.Point(641, 540);
            this.totalSales.Margin = new System.Windows.Forms.Padding(4);
            this.totalSales.Name = "totalSales";
            this.totalSales.ReadOnly = true;
            this.totalSales.Size = new System.Drawing.Size(461, 58);
            this.totalSales.TabIndex = 8;
            this.totalSales.TabStop = false;
            this.totalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // ItemNum
            // 
            this.ItemNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemNum.HeaderText = "Item #";
            this.ItemNum.MinimumWidth = 6;
            this.ItemNum.Name = "ItemNum";
            this.ItemNum.ReadOnly = true;
            this.ItemNum.Width = 60;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 46;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 49;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemName.HeaderText = "Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 58;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 58;
            // 
            // SRP
            // 
            this.SRP.HeaderText = "SRP";
            this.SRP.MinimumWidth = 6;
            this.SRP.Name = "SRP";
            this.SRP.ReadOnly = true;
            this.SRP.Visible = false;
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Capital";
            this.Capital.MinimumWidth = 6;
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 76;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 76;
            // 
            // Sales
            // 
            this.AcceptButton = this.addItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1112, 607);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.DockChanged += new System.EventHandler(this.Sales_DockChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Label namesearchlabel;
        private System.Windows.Forms.TextBox searchBrandName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox receiptnumTextbox;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.TextBox grandtotalTextbox;
        private System.Windows.Forms.Label grandtotalLabel;
        private System.Windows.Forms.Button removeitemButton;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox searchCustomerTextbox;
        private System.Windows.Forms.TextBox amountPaidTextbox;
        private System.Windows.Forms.Label amountPaid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}