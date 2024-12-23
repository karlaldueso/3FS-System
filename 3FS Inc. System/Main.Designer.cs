﻿namespace _3FS_System
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
            this.sales_button = new System.Windows.Forms.Button();
            this.customers_button = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.customerProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.suppliers_button = new System.Windows.Forms.Button();
            this.Inventory_new = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sales_button
            // 
            this.sales_button.AutoSize = true;
            this.sales_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.sales_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_button.Location = new System.Drawing.Point(0, 237);
            this.sales_button.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(221, 126);
            this.sales_button.TabIndex = 2;
            this.sales_button.Text = "Sales";
            this.sales_button.UseVisualStyleBackColor = true;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // customers_button
            // 
            this.customers_button.AutoSize = true;
            this.customers_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.customers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_button.Location = new System.Drawing.Point(0, 492);
            this.customers_button.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.customers_button.Name = "customers_button";
            this.customers_button.Size = new System.Drawing.Size(221, 122);
            this.customers_button.TabIndex = 4;
            this.customers_button.Text = "Collectibles";
            this.customers_button.UseVisualStyleBackColor = true;
            this.customers_button.Click += new System.EventHandler(this.customers_button_Click);
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Dock = System.Windows.Forms.DockStyle.Top;
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Location = new System.Drawing.Point(0, 0);
            this.users.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(221, 109);
            this.users.TabIndex = 0;
            this.users.Text = "Users";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // customerProfile
            // 
            this.customerProfile.AutoSize = true;
            this.customerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerProfile.Location = new System.Drawing.Point(0, 363);
            this.customerProfile.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.customerProfile.Name = "customerProfile";
            this.customerProfile.Size = new System.Drawing.Size(221, 129);
            this.customerProfile.TabIndex = 3;
            this.customerProfile.Text = "Customers";
            this.customerProfile.UseVisualStyleBackColor = true;
            this.customerProfile.Click += new System.EventHandler(this.customerProfile_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.suppliers_button);
            this.panel1.Controls.Add(this.customers_button);
            this.panel1.Controls.Add(this.customerProfile);
            this.panel1.Controls.Add(this.sales_button);
            this.panel1.Controls.Add(this.Inventory_new);
            this.panel1.Controls.Add(this.users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 740);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // suppliers_button
            // 
            this.suppliers_button.AutoSize = true;
            this.suppliers_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppliers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliers_button.Location = new System.Drawing.Point(0, 614);
            this.suppliers_button.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.suppliers_button.Name = "suppliers_button";
            this.suppliers_button.Size = new System.Drawing.Size(221, 122);
            this.suppliers_button.TabIndex = 5;
            this.suppliers_button.Text = "Suppliers";
            this.suppliers_button.UseVisualStyleBackColor = true;
            this.suppliers_button.Click += new System.EventHandler(this.suppliers_button_Click);
            // 
            // Inventory_new
            // 
            this.Inventory_new.AutoSize = true;
            this.Inventory_new.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inventory_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_new.Location = new System.Drawing.Point(0, 109);
            this.Inventory_new.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Inventory_new.Name = "Inventory_new";
            this.Inventory_new.Size = new System.Drawing.Size(221, 128);
            this.Inventory_new.TabIndex = 1;
            this.Inventory_new.Text = "Inventory";
            this.Inventory_new.UseVisualStyleBackColor = true;
            this.Inventory_new.Click += new System.EventHandler(this.Inventory_new_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.SettingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1540, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.editToolStripMenuItem.Text = "&Reports";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(188, 27);
            this.toolsToolStripMenuItem.Text = "&Set Background Color";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.SettingToolStripMenuItem.Text = "&Settings";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(151, 28);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = global::_3FS_System.Properties.Settings.Default.FormBackground;
            this.BackgroundImage = global::_3FS_System.Properties.Resources.hardware_logo_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1540, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.MaximumSize = new System.Drawing.Size(6363, 3202);
            this.MinimumSize = new System.Drawing.Size(1534, 814);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WarehausPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Button customers_button;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button customerProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Inventory_new;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button suppliers_button;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
    }
}