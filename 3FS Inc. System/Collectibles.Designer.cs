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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.totalcredittextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel3.Size = new System.Drawing.Size(596, 293);
            this.panel3.TabIndex = 58;
            // 
            // remainingtextbox
            // 
            this.remainingtextbox.BackColor = System.Drawing.Color.White;
            this.remainingtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingtextbox.ForeColor = System.Drawing.Color.Black;
            this.remainingtextbox.Location = new System.Drawing.Point(351, 237);
            this.remainingtextbox.Name = "remainingtextbox";
            this.remainingtextbox.ReadOnly = true;
            this.remainingtextbox.Size = new System.Drawing.Size(240, 29);
            this.remainingtextbox.TabIndex = 64;
            // 
            // remaininglabel
            // 
            this.remaininglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaininglabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remaininglabel.Location = new System.Drawing.Point(255, 240);
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
            this.searchCustomerTextbox.Size = new System.Drawing.Size(482, 29);
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
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomers.Location = new System.Drawing.Point(13, 78);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersVisible = false;
            this.dataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridCustomers.Size = new System.Drawing.Size(578, 145);
            this.dataGridCustomers.StandardTab = true;
            this.dataGridCustomers.TabIndex = 49;
            this.dataGridCustomers.SelectionChanged += new System.EventHandler(this.dataGridCustomers_SelectionChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.datetimeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.dataGridReceipts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReceipts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReceipts.Location = new System.Drawing.Point(10, 39);
            this.dataGridReceipts.Name = "dataGridReceipts";
            this.dataGridReceipts.ReadOnly = true;
            this.dataGridReceipts.RowHeadersVisible = false;
            this.dataGridReceipts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridReceipts.Size = new System.Drawing.Size(581, 174);
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
            this.dataCollectiblesLog.BackgroundColor = System.Drawing.Color.White;
            this.dataCollectiblesLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCollectiblesLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCollectiblesLog.Location = new System.Drawing.Point(7, 38);
            this.dataCollectiblesLog.Name = "dataCollectiblesLog";
            this.dataCollectiblesLog.ReadOnly = true;
            this.dataCollectiblesLog.RowHeadersVisible = false;
            this.dataCollectiblesLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataCollectiblesLog.Size = new System.Drawing.Size(391, 185);
            this.dataCollectiblesLog.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalcredittextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalorderstextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ordersLabel);
            this.panel1.Controls.Add(this.dataGridReceipts);
            this.panel1.Location = new System.Drawing.Point(12, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 302);
            this.panel1.TabIndex = 60;
            // 
            // totalcredittextbox
            // 
            this.totalcredittextbox.BackColor = System.Drawing.Color.White;
            this.totalcredittextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalcredittextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcredittextbox.ForeColor = System.Drawing.Color.Black;
            this.totalcredittextbox.Location = new System.Drawing.Point(410, 228);
            this.totalcredittextbox.Name = "totalcredittextbox";
            this.totalcredittextbox.ReadOnly = true;
            this.totalcredittextbox.Size = new System.Drawing.Size(181, 29);
            this.totalcredittextbox.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(258, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Total Orders:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalorderstextbox
            // 
            this.totalorderstextbox.BackColor = System.Drawing.Color.White;
            this.totalorderstextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalorderstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalorderstextbox.ForeColor = System.Drawing.Color.Black;
            this.totalorderstextbox.Location = new System.Drawing.Point(410, 268);
            this.totalorderstextbox.Name = "totalorderstextbox";
            this.totalorderstextbox.ReadOnly = true;
            this.totalorderstextbox.Size = new System.Drawing.Size(181, 29);
            this.totalorderstextbox.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(258, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Total Credit:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ordersLabel
            // 
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.panel2.Location = new System.Drawing.Point(614, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 293);
            this.panel2.TabIndex = 61;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // totalpaymentstextbox
            // 
            this.totalpaymentstextbox.BackColor = System.Drawing.Color.White;
            this.totalpaymentstextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalpaymentstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentstextbox.ForeColor = System.Drawing.Color.Black;
            this.totalpaymentstextbox.Location = new System.Drawing.Point(188, 240);
            this.totalpaymentstextbox.Name = "totalpaymentstextbox";
            this.totalpaymentstextbox.ReadOnly = true;
            this.totalpaymentstextbox.Size = new System.Drawing.Size(210, 29);
            this.totalpaymentstextbox.TabIndex = 65;
            // 
            // totalpaymentslabel
            // 
            this.totalpaymentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpaymentslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalpaymentslabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalpaymentslabel.Location = new System.Drawing.Point(108, 241);
            this.totalpaymentslabel.Name = "totalpaymentslabel";
            this.totalpaymentslabel.Size = new System.Drawing.Size(74, 24);
            this.totalpaymentslabel.TabIndex = 66;
            this.totalpaymentslabel.Text = "Total:";
            // 
            // paidButton
            // 
            this.paidButton.BackColor = System.Drawing.Color.White;
            this.paidButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.paidButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidButton.ForeColor = System.Drawing.Color.Black;
            this.paidButton.Location = new System.Drawing.Point(404, 78);
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
            this.amountText.Location = new System.Drawing.Point(404, 39);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(123, 29);
            this.amountText.TabIndex = 62;
            // 
            // paymentsLabel
            // 
            this.paymentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paymentsLabel.Location = new System.Drawing.Point(2, 10);
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
            this.panel4.Size = new System.Drawing.Size(1168, 621);
            this.panel4.TabIndex = 62;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dataGridReceiptDetails);
            this.panel5.Location = new System.Drawing.Point(614, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(543, 302);
            this.panel5.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-2, 7);
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
            this.dataGridReceiptDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReceiptDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridReceiptDetails.Location = new System.Drawing.Point(3, 39);
            this.dataGridReceiptDetails.Name = "dataGridReceiptDetails";
            this.dataGridReceiptDetails.ReadOnly = true;
            this.dataGridReceiptDetails.RowHeadersVisible = false;
            this.dataGridReceiptDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridReceiptDetails.Size = new System.Drawing.Size(524, 254);
            this.dataGridReceiptDetails.TabIndex = 59;
            // 
            // Collectibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1168, 621);
            this.Controls.Add(this.panel4);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Collectibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Collectibles";
            this.Load += new System.EventHandler(this.Collectibles_Load);
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
        //private System.Windows.Forms.Label receiptDetailslabel;
        private System.Windows.Forms.TextBox totalcredittextbox;
        private System.Windows.Forms.Label label2;
    }
}