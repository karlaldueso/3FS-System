namespace _3FS_System
{
    partial class Warehouses
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
            this.dataGridWarehouse1 = new System.Windows.Forms.DataGridView();
            this.searchpanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.storageComboBox = new System.Windows.Forms.ComboBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.searchName = new System.Windows.Forms.TextBox();
            this.namesearchlabel = new System.Windows.Forms.Label();
            this.searchBrandName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.storagecombobox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridWarehouse2 = new System.Windows.Forms.DataGridView();
            this.storagecombobox2 = new System.Windows.Forms.ComboBox();
            this.movebutton1 = new System.Windows.Forms.Button();
            this.movebutton2 = new System.Windows.Forms.Button();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.inventorylabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchNameMove = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchBrandNameMove = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.movequantityText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse1)).BeginInit();
            this.searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridWarehouse1
            // 
            this.dataGridWarehouse1.AllowUserToAddRows = false;
            this.dataGridWarehouse1.AllowUserToDeleteRows = false;
            this.dataGridWarehouse1.AllowUserToResizeRows = false;
            this.dataGridWarehouse1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWarehouse1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridWarehouse1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouse1.Location = new System.Drawing.Point(247, 33);
            this.dataGridWarehouse1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridWarehouse1.MultiSelect = false;
            this.dataGridWarehouse1.Name = "dataGridWarehouse1";
            this.dataGridWarehouse1.ReadOnly = true;
            this.dataGridWarehouse1.RowHeadersVisible = false;
            this.dataGridWarehouse1.RowHeadersWidth = 51;
            this.dataGridWarehouse1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouse1.Size = new System.Drawing.Size(299, 151);
            this.dataGridWarehouse1.TabIndex = 39;
            // 
            // searchpanel
            // 
            this.searchpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchpanel.Controls.Add(this.addButton);
            this.searchpanel.Controls.Add(this.label3);
            this.searchpanel.Controls.Add(this.storageComboBox);
            this.searchpanel.Controls.Add(this.quantityText);
            this.searchpanel.Controls.Add(this.quantityLabel);
            this.searchpanel.Controls.Add(this.searchName);
            this.searchpanel.Controls.Add(this.namesearchlabel);
            this.searchpanel.Controls.Add(this.searchBrandName);
            this.searchpanel.Controls.Add(this.label11);
            this.searchpanel.Controls.Add(this.brandlabel);
            this.searchpanel.Location = new System.Drawing.Point(4, 4);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(235, 177);
            this.searchpanel.TabIndex = 40;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(81, 147);
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
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Storage:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // storageComboBox
            // 
            this.storageComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.storageComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.storageComboBox.DisplayMember = "1";
            this.storageComboBox.FormattingEnabled = true;
            this.storageComboBox.Location = new System.Drawing.Point(81, 120);
            this.storageComboBox.Name = "storageComboBox";
            this.storageComboBox.Size = new System.Drawing.Size(132, 21);
            this.storageComboBox.TabIndex = 36;
            this.storageComboBox.DropDown += new System.EventHandler(this.storageComboBox_DropDown);
            this.storageComboBox.SelectionChangeCommitted += new System.EventHandler(this.storageComboBox_SelectionChangeCommitted);
            this.storageComboBox.Enter += new System.EventHandler(this.storageComboBox_Enter);
            // 
            // quantityText
            // 
            this.quantityText.BackColor = System.Drawing.Color.White;
            this.quantityText.ForeColor = System.Drawing.Color.Black;
            this.quantityText.Location = new System.Drawing.Point(81, 93);
            this.quantityText.Margin = new System.Windows.Forms.Padding(4);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(132, 20);
            this.quantityText.TabIndex = 33;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantityLabel.Location = new System.Drawing.Point(24, 93);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 34;
            this.quantityLabel.Text = "Quantity:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.White;
            this.searchName.ForeColor = System.Drawing.Color.Black;
            this.searchName.Location = new System.Drawing.Point(81, 37);
            this.searchName.Margin = new System.Windows.Forms.Padding(4);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(132, 20);
            this.searchName.TabIndex = 28;
            this.searchName.TextChanged += new System.EventHandler(this.searchName_TextChanged);
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
            // searchBrandName
            // 
            this.searchBrandName.BackColor = System.Drawing.Color.White;
            this.searchBrandName.ForeColor = System.Drawing.Color.Black;
            this.searchBrandName.Location = new System.Drawing.Point(81, 65);
            this.searchBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.searchBrandName.Name = "searchBrandName";
            this.searchBrandName.Size = new System.Drawing.Size(132, 20);
            this.searchBrandName.TabIndex = 30;
            this.searchBrandName.TextChanged += new System.EventHandler(this.searchBrandName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Add to Warehouse";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brandlabel.Location = new System.Drawing.Point(4, 65);
            this.brandlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(69, 13);
            this.brandlabel.TabIndex = 31;
            this.brandlabel.Text = "Brand Name:";
            this.brandlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(247, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Storage:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // storagecombobox1
            // 
            this.storagecombobox1.FormattingEnabled = true;
            this.storagecombobox1.Location = new System.Drawing.Point(301, 5);
            this.storagecombobox1.Name = "storagecombobox1";
            this.storagecombobox1.Size = new System.Drawing.Size(132, 21);
            this.storagecombobox1.TabIndex = 33;
            this.storagecombobox1.SelectionChangeCommitted += new System.EventHandler(this.storagecombobox1_SelectionChangeCommitted);
            this.storagecombobox1.Click += new System.EventHandler(this.storagecombobox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(628, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Storage:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridWarehouse2
            // 
            this.dataGridWarehouse2.AllowUserToAddRows = false;
            this.dataGridWarehouse2.AllowUserToDeleteRows = false;
            this.dataGridWarehouse2.AllowUserToResizeRows = false;
            this.dataGridWarehouse2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWarehouse2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridWarehouse2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWarehouse2.Location = new System.Drawing.Point(627, 33);
            this.dataGridWarehouse2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridWarehouse2.MultiSelect = false;
            this.dataGridWarehouse2.Name = "dataGridWarehouse2";
            this.dataGridWarehouse2.ReadOnly = true;
            this.dataGridWarehouse2.RowHeadersVisible = false;
            this.dataGridWarehouse2.RowHeadersWidth = 51;
            this.dataGridWarehouse2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWarehouse2.Size = new System.Drawing.Size(299, 151);
            this.dataGridWarehouse2.TabIndex = 43;
            // 
            // storagecombobox2
            // 
            this.storagecombobox2.FormattingEnabled = true;
            this.storagecombobox2.Location = new System.Drawing.Point(682, 5);
            this.storagecombobox2.Name = "storagecombobox2";
            this.storagecombobox2.Size = new System.Drawing.Size(132, 21);
            this.storagecombobox2.TabIndex = 42;
            this.storagecombobox2.SelectionChangeCommitted += new System.EventHandler(this.storagecombobox2_SelectionChangeCommitted);
            this.storagecombobox2.Click += new System.EventHandler(this.storagecombobox2_Click);
            // 
            // movebutton1
            // 
            this.movebutton1.Location = new System.Drawing.Point(559, 94);
            this.movebutton1.Name = "movebutton1";
            this.movebutton1.Size = new System.Drawing.Size(54, 23);
            this.movebutton1.TabIndex = 44;
            this.movebutton1.Text = ">>";
            this.movebutton1.UseVisualStyleBackColor = true;
            this.movebutton1.Click += new System.EventHandler(this.movebutton1_Click);
            // 
            // movebutton2
            // 
            this.movebutton2.Location = new System.Drawing.Point(559, 133);
            this.movebutton2.Name = "movebutton2";
            this.movebutton2.Size = new System.Drawing.Size(54, 23);
            this.movebutton2.TabIndex = 45;
            this.movebutton2.Text = "<<";
            this.movebutton2.UseVisualStyleBackColor = true;
            this.movebutton2.Click += new System.EventHandler(this.movebutton2_Click);
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AllowUserToAddRows = false;
            this.dataGridInventory.AllowUserToDeleteRows = false;
            this.dataGridInventory.AllowUserToResizeRows = false;
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(247, 28);
            this.dataGridInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInventory.MultiSelect = false;
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.ReadOnly = true;
            this.dataGridInventory.RowHeadersVisible = false;
            this.dataGridInventory.RowHeadersWidth = 51;
            this.dataGridInventory.Size = new System.Drawing.Size(679, 153);
            this.dataGridInventory.TabIndex = 46;
            // 
            // inventorylabel
            // 
            this.inventorylabel.AutoSize = true;
            this.inventorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorylabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inventorylabel.Location = new System.Drawing.Point(247, 3);
            this.inventorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(59, 24);
            this.inventorylabel.TabIndex = 47;
            this.inventorylabel.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchNameMove);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.searchBrandNameMove);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(4, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 112);
            this.panel1.TabIndex = 48;
            // 
            // searchNameMove
            // 
            this.searchNameMove.BackColor = System.Drawing.Color.White;
            this.searchNameMove.ForeColor = System.Drawing.Color.Black;
            this.searchNameMove.Location = new System.Drawing.Point(81, 35);
            this.searchNameMove.Margin = new System.Windows.Forms.Padding(4);
            this.searchNameMove.Name = "searchNameMove";
            this.searchNameMove.Size = new System.Drawing.Size(132, 20);
            this.searchNameMove.TabIndex = 28;
            this.searchNameMove.TextChanged += new System.EventHandler(this.searchNameMove_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(43, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBrandNameMove
            // 
            this.searchBrandNameMove.BackColor = System.Drawing.Color.White;
            this.searchBrandNameMove.ForeColor = System.Drawing.Color.Black;
            this.searchBrandNameMove.Location = new System.Drawing.Point(81, 63);
            this.searchBrandNameMove.Margin = new System.Windows.Forms.Padding(4);
            this.searchBrandNameMove.Name = "searchBrandNameMove";
            this.searchBrandNameMove.Size = new System.Drawing.Size(132, 20);
            this.searchBrandNameMove.TabIndex = 30;
            this.searchBrandNameMove.TextChanged += new System.EventHandler(this.searchBrandNameMove_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Move Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Brand Name:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.searchpanel);
            this.panel2.Controls.Add(this.dataGridInventory);
            this.panel2.Controls.Add(this.inventorylabel);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 188);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.movequantityText);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dataGridWarehouse1);
            this.panel3.Controls.Add(this.movebutton2);
            this.panel3.Controls.Add(this.storagecombobox1);
            this.panel3.Controls.Add(this.movebutton1);
            this.panel3.Controls.Add(this.dataGridWarehouse2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.storagecombobox2);
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 190);
            this.panel3.TabIndex = 50;
            // 
            // movequantityText
            // 
            this.movequantityText.BackColor = System.Drawing.Color.White;
            this.movequantityText.ForeColor = System.Drawing.Color.Black;
            this.movequantityText.Location = new System.Drawing.Point(559, 45);
            this.movequantityText.Margin = new System.Windows.Forms.Padding(4);
            this.movequantityText.Name = "movequantityText";
            this.movequantityText.Size = new System.Drawing.Size(54, 20);
            this.movequantityText.TabIndex = 33;
            // 
            // Warehouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 402);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Warehouses";
            this.Text = "Warehouses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse1)).EndInit();
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWarehouse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWarehouse1;
        private System.Windows.Forms.Panel searchpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox storagecombobox1;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Label namesearchlabel;
        private System.Windows.Forms.TextBox searchBrandName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridWarehouse2;
        private System.Windows.Forms.ComboBox storagecombobox2;
        private System.Windows.Forms.Button movebutton1;
        private System.Windows.Forms.Button movebutton2;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.Label inventorylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox storageComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchNameMove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchBrandNameMove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox movequantityText;
    }
}