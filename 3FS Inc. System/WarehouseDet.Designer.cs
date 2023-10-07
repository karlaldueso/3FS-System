namespace _3FS_System
{
    partial class WarehouseDet
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
            this.searchpanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.namesearchlabel = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.dataGridWarehouse = new System.Windows.Forms.DataGridView();
            this.CityText = new System.Windows.Forms.TextBox();
            this.searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // searchpanel
            // 
            this.searchpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchpanel.Controls.Add(this.CityText);
            this.searchpanel.Controls.Add(this.addButton);
            this.searchpanel.Controls.Add(this.label3);
            this.searchpanel.Controls.Add(this.AddressText);
            this.searchpanel.Controls.Add(this.quantityLabel);
            this.searchpanel.Controls.Add(this.NameText);
            this.searchpanel.Controls.Add(this.namesearchlabel);
            this.searchpanel.Controls.Add(this.DescriptionText);
            this.searchpanel.Controls.Add(this.label11);
            this.searchpanel.Controls.Add(this.brandlabel);
            this.searchpanel.Location = new System.Drawing.Point(13, 13);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(235, 218);
            this.searchpanel.TabIndex = 41;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(81, 174);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "City:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.White;
            this.AddressText.ForeColor = System.Drawing.Color.Black;
            this.AddressText.Location = new System.Drawing.Point(81, 119);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(132, 20);
            this.AddressText.TabIndex = 33;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantityLabel.Location = new System.Drawing.Point(26, 119);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(48, 13);
            this.quantityLabel.TabIndex = 34;
            this.quantityLabel.Text = "Address:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.White;
            this.NameText.ForeColor = System.Drawing.Color.Black;
            this.NameText.Location = new System.Drawing.Point(81, 37);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(132, 20);
            this.NameText.TabIndex = 28;
            // 
            // namesearchlabel
            // 
            this.namesearchlabel.AutoSize = true;
            this.namesearchlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namesearchlabel.Location = new System.Drawing.Point(36, 37);
            this.namesearchlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namesearchlabel.Name = "namesearchlabel";
            this.namesearchlabel.Size = new System.Drawing.Size(38, 13);
            this.namesearchlabel.TabIndex = 29;
            this.namesearchlabel.Text = "Name:";
            this.namesearchlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.Color.White;
            this.DescriptionText.ForeColor = System.Drawing.Color.Black;
            this.DescriptionText.Location = new System.Drawing.Point(81, 65);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(132, 46);
            this.DescriptionText.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Add Item to Warehouse";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brandlabel.Location = new System.Drawing.Point(11, 65);
            this.brandlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(63, 13);
            this.brandlabel.TabIndex = 31;
            this.brandlabel.Text = "Description:";
            this.brandlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridWarehouse
            // 
            this.dataGridWarehouse.AllowUserToAddRows = false;
            this.dataGridWarehouse.AllowUserToDeleteRows = false;
            this.dataGridWarehouse.AllowUserToResizeRows = false;
            this.dataGridWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWarehouse.BackgroundColor = System.Drawing.Color.White;
            this.dataGridWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouse.Location = new System.Drawing.Point(256, 13);
            this.dataGridWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridWarehouse.MultiSelect = false;
            this.dataGridWarehouse.Name = "dataGridWarehouse";
            this.dataGridWarehouse.ReadOnly = true;
            this.dataGridWarehouse.RowHeadersVisible = false;
            this.dataGridWarehouse.RowHeadersWidth = 51;
            this.dataGridWarehouse.Size = new System.Drawing.Size(442, 218);
            this.dataGridWarehouse.TabIndex = 47;
            // 
            // CityText
            // 
            this.CityText.BackColor = System.Drawing.Color.White;
            this.CityText.ForeColor = System.Drawing.Color.Black;
            this.CityText.Location = new System.Drawing.Point(81, 147);
            this.CityText.Margin = new System.Windows.Forms.Padding(4);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(132, 20);
            this.CityText.TabIndex = 38;
            // 
            // WarehouseDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 238);
            this.Controls.Add(this.dataGridWarehouse);
            this.Controls.Add(this.searchpanel);
            this.MaximumSize = new System.Drawing.Size(721, 277);
            this.MinimumSize = new System.Drawing.Size(721, 277);
            this.Name = "WarehouseDet";
            this.Text = "WarehouseDet";
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label namesearchlabel;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.DataGridView dataGridWarehouse;
        private System.Windows.Forms.TextBox CityText;
    }
}