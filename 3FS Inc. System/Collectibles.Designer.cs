namespace _3FS_System
{
    partial class Collectibles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.remainingtextbox = new System.Windows.Forms.TextBox();
            this.remaininglabel = new System.Windows.Forms.Label();
            this.searchCustomerTextbox = new System.Windows.Forms.TextBox();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.datetimeLabel = new System.Windows.Forms.Label();
            this.dataGridReceipts = new System.Windows.Forms.DataGridView();
            this.dataCollectiblesLog = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalorderstextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalpaymentstextbox = new System.Windows.Forms.TextBox();
            this.totalpaymentslabel = new System.Windows.Forms.Label();
            this.paidButton = new System.Windows.Forms.Button();
            this.amountText = new System.Windows.Forms.TextBox();
            this.paymentsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridReceiptDetails = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectiblesLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceiptDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.remainingtextbox);
            this.panel3.Controls.Add(this.remaininglabel);
            this.panel3.Controls.Add(this.searchCustomerTextbox);
            this.panel3.Controls.Add(this.dataGridCustomers);
            this.panel3.Controls.Add(this.customerLabel);
            this.panel3.Controls.Add(this.datetimeLabel);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 293);
            this.panel3.TabIndex = 58;
            // 
            // remainingtextbox
            // 
            this.remainingtextbox.BackColor = System.Drawing.Color.White;
            this.remainingtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingtextbox.ForeColor = System.Drawing.Color.Black;
            this.remainingtextbox.Location = new System.Drawing.Point(188, 237);
            this.remainingtextbox.Name = "remainingtextbox";
            this.remainingtextbox.ReadOnly = true;
            this.remainingtextbox.Size = new System.Drawing.Size(322, 29);
            this.remainingtextbox.TabIndex = 64;
            // 
            // remaininglabel
            // 
            this.remaininglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaininglabel.ForeColor = System.Drawing.Color.Gold;
            this.remaininglabel.Location = new System.Drawing.Point(109, 240);
            this.remaininglabel.Name = "remaininglabel";
            this.remaininglabel.Size = new System.Drawing.Size(90, 24);
            this.remaininglabel.TabIndex = 64;
            this.remaininglabel.Text = "Balance:";
            // 
            // searchCustomerTextbox
            // 
            this.searchCustomerTextbox.BackColor = System.Drawing.Color.White;
            this.searchCustomerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchCustomerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerTextbox.ForeColor = System.Drawing.Color.Black;
            this.searchCustomerTextbox.Location = new System.Drawing.Point(109, 43);
            this.searchCustomerTextbox.Name = "searchCustomerTextbox";
            this.searchCustomerTextbox.Size = new System.Drawing.Size(401, 29);
            this.searchCustomerTextbox.TabIndex = 51;
            this.searchCustomerTextbox.TextChanged += new System.EventHandler(this.searchCustomerTextbox_TextChanged);
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToResizeColumns = false;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomers.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridCustomers.Location = new System.Drawing.Point(13, 78);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridCustomers.Size = new System.Drawing.Size(497, 145);
            this.dataGridCustomers.StandardTab = true;
            this.dataGridCustomers.TabIndex = 49;
            this.dataGridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellClick);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.Gold;
            this.customerLabel.Location = new System.Drawing.Point(9, 48);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(82, 20);
            this.customerLabel.TabIndex = 50;
            this.customerLabel.Text = "Customer:";
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datetimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeLabel.ForeColor = System.Drawing.Color.Gold;
            this.datetimeLabel.Location = new System.Drawing.Point(51, 16);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(337, 29);
            this.datetimeLabel.TabIndex = 52;
            this.datetimeLabel.Text = "datetimenow";
            this.datetimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridReceipts
            // 
            this.dataGridReceipts.AllowUserToAddRows = false;
            this.dataGridReceipts.AllowUserToDeleteRows = false;
            this.dataGridReceipts.AllowUserToResizeColumns = false;
            this.dataGridReceipts.AllowUserToResizeRows = false;
            this.dataGridReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceipts.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceipts.Location = new System.Drawing.Point(10, 39);
            this.dataGridReceipts.Name = "dataGridReceipts";
            this.dataGridReceipts.ReadOnly = true;
            this.dataGridReceipts.RowHeadersVisible = false;
            this.dataGridReceipts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridReceipts.Size = new System.Drawing.Size(348, 253);
            this.dataGridReceipts.TabIndex = 53;
            this.dataGridReceipts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReceipts_CellClick);
            this.dataGridReceipts.SelectionChanged += new System.EventHandler(this.dataGridReceipts_SelectionChanged);
            // 
            // dataCollectiblesLog
            // 
            this.dataCollectiblesLog.AllowUserToAddRows = false;
            this.dataCollectiblesLog.AllowUserToDeleteRows = false;
            this.dataCollectiblesLog.AllowUserToOrderColumns = true;
            this.dataCollectiblesLog.AllowUserToResizeColumns = false;
            this.dataCollectiblesLog.AllowUserToResizeRows = false;
            this.dataCollectiblesLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCollectiblesLog.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataCollectiblesLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCollectiblesLog.Location = new System.Drawing.Point(9, 38);
            this.dataCollectiblesLog.Name = "dataCollectiblesLog";
            this.dataCollectiblesLog.ReadOnly = true;
            this.dataCollectiblesLog.RowHeadersVisible = false;
            this.dataCollectiblesLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataCollectiblesLog.Size = new System.Drawing.Size(464, 185);
            this.dataCollectiblesLog.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalorderstextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ordersLabel);
            this.panel1.Controls.Add(this.dataGridReceipts);
            this.panel1.Location = new System.Drawing.Point(12, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 302);
            this.panel1.TabIndex = 60;
            // 
            // totalorderstextbox
            // 
            this.totalorderstextbox.BackColor = System.Drawing.Color.White;
            this.totalorderstextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalorderstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalorderstextbox.ForeColor = System.Drawing.Color.Black;
            this.totalorderstextbox.Location = new System.Drawing.Point(369, 67);
            this.totalorderstextbox.Name = "totalorderstextbox";
            this.totalorderstextbox.ReadOnly = true;
            this.totalorderstextbox.Size = new System.Drawing.Size(126, 29);
            this.totalorderstextbox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(364, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Total Orders:";
            // 
            // ordersLabel
            // 
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.Color.Gold;
            this.ordersLabel.Location = new System.Drawing.Point(3, 6);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(161, 25);
            this.ordersLabel.TabIndex = 53;
            this.ordersLabel.Text = "Order History:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalpaymentstextbox);
            this.panel2.Controls.Add(this.totalpaymentslabel);
            this.panel2.Controls.Add(this.paidButton);
            this.panel2.Controls.Add(this.amountText);
            this.panel2.Controls.Add(this.paymentsLabel);
            this.panel2.Controls.Add(this.dataCollectiblesLog);
            this.panel2.Location = new System.Drawing.Point(550, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 293);
            this.panel2.TabIndex = 61;
            // 
            // totalpaymentstextbox
            // 
            this.totalpaymentstextbox.BackColor = System.Drawing.Color.White;
            this.totalpaymentstextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalpaymentstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentstextbox.ForeColor = System.Drawing.Color.Black;
            this.totalpaymentstextbox.Location = new System.Drawing.Point(263, 240);
            this.totalpaymentstextbox.Name = "totalpaymentstextbox";
            this.totalpaymentstextbox.ReadOnly = true;
            this.totalpaymentstextbox.Size = new System.Drawing.Size(210, 29);
            this.totalpaymentstextbox.TabIndex = 65;
            // 
            // totalpaymentslabel
            // 
            this.totalpaymentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentslabel.ForeColor = System.Drawing.Color.Gold;
            this.totalpaymentslabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalpaymentslabel.Location = new System.Drawing.Point(183, 241);
            this.totalpaymentslabel.Name = "totalpaymentslabel";
            this.totalpaymentslabel.Size = new System.Drawing.Size(74, 24);
            this.totalpaymentslabel.TabIndex = 66;
            this.totalpaymentslabel.Text = "Total:";
            // 
            // paidButton
            // 
            this.paidButton.BackColor = System.Drawing.Color.IndianRed;
            this.paidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidButton.ForeColor = System.Drawing.Color.Gold;
            this.paidButton.Location = new System.Drawing.Point(479, 78);
            this.paidButton.Name = "paidButton";
            this.paidButton.Size = new System.Drawing.Size(123, 30);
            this.paidButton.TabIndex = 63;
            this.paidButton.Text = "Paid";
            this.paidButton.UseVisualStyleBackColor = false;
            this.paidButton.Click += new System.EventHandler(this.paidButton_Click_1);
            // 
            // amountText
            // 
            this.amountText.BackColor = System.Drawing.Color.White;
            this.amountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountText.ForeColor = System.Drawing.Color.Black;
            this.amountText.Location = new System.Drawing.Point(479, 39);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(123, 29);
            this.amountText.TabIndex = 62;
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsLabel.ForeColor = System.Drawing.Color.Gold;
            this.paymentsLabel.Location = new System.Drawing.Point(3, 4);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(101, 25);
            this.paymentsLabel.TabIndex = 54;
            this.paymentsLabel.Text = "Payments";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1229, 624);
            this.panel4.TabIndex = 62;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dataGridReceiptDetails);
            this.panel5.Location = new System.Drawing.Point(550, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(607, 302);
            this.panel5.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Receipt Details:";
            // 
            // dataGridReceiptDetails
            // 
            this.dataGridReceiptDetails.AllowUserToAddRows = false;
            this.dataGridReceiptDetails.AllowUserToDeleteRows = false;
            this.dataGridReceiptDetails.AllowUserToOrderColumns = true;
            this.dataGridReceiptDetails.AllowUserToResizeColumns = false;
            this.dataGridReceiptDetails.AllowUserToResizeRows = false;
            this.dataGridReceiptDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceiptDetails.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceiptDetails.Location = new System.Drawing.Point(9, 38);
            this.dataGridReceiptDetails.Name = "dataGridReceiptDetails";
            this.dataGridReceiptDetails.ReadOnly = true;
            this.dataGridReceiptDetails.RowHeadersVisible = false;
            this.dataGridReceiptDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridReceiptDetails.Size = new System.Drawing.Size(593, 254);
            this.dataGridReceiptDetails.TabIndex = 59;
            // 
            // Collectibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1229, 624);
            this.Controls.Add(this.panel4);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Collectibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Collectibles";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectiblesLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceiptDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchCustomerTextbox;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label datetimeLabel;
        private System.Windows.Forms.DataGridView dataGridReceipts;
        private System.Windows.Forms.DataGridView dataCollectiblesLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label paymentsLabel;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Button paidButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox remainingtextbox;
        private System.Windows.Forms.Label remaininglabel;
        private System.Windows.Forms.TextBox totalpaymentstextbox;
        private System.Windows.Forms.Label totalpaymentslabel;
        private System.Windows.Forms.TextBox totalorderstextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridReceiptDetails;
        private System.Windows.Forms.Label receiptDetailslabel;
    }
}