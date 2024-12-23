﻿namespace _3FS_System
{
    partial class CustomersProfile
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
            this.panel = new System.Windows.Forms.Panel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.customerlabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.contactNumberlabel = new System.Windows.Forms.Label();
            this.contacttext = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.lastNametext = new System.Windows.Forms.TextBox();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.firstNametext = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchName = new System.Windows.Forms.TextBox();
            this.namesearchlabel = new System.Windows.Forms.Label();
            this.editlabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EditText = new System.Windows.Forms.TextBox();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalcredittextbox = new System.Windows.Forms.TextBox();
            this.totalorderlabel = new System.Windows.Forms.Label();
            this.totalorderstextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridReceipts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalpaymentstextbox = new System.Windows.Forms.TextBox();
            this.totalpaymentslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataCollectiblesLog = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectiblesLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.AddItemButton);
            this.panel.Controls.Add(this.customerlabel);
            this.panel.Controls.Add(this.addresslabel);
            this.panel.Controls.Add(this.addresstext);
            this.panel.Controls.Add(this.emaillabel);
            this.panel.Controls.Add(this.emailtext);
            this.panel.Controls.Add(this.contactNumberlabel);
            this.panel.Controls.Add(this.contacttext);
            this.panel.Controls.Add(this.lastNamelabel);
            this.panel.Controls.Add(this.lastNametext);
            this.panel.Controls.Add(this.firstNamelabel);
            this.panel.Controls.Add(this.firstNametext);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(263, 228);
            this.panel.TabIndex = 3;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemButton.BackColor = System.Drawing.Color.White;
            this.AddItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItemButton.Location = new System.Drawing.Point(108, 182);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(127, 28);
            this.AddItemButton.TabIndex = 17;
            this.AddItemButton.Text = "ADD";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // customerlabel
            // 
            this.customerlabel.AutoSize = true;
            this.customerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerlabel.Location = new System.Drawing.Point(20, 13);
            this.customerlabel.Name = "customerlabel";
            this.customerlabel.Size = new System.Drawing.Size(222, 25);
            this.customerlabel.TabIndex = 12;
            this.customerlabel.Text = "Customer Information:";
            this.customerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addresslabel.Location = new System.Drawing.Point(31, 155);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(72, 20);
            this.addresslabel.TabIndex = 10;
            this.addresslabel.Text = "Address:";
            this.addresslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addresstext
            // 
            this.addresstext.BackColor = System.Drawing.Color.White;
            this.addresstext.ForeColor = System.Drawing.Color.Black;
            this.addresstext.Location = new System.Drawing.Point(108, 155);
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(127, 20);
            this.addresstext.TabIndex = 9;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emaillabel.Location = new System.Drawing.Point(51, 127);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(52, 20);
            this.emaillabel.TabIndex = 8;
            this.emaillabel.Text = "Email:";
            this.emaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailtext
            // 
            this.emailtext.BackColor = System.Drawing.Color.White;
            this.emailtext.ForeColor = System.Drawing.Color.Black;
            this.emailtext.Location = new System.Drawing.Point(108, 129);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(127, 20);
            this.emailtext.TabIndex = 7;
            // 
            // contactNumberlabel
            // 
            this.contactNumberlabel.AutoSize = true;
            this.contactNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contactNumberlabel.Location = new System.Drawing.Point(21, 103);
            this.contactNumberlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumberlabel.Name = "contactNumberlabel";
            this.contactNumberlabel.Size = new System.Drawing.Size(82, 20);
            this.contactNumberlabel.TabIndex = 6;
            this.contactNumberlabel.Text = "Contact #:";
            this.contactNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contacttext
            // 
            this.contacttext.BackColor = System.Drawing.Color.White;
            this.contacttext.ForeColor = System.Drawing.Color.Black;
            this.contacttext.Location = new System.Drawing.Point(108, 103);
            this.contacttext.Name = "contacttext";
            this.contacttext.Size = new System.Drawing.Size(127, 20);
            this.contacttext.TabIndex = 5;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNamelabel.Location = new System.Drawing.Point(13, 77);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(90, 20);
            this.lastNamelabel.TabIndex = 4;
            this.lastNamelabel.Text = "Last Name:";
            this.lastNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNametext
            // 
            this.lastNametext.BackColor = System.Drawing.Color.White;
            this.lastNametext.ForeColor = System.Drawing.Color.Black;
            this.lastNametext.Location = new System.Drawing.Point(108, 77);
            this.lastNametext.Name = "lastNametext";
            this.lastNametext.Size = new System.Drawing.Size(127, 20);
            this.lastNametext.TabIndex = 3;
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNamelabel.Location = new System.Drawing.Point(13, 51);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(90, 20);
            this.firstNamelabel.TabIndex = 2;
            this.firstNamelabel.Text = "First Name:";
            this.firstNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNametext
            // 
            this.firstNametext.BackColor = System.Drawing.Color.White;
            this.firstNametext.ForeColor = System.Drawing.Color.Black;
            this.firstNametext.Location = new System.Drawing.Point(108, 51);
            this.firstNametext.Name = "firstNametext";
            this.firstNametext.Size = new System.Drawing.Size(127, 20);
            this.firstNametext.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchName);
            this.panel1.Controls.Add(this.namesearchlabel);
            this.panel1.Controls.Add(this.editlabel);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.EditText);
            this.panel1.Controls.Add(this.dataGridCustomers);
            this.panel1.Location = new System.Drawing.Point(281, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 227);
            this.panel1.TabIndex = 4;
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.White;
            this.searchName.ForeColor = System.Drawing.Color.Black;
            this.searchName.Location = new System.Drawing.Point(77, 195);
            this.searchName.Margin = new System.Windows.Forms.Padding(4);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(127, 20);
            this.searchName.TabIndex = 37;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
            // 
            // namesearchlabel
            // 
            this.namesearchlabel.AutoSize = true;
            this.namesearchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesearchlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namesearchlabel.Location = new System.Drawing.Point(3, 195);
            this.namesearchlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namesearchlabel.Name = "namesearchlabel";
            this.namesearchlabel.Size = new System.Drawing.Size(71, 20);
            this.namesearchlabel.TabIndex = 38;
            this.namesearchlabel.Text = "Search:";
            // 
            // editlabel
            // 
            this.editlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlabel.Location = new System.Drawing.Point(210, 195);
            this.editlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editlabel.Name = "editlabel";
            this.editlabel.Size = new System.Drawing.Size(138, 20);
            this.editlabel.TabIndex = 36;
            this.editlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(551, 195);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 26);
            this.UpdateButton.TabIndex = 35;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EditText
            // 
            this.EditText.BackColor = System.Drawing.Color.White;
            this.EditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditText.ForeColor = System.Drawing.Color.Black;
            this.EditText.Location = new System.Drawing.Point(356, 195);
            this.EditText.Margin = new System.Windows.Forms.Padding(4);
            this.EditText.Name = "EditText";
            this.EditText.Size = new System.Drawing.Size(187, 20);
            this.EditText.TabIndex = 34;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(3, 3);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.Size = new System.Drawing.Size(668, 185);
            this.dataGridCustomers.TabIndex = 0;
            this.dataGridCustomers.SelectionChanged += new System.EventHandler(this.dataGridCustomers_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalcredittextbox);
            this.panel2.Controls.Add(this.totalorderlabel);
            this.panel2.Controls.Add(this.totalorderstextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridReceipts);
            this.panel2.Location = new System.Drawing.Point(12, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 285);
            this.panel2.TabIndex = 5;
            // 
            // totalcredittextbox
            // 
            this.totalcredittextbox.BackColor = System.Drawing.Color.White;
            this.totalcredittextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalcredittextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcredittextbox.ForeColor = System.Drawing.Color.Black;
            this.totalcredittextbox.Location = new System.Drawing.Point(267, 212);
            this.totalcredittextbox.Name = "totalcredittextbox";
            this.totalcredittextbox.ReadOnly = true;
            this.totalcredittextbox.Size = new System.Drawing.Size(203, 29);
            this.totalcredittextbox.TabIndex = 70;
            // 
            // totalorderlabel
            // 
            this.totalorderlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalorderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalorderlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalorderlabel.Location = new System.Drawing.Point(114, 248);
            this.totalorderlabel.Name = "totalorderlabel";
            this.totalorderlabel.Size = new System.Drawing.Size(146, 24);
            this.totalorderlabel.TabIndex = 71;
            this.totalorderlabel.Text = "Total Orders:";
            // 
            // totalorderstextbox
            // 
            this.totalorderstextbox.BackColor = System.Drawing.Color.White;
            this.totalorderstextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalorderstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalorderstextbox.ForeColor = System.Drawing.Color.Black;
            this.totalorderstextbox.Location = new System.Drawing.Point(266, 248);
            this.totalorderstextbox.Name = "totalorderstextbox";
            this.totalorderstextbox.ReadOnly = true;
            this.totalorderstextbox.Size = new System.Drawing.Size(203, 29);
            this.totalorderstextbox.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(120, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Total Credit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order History:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridReceipts
            // 
            this.dataGridReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceipts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceipts.Location = new System.Drawing.Point(3, 28);
            this.dataGridReceipts.Name = "dataGridReceipts";
            this.dataGridReceipts.ReadOnly = true;
            this.dataGridReceipts.RowHeadersVisible = false;
            this.dataGridReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReceipts.Size = new System.Drawing.Size(467, 178);
            this.dataGridReceipts.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.totalpaymentstextbox);
            this.panel3.Controls.Add(this.totalpaymentslabel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataCollectiblesLog);
            this.panel3.Location = new System.Drawing.Point(493, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 285);
            this.panel3.TabIndex = 6;
            // 
            // totalpaymentstextbox
            // 
            this.totalpaymentstextbox.BackColor = System.Drawing.Color.White;
            this.totalpaymentstextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalpaymentstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentstextbox.ForeColor = System.Drawing.Color.Black;
            this.totalpaymentstextbox.Location = new System.Drawing.Point(247, 251);
            this.totalpaymentstextbox.Name = "totalpaymentstextbox";
            this.totalpaymentstextbox.ReadOnly = true;
            this.totalpaymentstextbox.Size = new System.Drawing.Size(210, 29);
            this.totalpaymentstextbox.TabIndex = 67;
            // 
            // totalpaymentslabel
            // 
            this.totalpaymentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalpaymentslabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalpaymentslabel.Location = new System.Drawing.Point(73, 253);
            this.totalpaymentslabel.Name = "totalpaymentslabel";
            this.totalpaymentslabel.Size = new System.Drawing.Size(168, 24);
            this.totalpaymentslabel.TabIndex = 68;
            this.totalpaymentslabel.Text = "Total Payments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Payments:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataCollectiblesLog
            // 
            this.dataCollectiblesLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCollectiblesLog.BackgroundColor = System.Drawing.Color.White;
            this.dataCollectiblesLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCollectiblesLog.Location = new System.Drawing.Point(3, 28);
            this.dataCollectiblesLog.Name = "dataCollectiblesLog";
            this.dataCollectiblesLog.ReadOnly = true;
            this.dataCollectiblesLog.RowHeadersVisible = false;
            this.dataCollectiblesLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCollectiblesLog.Size = new System.Drawing.Size(456, 222);
            this.dataCollectiblesLog.TabIndex = 2;
            // 
            // CustomersProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(976, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersProfile";
            this.Text = "Customer Profile";
            this.Load += new System.EventHandler(this.CustomerProfile_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectiblesLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label customerlabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label contactNumberlabel;
        private System.Windows.Forms.TextBox contacttext;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.TextBox lastNametext;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox firstNametext;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.DataGridView dataGridReceipts;
        private System.Windows.Forms.DataGridView dataCollectiblesLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label editlabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox EditText;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Label namesearchlabel;
        private System.Windows.Forms.TextBox totalorderstextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalpaymentstextbox;
        private System.Windows.Forms.Label totalpaymentslabel;
        private System.Windows.Forms.TextBox totalcredittextbox;
        private System.Windows.Forms.Label totalorderlabel;
    }
}