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
            this.inventory_button = new System.Windows.Forms.Button();
            this.sales_button = new System.Windows.Forms.Button();
            this.customers_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inventory_button
            // 
            this.inventory_button.Location = new System.Drawing.Point(83, 83);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(76, 26);
            this.inventory_button.TabIndex = 0;
            this.inventory_button.Text = "Inventory";
            this.inventory_button.UseVisualStyleBackColor = true;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // sales_button
            // 
            this.sales_button.Location = new System.Drawing.Point(83, 115);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(76, 26);
            this.sales_button.TabIndex = 1;
            this.sales_button.Text = "Sales";
            this.sales_button.UseVisualStyleBackColor = true;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // customers_button
            // 
            this.customers_button.Location = new System.Drawing.Point(83, 147);
            this.customers_button.Name = "customers_button";
            this.customers_button.Size = new System.Drawing.Size(76, 26);
            this.customers_button.TabIndex = 2;
            this.customers_button.Text = "Collectibles";
            this.customers_button.UseVisualStyleBackColor = true;
            this.customers_button.Click += new System.EventHandler(this.customers_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 269);
            this.Controls.Add(this.customers_button);
            this.Controls.Add(this.sales_button);
            this.Controls.Add(this.inventory_button);
            this.MaximumSize = new System.Drawing.Size(452, 308);
            this.MinimumSize = new System.Drawing.Size(452, 308);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3FS System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Button customers_button;
    }
}