﻿namespace _3FS_System
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
            this.components = new System.ComponentModel.Container();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
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
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchName = new System.Windows.Forms.TextBox();
            this.namesearchlabel = new System.Windows.Forms.Label();
            this.searchBrandName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.receiptnumTextbox = new System.Windows.Forms.TextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.grandtotalTextbox = new System.Windows.Forms.TextBox();
            this.grandtotalLabel = new System.Windows.Forms.Label();
            this.removeitemButton = new System.Windows.Forms.Button();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.searchCustomerTextbox = new System.Windows.Forms.TextBox();
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.amountPaidTextbox = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridItems
            // 
            this.dataGridItems.AllowUserToAddRows = false;
            this.dataGridItems.AllowUserToDeleteRows = false;
            this.dataGridItems.AllowUserToResizeColumns = false;
            this.dataGridItems.AllowUserToResizeRows = false;
            this.dataGridItems.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.dataGridItems.Location = new System.Drawing.Point(3, 3);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersVisible = false;
            this.dataGridItems.Size = new System.Drawing.Size(427, 156);
            this.dataGridItems.TabIndex = 0;
            this.dataGridItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItems_CellEnter);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // ItemNum
            // 
            this.ItemNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItemNum.HeaderText = "Item #";
            this.ItemNum.Name = "ItemNum";
            this.ItemNum.ReadOnly = true;
            this.ItemNum.Width = 60;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 46;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 49;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 58;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 58;
            // 
            // SRP
            // 
            this.SRP.HeaderText = "SRP";
            this.SRP.Name = "SRP";
            this.SRP.ReadOnly = true;
            this.SRP.Visible = false;
            // 
            // Capital
            // 
            this.Capital.HeaderText = "Capital";
            this.Capital.Name = "Capital";
            this.Capital.ReadOnly = true;
            this.Capital.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 76;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 76;
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AllowUserToAddRows = false;
            this.dataGridInventory.AllowUserToDeleteRows = false;
            this.dataGridInventory.AllowUserToResizeColumns = false;
            this.dataGridInventory.AllowUserToResizeRows = false;
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(207, 41);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.ReadOnly = true;
            this.dataGridInventory.RowHeadersVisible = false;
            this.dataGridInventory.Size = new System.Drawing.Size(602, 99);
            this.dataGridInventory.TabIndex = 1;
            // 
            // searchpanel
            // 
            this.searchpanel.BackColor = System.Drawing.Color.Firebrick;
            this.searchpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchpanel.Controls.Add(this.searchName);
            this.searchpanel.Controls.Add(this.namesearchlabel);
            this.searchpanel.Controls.Add(this.searchBrandName);
            this.searchpanel.Controls.Add(this.label11);
            this.searchpanel.Controls.Add(this.brandlabel);
            this.searchpanel.Location = new System.Drawing.Point(5, 41);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(196, 99);
            this.searchpanel.TabIndex = 39;
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.Maroon;
            this.searchName.ForeColor = System.Drawing.Color.Yellow;
            this.searchName.Location = new System.Drawing.Point(80, 37);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(100, 20);
            this.searchName.TabIndex = 28;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
            // 
            // namesearchlabel
            // 
            this.namesearchlabel.AutoSize = true;
            this.namesearchlabel.ForeColor = System.Drawing.Color.Gold;
            this.namesearchlabel.Location = new System.Drawing.Point(36, 40);
            this.namesearchlabel.Name = "namesearchlabel";
            this.namesearchlabel.Size = new System.Drawing.Size(38, 13);
            this.namesearchlabel.TabIndex = 29;
            this.namesearchlabel.Text = "Name:";
            // 
            // searchBrandName
            // 
            this.searchBrandName.BackColor = System.Drawing.Color.Maroon;
            this.searchBrandName.ForeColor = System.Drawing.Color.Yellow;
            this.searchBrandName.Location = new System.Drawing.Point(80, 63);
            this.searchBrandName.Name = "searchBrandName";
            this.searchBrandName.Size = new System.Drawing.Size(100, 20);
            this.searchBrandName.TabIndex = 30;
            this.searchBrandName.TextChanged += new System.EventHandler(this.searchBrandName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(7, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Search";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.ForeColor = System.Drawing.Color.Gold;
            this.brandlabel.Location = new System.Drawing.Point(8, 66);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(69, 13);
            this.brandlabel.TabIndex = 31;
            this.brandlabel.Text = "Brand Name:";
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.IndianRed;
            this.addItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItem.ForeColor = System.Drawing.Color.Gold;
            this.addItem.Location = new System.Drawing.Point(3, 165);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(82, 29);
            this.addItem.TabIndex = 33;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.IndianRed;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.Gold;
            this.doneButton.Location = new System.Drawing.Point(20, 156);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(112, 28);
            this.doneButton.TabIndex = 42;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // receiptnumTextbox
            // 
            this.receiptnumTextbox.BackColor = System.Drawing.Color.Maroon;
            this.receiptnumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.receiptnumTextbox.ForeColor = System.Drawing.Color.Yellow;
            this.receiptnumTextbox.Location = new System.Drawing.Point(20, 22);
            this.receiptnumTextbox.Name = "receiptnumTextbox";
            this.receiptnumTextbox.Size = new System.Drawing.Size(112, 29);
            this.receiptnumTextbox.TabIndex = 43;
            this.receiptnumTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.receiptLabel.ForeColor = System.Drawing.Color.Gold;
            this.receiptLabel.Location = new System.Drawing.Point(31, 0);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(91, 20);
            this.receiptLabel.TabIndex = 44;
            this.receiptLabel.Text = "Receipt #:";
            // 
            // grandtotalTextbox
            // 
            this.grandtotalTextbox.BackColor = System.Drawing.Color.Maroon;
            this.grandtotalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalTextbox.ForeColor = System.Drawing.Color.Yellow;
            this.grandtotalTextbox.Location = new System.Drawing.Point(302, 165);
            this.grandtotalTextbox.Name = "grandtotalTextbox";
            this.grandtotalTextbox.ReadOnly = true;
            this.grandtotalTextbox.Size = new System.Drawing.Size(127, 29);
            this.grandtotalTextbox.TabIndex = 45;
            this.grandtotalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grandtotalLabel
            // 
            this.grandtotalLabel.AutoSize = true;
            this.grandtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotalLabel.ForeColor = System.Drawing.Color.Gold;
            this.grandtotalLabel.Location = new System.Drawing.Point(187, 170);
            this.grandtotalLabel.Name = "grandtotalLabel";
            this.grandtotalLabel.Size = new System.Drawing.Size(109, 20);
            this.grandtotalLabel.TabIndex = 46;
            this.grandtotalLabel.Text = "Grand Total:";
            // 
            // removeitemButton
            // 
            this.removeitemButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeitemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeitemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.removeitemButton.ForeColor = System.Drawing.Color.Gold;
            this.removeitemButton.Location = new System.Drawing.Point(99, 165);
            this.removeitemButton.Name = "removeitemButton";
            this.removeitemButton.Size = new System.Drawing.Size(82, 29);
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
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(9, 61);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.Size = new System.Drawing.Size(196, 133);
            this.dataGridCustomers.TabIndex = 49;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.ForeColor = System.Drawing.Color.Gold;
            this.customerLabel.Location = new System.Drawing.Point(3, 34);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 50;
            this.customerLabel.Text = "Customer:";
            // 
            // searchCustomerTextbox
            // 
            this.searchCustomerTextbox.BackColor = System.Drawing.Color.Maroon;
            this.searchCustomerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchCustomerTextbox.ForeColor = System.Drawing.Color.Yellow;
            this.searchCustomerTextbox.Location = new System.Drawing.Point(60, 26);
            this.searchCustomerTextbox.Name = "searchCustomerTextbox";
            this.searchCustomerTextbox.Size = new System.Drawing.Size(142, 29);
            this.searchCustomerTextbox.TabIndex = 51;
            this.searchCustomerTextbox.TextChanged += new System.EventHandler(this.searchCustomerTextbox_TextChanged);
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeLabel.ForeColor = System.Drawing.Color.Gold;
            this.datetimeLabel.Location = new System.Drawing.Point(6, 4);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(196, 19);
            this.datetimeLabel.TabIndex = 52;
            this.datetimeLabel.Text = "datetimenow";
            this.datetimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // amountPaidTextbox
            // 
            this.amountPaidTextbox.BackColor = System.Drawing.Color.Maroon;
            this.amountPaidTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidTextbox.ForeColor = System.Drawing.Color.Yellow;
            this.amountPaidTextbox.Location = new System.Drawing.Point(20, 121);
            this.amountPaidTextbox.Name = "amountPaidTextbox";
            this.amountPaidTextbox.Size = new System.Drawing.Size(112, 29);
            this.amountPaidTextbox.TabIndex = 53;
            this.amountPaidTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountPaid
            // 
            this.amountPaid.AutoSize = true;
            this.amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaid.ForeColor = System.Drawing.Color.Gold;
            this.amountPaid.Location = new System.Drawing.Point(18, 98);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(116, 20);
            this.amountPaid.TabIndex = 54;
            this.amountPaid.Text = "Amount Paid:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addItem);
            this.panel1.Controls.Add(this.dataGridItems);
            this.panel1.Controls.Add(this.grandtotalTextbox);
            this.panel1.Controls.Add(this.removeitemButton);
            this.panel1.Controls.Add(this.grandtotalLabel);
            this.panel1.Location = new System.Drawing.Point(233, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 202);
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
            this.panel2.Location = new System.Drawing.Point(675, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 202);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.searchCustomerTextbox);
            this.panel3.Controls.Add(this.dataGridCustomers);
            this.panel3.Controls.Add(this.customerLabel);
            this.panel3.Controls.Add(this.datetimeLabel);
            this.panel3.Location = new System.Drawing.Point(12, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 202);
            this.panel3.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridInventory);
            this.panel4.Controls.Add(this.searchpanel);
            this.panel4.Location = new System.Drawing.Point(12, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(815, 148);
            this.panel4.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(348, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Inventory";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(841, 391);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox searchCustomerTextbox;
        private System.Windows.Forms.Label datetimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox amountPaidTextbox;
        private System.Windows.Forms.Label amountPaid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}