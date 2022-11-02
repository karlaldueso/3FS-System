namespace _3FS_System
{
    partial class Receipts
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
            this.dataGridReceipts = new System.Windows.Forms.DataGridView();
            this.dataGridReceiptDetails = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceiptDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReceipts
            // 
            this.dataGridReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceipts.Location = new System.Drawing.Point(25, 48);
            this.dataGridReceipts.Name = "dataGridReceipts";
            this.dataGridReceipts.RowHeadersVisible = false;
            this.dataGridReceipts.Size = new System.Drawing.Size(385, 252);
            this.dataGridReceipts.TabIndex = 0;
            this.dataGridReceipts.SelectionChanged += new System.EventHandler(this.dataGridReceipts_SelectionChanged);
            // 
            // dataGridReceiptDetails
            // 
            this.dataGridReceiptDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceiptDetails.Location = new System.Drawing.Point(440, 48);
            this.dataGridReceiptDetails.Name = "dataGridReceiptDetails";
            this.dataGridReceiptDetails.RowHeadersVisible = false;
            this.dataGridReceiptDetails.Size = new System.Drawing.Size(398, 252);
            this.dataGridReceiptDetails.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 329);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridReceiptDetails);
            this.Controls.Add(this.dataGridReceipts);
            this.Name = "Receipts";
            this.Text = "Receipts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceiptDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReceipts;
        private System.Windows.Forms.DataGridView dataGridReceiptDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}