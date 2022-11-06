﻿namespace _3FS_System
{
    partial class Inventory
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
            this.namesearchlabel = new System.Windows.Forms.Label();
            this.additemlabel = new System.Windows.Forms.Label();
            this.searchBrandName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editlabel = new System.Windows.Forms.Label();
            this.addpanel = new System.Windows.Forms.Panel();
            this.ItemNameText = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.itemnamelabel = new System.Windows.Forms.Label();
            this.brandnamelabel = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.unitlabel = new System.Windows.Forms.Label();
            this.SRPlabel = new System.Windows.Forms.Label();
            this.capitallabel = new System.Windows.Forms.Label();
            this.storagelabel = new System.Windows.Forms.Label();
            this.BrandNameText = new System.Windows.Forms.TextBox();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.StorageText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.CapitalText = new System.Windows.Forms.TextBox();
            this.UnitText = new System.Windows.Forms.TextBox();
            this.SRPText = new System.Windows.Forms.TextBox();
            this.brandlabel = new System.Windows.Forms.Label();
            this.inventorypanel = new System.Windows.Forms.Panel();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.inventorylabel = new System.Windows.Forms.Label();
            this.dataGridLogs = new System.Windows.Forms.DataGridView();
            this.inventorylog = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EditText = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.searchName = new System.Windows.Forms.TextBox();
            this.addpanel.SuspendLayout();
            this.inventorypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).BeginInit();
            this.searchpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // namesearchlabel
            // 
            this.namesearchlabel.AutoSize = true;
            this.namesearchlabel.ForeColor = System.Drawing.Color.Gold;
            this.namesearchlabel.Location = new System.Drawing.Point(48, 49);
            this.namesearchlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namesearchlabel.Name = "namesearchlabel";
            this.namesearchlabel.Size = new System.Drawing.Size(55, 20);
            this.namesearchlabel.TabIndex = 29;
            this.namesearchlabel.Text = "Name:";
            this.namesearchlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // additemlabel
            // 
            this.additemlabel.AutoSize = true;
            this.additemlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemlabel.ForeColor = System.Drawing.Color.Gold;
            this.additemlabel.Location = new System.Drawing.Point(9, 16);
            this.additemlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.additemlabel.Name = "additemlabel";
            this.additemlabel.Size = new System.Drawing.Size(141, 24);
            this.additemlabel.TabIndex = 25;
            this.additemlabel.Text = "Add New Item";
            // 
            // searchBrandName
            // 
            this.searchBrandName.BackColor = System.Drawing.Color.Maroon;
            this.searchBrandName.ForeColor = System.Drawing.Color.Yellow;
            this.searchBrandName.Location = new System.Drawing.Point(107, 78);
            this.searchBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.searchBrandName.Name = "searchBrandName";
            this.searchBrandName.Size = new System.Drawing.Size(132, 26);
            this.searchBrandName.TabIndex = 30;
            this.searchBrandName.TextChanged += new System.EventHandler(this.searchBrandName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(9, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Search";
            // 
            // editlabel
            // 
            this.editlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlabel.Location = new System.Drawing.Point(373, 290);
            this.editlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editlabel.Name = "editlabel";
            this.editlabel.Size = new System.Drawing.Size(113, 21);
            this.editlabel.TabIndex = 33;
            this.editlabel.Text = "Label:";
            this.editlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addpanel
            // 
            this.addpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addpanel.Controls.Add(this.additemlabel);
            this.addpanel.Controls.Add(this.ItemNameText);
            this.addpanel.Controls.Add(this.AddItemButton);
            this.addpanel.Controls.Add(this.itemnamelabel);
            this.addpanel.Controls.Add(this.brandnamelabel);
            this.addpanel.Controls.Add(this.categorylabel);
            this.addpanel.Controls.Add(this.quantitylabel);
            this.addpanel.Controls.Add(this.unitlabel);
            this.addpanel.Controls.Add(this.SRPlabel);
            this.addpanel.Controls.Add(this.capitallabel);
            this.addpanel.Controls.Add(this.storagelabel);
            this.addpanel.Controls.Add(this.BrandNameText);
            this.addpanel.Controls.Add(this.CategoryText);
            this.addpanel.Controls.Add(this.StorageText);
            this.addpanel.Controls.Add(this.QuantityText);
            this.addpanel.Controls.Add(this.CapitalText);
            this.addpanel.Controls.Add(this.UnitText);
            this.addpanel.Controls.Add(this.SRPText);
            this.addpanel.Location = new System.Drawing.Point(16, 7);
            this.addpanel.Margin = new System.Windows.Forms.Padding(4);
            this.addpanel.Name = "addpanel";
            this.addpanel.Size = new System.Drawing.Size(261, 324);
            this.addpanel.TabIndex = 37;
            // 
            // ItemNameText
            // 
            this.ItemNameText.BackColor = System.Drawing.Color.Maroon;
            this.ItemNameText.ForeColor = System.Drawing.Color.Yellow;
            this.ItemNameText.Location = new System.Drawing.Point(111, 49);
            this.ItemNameText.Margin = new System.Windows.Forms.Padding(4);
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Size = new System.Drawing.Size(132, 26);
            this.ItemNameText.TabIndex = 14;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.IndianRed;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Gold;
            this.AddItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItemButton.Location = new System.Drawing.Point(128, 272);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(100, 28);
            this.AddItemButton.TabIndex = 5;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemnamelabel
            // 
            this.itemnamelabel.AutoSize = true;
            this.itemnamelabel.ForeColor = System.Drawing.Color.Gold;
            this.itemnamelabel.Location = new System.Drawing.Point(12, 52);
            this.itemnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemnamelabel.Name = "itemnamelabel";
            this.itemnamelabel.Size = new System.Drawing.Size(91, 20);
            this.itemnamelabel.TabIndex = 6;
            this.itemnamelabel.Text = "Item Name:";
            this.itemnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // brandnamelabel
            // 
            this.brandnamelabel.AutoSize = true;
            this.brandnamelabel.ForeColor = System.Drawing.Color.Gold;
            this.brandnamelabel.Location = new System.Drawing.Point(1, 80);
            this.brandnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandnamelabel.Name = "brandnamelabel";
            this.brandnamelabel.Size = new System.Drawing.Size(102, 20);
            this.brandnamelabel.TabIndex = 7;
            this.brandnamelabel.Text = "Brand Name:";
            this.brandnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.ForeColor = System.Drawing.Color.Gold;
            this.categorylabel.Location = new System.Drawing.Point(26, 107);
            this.categorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(77, 20);
            this.categorylabel.TabIndex = 8;
            this.categorylabel.Text = "Category:";
            this.categorylabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.ForeColor = System.Drawing.Color.Gold;
            this.quantitylabel.Location = new System.Drawing.Point(31, 134);
            this.quantitylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(72, 20);
            this.quantitylabel.TabIndex = 9;
            this.quantitylabel.Text = "Quantity:";
            this.quantitylabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unitlabel
            // 
            this.unitlabel.AutoSize = true;
            this.unitlabel.ForeColor = System.Drawing.Color.Gold;
            this.unitlabel.Location = new System.Drawing.Point(61, 161);
            this.unitlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitlabel.Name = "unitlabel";
            this.unitlabel.Size = new System.Drawing.Size(42, 20);
            this.unitlabel.TabIndex = 10;
            this.unitlabel.Text = "Unit:";
            this.unitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SRPlabel
            // 
            this.SRPlabel.AutoSize = true;
            this.SRPlabel.ForeColor = System.Drawing.Color.Gold;
            this.SRPlabel.Location = new System.Drawing.Point(57, 189);
            this.SRPlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRPlabel.Name = "SRPlabel";
            this.SRPlabel.Size = new System.Drawing.Size(46, 20);
            this.SRPlabel.TabIndex = 11;
            this.SRPlabel.Text = "SRP:";
            this.SRPlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // capitallabel
            // 
            this.capitallabel.AutoSize = true;
            this.capitallabel.ForeColor = System.Drawing.Color.Gold;
            this.capitallabel.Location = new System.Drawing.Point(41, 216);
            this.capitallabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capitallabel.Name = "capitallabel";
            this.capitallabel.Size = new System.Drawing.Size(62, 20);
            this.capitallabel.TabIndex = 12;
            this.capitallabel.Text = "Capital:";
            this.capitallabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // storagelabel
            // 
            this.storagelabel.AutoSize = true;
            this.storagelabel.ForeColor = System.Drawing.Color.Gold;
            this.storagelabel.Location = new System.Drawing.Point(33, 243);
            this.storagelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storagelabel.Name = "storagelabel";
            this.storagelabel.Size = new System.Drawing.Size(70, 20);
            this.storagelabel.TabIndex = 13;
            this.storagelabel.Text = "Storage:";
            this.storagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrandNameText
            // 
            this.BrandNameText.BackColor = System.Drawing.Color.Maroon;
            this.BrandNameText.ForeColor = System.Drawing.Color.Yellow;
            this.BrandNameText.Location = new System.Drawing.Point(111, 78);
            this.BrandNameText.Margin = new System.Windows.Forms.Padding(4);
            this.BrandNameText.Name = "BrandNameText";
            this.BrandNameText.Size = new System.Drawing.Size(132, 26);
            this.BrandNameText.TabIndex = 15;
            // 
            // CategoryText
            // 
            this.CategoryText.BackColor = System.Drawing.Color.Maroon;
            this.CategoryText.ForeColor = System.Drawing.Color.Yellow;
            this.CategoryText.Location = new System.Drawing.Point(111, 105);
            this.CategoryText.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(132, 26);
            this.CategoryText.TabIndex = 16;
            // 
            // StorageText
            // 
            this.StorageText.BackColor = System.Drawing.Color.Maroon;
            this.StorageText.ForeColor = System.Drawing.Color.Yellow;
            this.StorageText.Location = new System.Drawing.Point(111, 240);
            this.StorageText.Margin = new System.Windows.Forms.Padding(4);
            this.StorageText.Name = "StorageText";
            this.StorageText.Size = new System.Drawing.Size(132, 26);
            this.StorageText.TabIndex = 21;
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor = System.Drawing.Color.Maroon;
            this.QuantityText.ForeColor = System.Drawing.Color.Yellow;
            this.QuantityText.Location = new System.Drawing.Point(111, 132);
            this.QuantityText.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(132, 26);
            this.QuantityText.TabIndex = 17;
            // 
            // CapitalText
            // 
            this.CapitalText.BackColor = System.Drawing.Color.Maroon;
            this.CapitalText.ForeColor = System.Drawing.Color.Yellow;
            this.CapitalText.Location = new System.Drawing.Point(111, 213);
            this.CapitalText.Margin = new System.Windows.Forms.Padding(4);
            this.CapitalText.Name = "CapitalText";
            this.CapitalText.Size = new System.Drawing.Size(132, 26);
            this.CapitalText.TabIndex = 20;
            // 
            // UnitText
            // 
            this.UnitText.BackColor = System.Drawing.Color.Maroon;
            this.UnitText.ForeColor = System.Drawing.Color.Yellow;
            this.UnitText.Location = new System.Drawing.Point(111, 159);
            this.UnitText.Margin = new System.Windows.Forms.Padding(4);
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(132, 26);
            this.UnitText.TabIndex = 18;
            // 
            // SRPText
            // 
            this.SRPText.BackColor = System.Drawing.Color.Maroon;
            this.SRPText.ForeColor = System.Drawing.Color.Yellow;
            this.SRPText.Location = new System.Drawing.Point(111, 186);
            this.SRPText.Margin = new System.Windows.Forms.Padding(4);
            this.SRPText.Name = "SRPText";
            this.SRPText.Size = new System.Drawing.Size(132, 26);
            this.SRPText.TabIndex = 19;
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.ForeColor = System.Drawing.Color.Gold;
            this.brandlabel.Location = new System.Drawing.Point(1, 81);
            this.brandlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(102, 20);
            this.brandlabel.TabIndex = 31;
            this.brandlabel.Text = "Brand Name:";
            this.brandlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inventorypanel
            // 
            this.inventorypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventorypanel.Controls.Add(this.editlabel);
            this.inventorypanel.Controls.Add(this.dataGridInventory);
            this.inventorypanel.Controls.Add(this.inventorylabel);
            this.inventorypanel.Controls.Add(this.dataGridLogs);
            this.inventorypanel.Controls.Add(this.inventorylog);
            this.inventorypanel.Controls.Add(this.UpdateButton);
            this.inventorypanel.Controls.Add(this.EditText);
            this.inventorypanel.Controls.Add(this.refreshButton);
            this.inventorypanel.Location = new System.Drawing.Point(282, 7);
            this.inventorypanel.Margin = new System.Windows.Forms.Padding(4);
            this.inventorypanel.Name = "inventorypanel";
            this.inventorypanel.Size = new System.Drawing.Size(764, 465);
            this.inventorypanel.TabIndex = 39;
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AllowUserToAddRows = false;
            this.dataGridInventory.AllowUserToDeleteRows = false;
            this.dataGridInventory.AllowUserToResizeRows = false;
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(4, 42);
            this.dataGridInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInventory.MultiSelect = false;
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.ReadOnly = true;
            this.dataGridInventory.RowHeadersVisible = false;
            this.dataGridInventory.RowHeadersWidth = 51;
            this.dataGridInventory.Size = new System.Drawing.Size(754, 224);
            this.dataGridInventory.TabIndex = 4;
            this.dataGridInventory.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // inventorylabel
            // 
            this.inventorylabel.AutoSize = true;
            this.inventorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorylabel.ForeColor = System.Drawing.Color.Gold;
            this.inventorylabel.Location = new System.Drawing.Point(391, 9);
            this.inventorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(95, 24);
            this.inventorylabel.TabIndex = 24;
            this.inventorylabel.Text = "Inventory";
            // 
            // dataGridLogs
            // 
            this.dataGridLogs.AllowUserToAddRows = false;
            this.dataGridLogs.AllowUserToDeleteRows = false;
            this.dataGridLogs.AllowUserToResizeRows = false;
            this.dataGridLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLogs.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLogs.Location = new System.Drawing.Point(4, 339);
            this.dataGridLogs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridLogs.MultiSelect = false;
            this.dataGridLogs.Name = "dataGridLogs";
            this.dataGridLogs.ReadOnly = true;
            this.dataGridLogs.RowHeadersVisible = false;
            this.dataGridLogs.RowHeadersWidth = 51;
            this.dataGridLogs.Size = new System.Drawing.Size(754, 120);
            this.dataGridLogs.TabIndex = 26;
            // 
            // inventorylog
            // 
            this.inventorylog.AutoSize = true;
            this.inventorylog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorylog.ForeColor = System.Drawing.Color.Gold;
            this.inventorylog.Location = new System.Drawing.Point(0, 309);
            this.inventorylog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventorylog.Name = "inventorylog";
            this.inventorylog.Size = new System.Drawing.Size(55, 24);
            this.inventorylog.TabIndex = 25;
            this.inventorylog.Text = "Logs";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.IndianRed;
            this.UpdateButton.Enabled = false;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.ForeColor = System.Drawing.Color.Gold;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(640, 286);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 26);
            this.UpdateButton.TabIndex = 23;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EditText
            // 
            this.EditText.BackColor = System.Drawing.Color.Maroon;
            this.EditText.Enabled = false;
            this.EditText.ForeColor = System.Drawing.Color.Yellow;
            this.EditText.Location = new System.Drawing.Point(495, 286);
            this.EditText.Margin = new System.Windows.Forms.Padding(4);
            this.EditText.Name = "EditText";
            this.EditText.Size = new System.Drawing.Size(128, 26);
            this.EditText.TabIndex = 22;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.IndianRed;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.ForeColor = System.Drawing.Color.Gold;
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.Location = new System.Drawing.Point(4, 273);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 25);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchpanel
            // 
            this.searchpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchpanel.Controls.Add(this.searchName);
            this.searchpanel.Controls.Add(this.namesearchlabel);
            this.searchpanel.Controls.Add(this.searchBrandName);
            this.searchpanel.Controls.Add(this.label11);
            this.searchpanel.Controls.Add(this.brandlabel);
            this.searchpanel.Location = new System.Drawing.Point(16, 339);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(261, 133);
            this.searchpanel.TabIndex = 38;
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.Maroon;
            this.searchName.ForeColor = System.Drawing.Color.Yellow;
            this.searchName.Location = new System.Drawing.Point(107, 46);
            this.searchName.Margin = new System.Windows.Forms.Padding(4);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(132, 26);
            this.searchName.TabIndex = 28;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
            // 
            // Inventory
            // 
            this.AcceptButton = this.AddItemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1059, 488);
            this.Controls.Add(this.addpanel);
            this.Controls.Add(this.inventorypanel);
            this.Controls.Add(this.searchpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.addpanel.ResumeLayout(false);
            this.addpanel.PerformLayout();
            this.inventorypanel.ResumeLayout(false);
            this.inventorypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).EndInit();
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label namesearchlabel;
        private System.Windows.Forms.Label additemlabel;
        private System.Windows.Forms.TextBox searchBrandName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label editlabel;
        private System.Windows.Forms.Panel addpanel;
        private System.Windows.Forms.TextBox ItemNameText;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label itemnamelabel;
        private System.Windows.Forms.Label brandnamelabel;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label unitlabel;
        private System.Windows.Forms.Label SRPlabel;
        private System.Windows.Forms.Label capitallabel;
        private System.Windows.Forms.Label storagelabel;
        private System.Windows.Forms.TextBox BrandNameText;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.TextBox StorageText;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.TextBox CapitalText;
        private System.Windows.Forms.TextBox UnitText;
        private System.Windows.Forms.TextBox SRPText;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Panel inventorypanel;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.Label inventorylabel;
        private System.Windows.Forms.DataGridView dataGridLogs;
        private System.Windows.Forms.Label inventorylog;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox EditText;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.TextBox searchName;
    }
}