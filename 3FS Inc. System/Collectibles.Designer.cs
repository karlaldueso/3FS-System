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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCollectiblesLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(16, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 248);
            this.panel3.TabIndex = 58;
            // 
            // remainingtextbox
            // 
            this.remainingtextbox.BackColor = System.Drawing.Color.Maroon;
            this.remainingtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingtextbox.ForeColor = System.Drawing.Color.Yellow;
            this.remainingtextbox.Location = new System.Drawing.Point(173, 201);
            this.remainingtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remainingtextbox.Name = "remainingtextbox";
            this.remainingtextbox.ReadOnly = true;
            this.remainingtextbox.Size = new System.Drawing.Size(129, 34);
            this.remainingtextbox.TabIndex = 64;
            // 
            // remaininglabel
            // 
            this.remaininglabel.AutoSize = true;
            this.remaininglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaininglabel.ForeColor = System.Drawing.Color.Gold;
            this.remaininglabel.Location = new System.Drawing.Point(24, 202);
            this.remaininglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.remaininglabel.Name = "remaininglabel";
            this.remaininglabel.Size = new System.Drawing.Size(130, 36);
            this.remaininglabel.TabIndex = 64;
            this.remaininglabel.Text = "Balance:";
            // 
            // searchCustomerTextbox
            // 
            this.searchCustomerTextbox.BackColor = System.Drawing.Color.Maroon;
            this.searchCustomerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchCustomerTextbox.ForeColor = System.Drawing.Color.Yellow;
            this.searchCustomerTextbox.Location = new System.Drawing.Point(80, 32);
            this.searchCustomerTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchCustomerTextbox.Name = "searchCustomerTextbox";
            this.searchCustomerTextbox.Size = new System.Drawing.Size(188, 34);
            this.searchCustomerTextbox.TabIndex = 51;
            this.searchCustomerTextbox.TextChanged += new System.EventHandler(this.searchCustomerTextbox_TextChanged);
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToResizeColumns = false;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Location = new System.Drawing.Point(12, 75);
            this.dataGridCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.RowHeadersWidth = 51;
            this.dataGridCustomers.Size = new System.Drawing.Size(292, 118);
            this.dataGridCustomers.TabIndex = 49;
            this.dataGridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_CellClick);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.ForeColor = System.Drawing.Color.Gold;
            this.customerLabel.Location = new System.Drawing.Point(4, 42);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(67, 16);
            this.customerLabel.TabIndex = 50;
            this.customerLabel.Text = "Customer:";
            // 
            // datetimeLabel
            // 
            this.datetimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeLabel.ForeColor = System.Drawing.Color.Gold;
            this.datetimeLabel.Location = new System.Drawing.Point(8, 5);
            this.datetimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datetimeLabel.Name = "datetimeLabel";
            this.datetimeLabel.Size = new System.Drawing.Size(261, 23);
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
            this.dataGridReceipts.Location = new System.Drawing.Point(13, 48);
            this.dataGridReceipts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridReceipts.Name = "dataGridReceipts";
            this.dataGridReceipts.ReadOnly = true;
            this.dataGridReceipts.RowHeadersVisible = false;
            this.dataGridReceipts.RowHeadersWidth = 51;
            this.dataGridReceipts.Size = new System.Drawing.Size(497, 186);
            this.dataGridReceipts.TabIndex = 53;
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
            this.dataCollectiblesLog.Location = new System.Drawing.Point(4, 47);
            this.dataCollectiblesLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCollectiblesLog.Name = "dataCollectiblesLog";
            this.dataCollectiblesLog.ReadOnly = true;
            this.dataCollectiblesLog.RowHeadersVisible = false;
            this.dataCollectiblesLog.RowHeadersWidth = 51;
            this.dataCollectiblesLog.Size = new System.Drawing.Size(275, 146);
            this.dataCollectiblesLog.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalorderstextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ordersLabel);
            this.panel1.Controls.Add(this.dataGridReceipts);
            this.panel1.Location = new System.Drawing.Point(16, 272);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 247);
            this.panel1.TabIndex = 60;
            // 
            // totalorderstextbox
            // 
            this.totalorderstextbox.BackColor = System.Drawing.Color.Maroon;
            this.totalorderstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalorderstextbox.ForeColor = System.Drawing.Color.Yellow;
            this.totalorderstextbox.Location = new System.Drawing.Point(533, 89);
            this.totalorderstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalorderstextbox.Name = "totalorderstextbox";
            this.totalorderstextbox.ReadOnly = true;
            this.totalorderstextbox.Size = new System.Drawing.Size(160, 34);
            this.totalorderstextbox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(527, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 36);
            this.label1.TabIndex = 67;
            this.label1.Text = "Total:";
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.Color.Gold;
            this.ordersLabel.Location = new System.Drawing.Point(4, 7);
            this.ordersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(120, 39);
            this.ordersLabel.TabIndex = 53;
            this.ordersLabel.Text = "Orders";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalpaymentstextbox);
            this.panel2.Controls.Add(this.totalpaymentslabel);
            this.panel2.Controls.Add(this.paidButton);
            this.panel2.Controls.Add(this.amountText);
            this.panel2.Controls.Add(this.paymentsLabel);
            this.panel2.Controls.Add(this.dataCollectiblesLog);
            this.panel2.Location = new System.Drawing.Point(336, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 248);
            this.panel2.TabIndex = 61;
            // 
            // totalpaymentstextbox
            // 
            this.totalpaymentstextbox.BackColor = System.Drawing.Color.Maroon;
            this.totalpaymentstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentstextbox.ForeColor = System.Drawing.Color.Yellow;
            this.totalpaymentstextbox.Location = new System.Drawing.Point(112, 202);
            this.totalpaymentstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalpaymentstextbox.Name = "totalpaymentstextbox";
            this.totalpaymentstextbox.ReadOnly = true;
            this.totalpaymentstextbox.Size = new System.Drawing.Size(160, 34);
            this.totalpaymentstextbox.TabIndex = 65;
            // 
            // totalpaymentslabel
            // 
            this.totalpaymentslabel.AutoSize = true;
            this.totalpaymentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentslabel.ForeColor = System.Drawing.Color.Gold;
            this.totalpaymentslabel.Location = new System.Drawing.Point(5, 202);
            this.totalpaymentslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalpaymentslabel.Name = "totalpaymentslabel";
            this.totalpaymentslabel.Size = new System.Drawing.Size(89, 36);
            this.totalpaymentslabel.TabIndex = 66;
            this.totalpaymentslabel.Text = "Total:";
            // 
            // paidButton
            // 
            this.paidButton.BackColor = System.Drawing.Color.IndianRed;
            this.paidButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paidButton.ForeColor = System.Drawing.Color.Gold;
            this.paidButton.Location = new System.Drawing.Point(287, 79);
            this.paidButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paidButton.Name = "paidButton";
            this.paidButton.Size = new System.Drawing.Size(100, 28);
            this.paidButton.TabIndex = 63;
            this.paidButton.Text = "Paid";
            this.paidButton.UseVisualStyleBackColor = false;
            this.paidButton.Click += new System.EventHandler(this.paidButton_Click_1);
            // 
            // amountText
            // 
            this.amountText.BackColor = System.Drawing.Color.Maroon;
            this.amountText.ForeColor = System.Drawing.Color.Yellow;
            this.amountText.Location = new System.Drawing.Point(287, 47);
            this.amountText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(108, 22);
            this.amountText.TabIndex = 62;
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.AutoSize = true;
            this.paymentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsLabel.ForeColor = System.Drawing.Color.Gold;
            this.paymentsLabel.Location = new System.Drawing.Point(4, 5);
            this.paymentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentsLabel.Name = "paymentsLabel";
            this.paymentsLabel.Size = new System.Drawing.Size(168, 39);
            this.paymentsLabel.TabIndex = 54;
            this.paymentsLabel.Text = "Payments";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Collectibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(753, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Collectibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
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
    }
}