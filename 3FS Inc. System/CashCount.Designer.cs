namespace _3FS_System
{
    partial class CashCount
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
            this.saveCashcount = new System.Windows.Forms.Button();
            this.ItemNameText = new System.Windows.Forms.TextBox();
            this.begcashlabel = new System.Windows.Forms.Label();
            this.incashlabel = new System.Windows.Forms.Label();
            this.paymentlabel = new System.Windows.Forms.Label();
            this.totalsaleslabel = new System.Windows.Forms.Label();
            this.expenseslabel = new System.Windows.Forms.Label();
            this.depositslabel = new System.Windows.Forms.Label();
            this.BrandNameText = new System.Windows.Forms.TextBox();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.UnitText = new System.Windows.Forms.TextBox();
            this.SRPText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveCashcount
            // 
            this.saveCashcount.Location = new System.Drawing.Point(101, 387);
            this.saveCashcount.Name = "saveCashcount";
            this.saveCashcount.Size = new System.Drawing.Size(60, 31);
            this.saveCashcount.TabIndex = 0;
            this.saveCashcount.Text = "&Save";
            this.saveCashcount.UseVisualStyleBackColor = true;
            this.saveCashcount.Click += new System.EventHandler(this.cashCountbutton_Click);
            // 
            // ItemNameText
            // 
            this.ItemNameText.BackColor = System.Drawing.Color.White;
            this.ItemNameText.ForeColor = System.Drawing.Color.Black;
            this.ItemNameText.Location = new System.Drawing.Point(97, 9);
            this.ItemNameText.Margin = new System.Windows.Forms.Padding(4);
            this.ItemNameText.Name = "ItemNameText";
            this.ItemNameText.Size = new System.Drawing.Size(132, 20);
            this.ItemNameText.TabIndex = 26;
            // 
            // begcashlabel
            // 
            this.begcashlabel.AutoSize = true;
            this.begcashlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.begcashlabel.Location = new System.Drawing.Point(5, 12);
            this.begcashlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.begcashlabel.Name = "begcashlabel";
            this.begcashlabel.Size = new System.Drawing.Size(84, 13);
            this.begcashlabel.TabIndex = 20;
            this.begcashlabel.Text = "Beginning Cash:";
            this.begcashlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // incashlabel
            // 
            this.incashlabel.AutoSize = true;
            this.incashlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.incashlabel.Location = new System.Drawing.Point(44, 39);
            this.incashlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incashlabel.Name = "incashlabel";
            this.incashlabel.Size = new System.Drawing.Size(45, 13);
            this.incashlabel.TabIndex = 21;
            this.incashlabel.Text = "In-cash:";
            this.incashlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentlabel
            // 
            this.paymentlabel.AutoSize = true;
            this.paymentlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paymentlabel.Location = new System.Drawing.Point(33, 66);
            this.paymentlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentlabel.Name = "paymentlabel";
            this.paymentlabel.Size = new System.Drawing.Size(56, 13);
            this.paymentlabel.TabIndex = 22;
            this.paymentlabel.Text = "Payments:";
            this.paymentlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalsaleslabel
            // 
            this.totalsaleslabel.AutoSize = true;
            this.totalsaleslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalsaleslabel.Location = new System.Drawing.Point(26, 93);
            this.totalsaleslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalsaleslabel.Name = "totalsaleslabel";
            this.totalsaleslabel.Size = new System.Drawing.Size(63, 13);
            this.totalsaleslabel.TabIndex = 23;
            this.totalsaleslabel.Text = "Total Sales:";
            this.totalsaleslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // expenseslabel
            // 
            this.expenseslabel.AutoSize = true;
            this.expenseslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expenseslabel.Location = new System.Drawing.Point(33, 12);
            this.expenseslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.expenseslabel.Name = "expenseslabel";
            this.expenseslabel.Size = new System.Drawing.Size(56, 13);
            this.expenseslabel.TabIndex = 24;
            this.expenseslabel.Text = "Expenses:";
            this.expenseslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depositslabel
            // 
            this.depositslabel.AutoSize = true;
            this.depositslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depositslabel.Location = new System.Drawing.Point(38, 39);
            this.depositslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositslabel.Name = "depositslabel";
            this.depositslabel.Size = new System.Drawing.Size(51, 13);
            this.depositslabel.TabIndex = 25;
            this.depositslabel.Text = "Deposits:";
            this.depositslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrandNameText
            // 
            this.BrandNameText.BackColor = System.Drawing.Color.White;
            this.BrandNameText.ForeColor = System.Drawing.Color.Black;
            this.BrandNameText.Location = new System.Drawing.Point(97, 36);
            this.BrandNameText.Margin = new System.Windows.Forms.Padding(4);
            this.BrandNameText.Name = "BrandNameText";
            this.BrandNameText.Size = new System.Drawing.Size(132, 20);
            this.BrandNameText.TabIndex = 27;
            // 
            // CategoryText
            // 
            this.CategoryText.BackColor = System.Drawing.Color.White;
            this.CategoryText.ForeColor = System.Drawing.Color.Black;
            this.CategoryText.Location = new System.Drawing.Point(97, 63);
            this.CategoryText.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(132, 20);
            this.CategoryText.TabIndex = 28;
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor = System.Drawing.Color.White;
            this.QuantityText.ForeColor = System.Drawing.Color.Black;
            this.QuantityText.Location = new System.Drawing.Point(97, 90);
            this.QuantityText.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(132, 20);
            this.QuantityText.TabIndex = 29;
            // 
            // UnitText
            // 
            this.UnitText.BackColor = System.Drawing.Color.White;
            this.UnitText.ForeColor = System.Drawing.Color.Black;
            this.UnitText.Location = new System.Drawing.Point(97, 9);
            this.UnitText.Margin = new System.Windows.Forms.Padding(4);
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(132, 20);
            this.UnitText.TabIndex = 31;
            // 
            // SRPText
            // 
            this.SRPText.BackColor = System.Drawing.Color.White;
            this.SRPText.ForeColor = System.Drawing.Color.Black;
            this.SRPText.Location = new System.Drawing.Point(97, 36);
            this.SRPText.Margin = new System.Windows.Forms.Padding(4);
            this.SRPText.Name = "SRPText";
            this.SRPText.Size = new System.Drawing.Size(132, 20);
            this.SRPText.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ItemNameText);
            this.panel1.Controls.Add(this.begcashlabel);
            this.panel1.Controls.Add(this.incashlabel);
            this.panel1.Controls.Add(this.paymentlabel);
            this.panel1.Controls.Add(this.QuantityText);
            this.panel1.Controls.Add(this.totalsaleslabel);
            this.panel1.Controls.Add(this.CategoryText);
            this.panel1.Controls.Add(this.BrandNameText);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 148);
            this.panel1.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(97, 117);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sub-Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(97, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sub-Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.UnitText);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.SRPText);
            this.panel2.Controls.Add(this.expenseslabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.depositslabel);
            this.panel2.Location = new System.Drawing.Point(12, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 96);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 104);
            this.panel3.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(97, 39);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(97, 68);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 20);
            this.textBox5.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Remaining Cash:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(31, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Computed:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(49, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Actual:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 432);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveCashcount);
            this.Name = "CashCount";
            this.Text = "Cash Count";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveCashcount;
        private System.Windows.Forms.TextBox ItemNameText;
        private System.Windows.Forms.Label begcashlabel;
        private System.Windows.Forms.Label incashlabel;
        private System.Windows.Forms.Label paymentlabel;
        private System.Windows.Forms.Label totalsaleslabel;
        private System.Windows.Forms.Label expenseslabel;
        private System.Windows.Forms.Label depositslabel;
        private System.Windows.Forms.TextBox BrandNameText;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.TextBox UnitText;
        private System.Windows.Forms.TextBox SRPText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}