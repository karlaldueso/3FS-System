namespace _3FS_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.inventory_button = new System.Windows.Forms.Button();
            this.sales_button = new System.Windows.Forms.Button();
            this.customers_button = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.customerProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventory_button
            // 
            this.inventory_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_button.Location = new System.Drawing.Point(0, 376);
            this.inventory_button.Margin = new System.Windows.Forms.Padding(4);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(259, 127);
            this.inventory_button.TabIndex = 0;
            this.inventory_button.Text = "Inventory";
            this.inventory_button.UseVisualStyleBackColor = true;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // sales_button
            // 
            this.sales_button.AutoSize = true;
            this.sales_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.sales_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_button.Location = new System.Drawing.Point(0, 256);
            this.sales_button.Margin = new System.Windows.Forms.Padding(4);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(259, 120);
            this.sales_button.TabIndex = 1;
            this.sales_button.Text = "Sales";
            this.sales_button.UseVisualStyleBackColor = true;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // customers_button
            // 
            this.customers_button.AutoSize = true;
            this.customers_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.customers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_button.Location = new System.Drawing.Point(0, 0);
            this.customers_button.Margin = new System.Windows.Forms.Padding(4);
            this.customers_button.Name = "customers_button";
            this.customers_button.Size = new System.Drawing.Size(259, 129);
            this.customers_button.TabIndex = 2;
            this.customers_button.Text = "Collectibles";
            this.customers_button.UseVisualStyleBackColor = true;
            this.customers_button.Click += new System.EventHandler(this.customers_button_Click);
            // 
            // users
            // 
            this.users.AutoSize = true;
            this.users.Dock = System.Windows.Forms.DockStyle.Top;
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Location = new System.Drawing.Point(0, 503);
            this.users.Margin = new System.Windows.Forms.Padding(4);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(259, 140);
            this.users.TabIndex = 3;
            this.users.Text = "Users";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // customerProfile
            // 
            this.customerProfile.AutoSize = true;
            this.customerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerProfile.Location = new System.Drawing.Point(0, 129);
            this.customerProfile.Margin = new System.Windows.Forms.Padding(4);
            this.customerProfile.Name = "customerProfile";
            this.customerProfile.Size = new System.Drawing.Size(259, 127);
            this.customerProfile.TabIndex = 4;
            this.customerProfile.Text = "Customers";
            this.customerProfile.UseVisualStyleBackColor = true;
            this.customerProfile.Click += new System.EventHandler(this.customerProfile_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.users);
            this.panel1.Controls.Add(this.inventory_button);
            this.panel1.Controls.Add(this.sales_button);
            this.panel1.Controls.Add(this.customerProfile);
            this.panel1.Controls.Add(this.customers_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 663);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1377, 663);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 480);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WarehausPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Button customers_button;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button customerProfile;
        private System.Windows.Forms.Panel panel1;
    }
}