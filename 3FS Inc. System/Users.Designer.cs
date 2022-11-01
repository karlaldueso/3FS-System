namespace _3FS_System
{
    partial class Users
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.firstNametext = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.userTypelabel = new System.Windows.Forms.Label();
            this.userTypecombobox = new System.Windows.Forms.ComboBox();
            this.userslabel = new System.Windows.Forms.Label();
            this.PWtextbox2 = new System.Windows.Forms.TextBox();
            this.PWlabel1 = new System.Windows.Forms.Label();
            this.PWtextbox1 = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.contactNumberlabel = new System.Windows.Forms.Label();
            this.contacttext = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.lastNametext = new System.Windows.Forms.TextBox();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usersDataGrid);
            this.panel1.Location = new System.Drawing.Point(258, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 303);
            this.panel1.TabIndex = 0;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.RowHeadersWidth = 51;
            this.usersDataGrid.Size = new System.Drawing.Size(464, 297);
            this.usersDataGrid.TabIndex = 0;
            // 
            // firstNametext
            // 
            this.firstNametext.BackColor = System.Drawing.Color.Maroon;
            this.firstNametext.ForeColor = System.Drawing.Color.Yellow;
            this.firstNametext.Location = new System.Drawing.Point(108, 51);
            this.firstNametext.Name = "firstNametext";
            this.firstNametext.Size = new System.Drawing.Size(100, 20);
            this.firstNametext.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.AddItemButton);
            this.panel.Controls.Add(this.userTypelabel);
            this.panel.Controls.Add(this.userTypecombobox);
            this.panel.Controls.Add(this.userslabel);
            this.panel.Controls.Add(this.PWtextbox2);
            this.panel.Controls.Add(this.PWlabel1);
            this.panel.Controls.Add(this.PWtextbox1);
            this.panel.Controls.Add(this.usernamelabel);
            this.panel.Controls.Add(this.usernametext);
            this.panel.Controls.Add(this.contactNumberlabel);
            this.panel.Controls.Add(this.contacttext);
            this.panel.Controls.Add(this.lastNamelabel);
            this.panel.Controls.Add(this.lastNametext);
            this.panel.Controls.Add(this.firstNamelabel);
            this.panel.Controls.Add(this.firstNametext);
            this.panel.Location = new System.Drawing.Point(12, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(240, 297);
            this.panel.TabIndex = 2;
            // 
            // userTypelabel
            // 
            this.userTypelabel.AutoSize = true;
            this.userTypelabel.ForeColor = System.Drawing.Color.Gold;
            this.userTypelabel.Location = new System.Drawing.Point(43, 211);
            this.userTypelabel.Name = "userTypelabel";
            this.userTypelabel.Size = new System.Drawing.Size(59, 13);
            this.userTypelabel.TabIndex = 14;
            this.userTypelabel.Text = "User Type:";
            this.userTypelabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // userTypecombobox
            // 
            this.userTypecombobox.BackColor = System.Drawing.Color.Maroon;
            this.userTypecombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userTypecombobox.ForeColor = System.Drawing.Color.Gold;
            this.userTypecombobox.FormattingEnabled = true;
            this.userTypecombobox.Items.AddRange(new object[] {
            "Admin",
            "Encoder",
            "Sales"});
            this.userTypecombobox.Location = new System.Drawing.Point(108, 208);
            this.userTypecombobox.Name = "userTypecombobox";
            this.userTypecombobox.Size = new System.Drawing.Size(100, 21);
            this.userTypecombobox.TabIndex = 13;
            // 
            // userslabel
            // 
            this.userslabel.AutoSize = true;
            this.userslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userslabel.ForeColor = System.Drawing.Color.Gold;
            this.userslabel.Location = new System.Drawing.Point(33, 14);
            this.userslabel.Name = "userslabel";
            this.userslabel.Size = new System.Drawing.Size(175, 25);
            this.userslabel.TabIndex = 12;
            this.userslabel.Text = "User Information:";
            this.userslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PWtextbox2
            // 
            this.PWtextbox2.BackColor = System.Drawing.Color.Maroon;
            this.PWtextbox2.ForeColor = System.Drawing.Color.Yellow;
            this.PWtextbox2.Location = new System.Drawing.Point(108, 181);
            this.PWtextbox2.Name = "PWtextbox2";
            this.PWtextbox2.Size = new System.Drawing.Size(100, 20);
            this.PWtextbox2.TabIndex = 11;
            // 
            // PWlabel1
            // 
            this.PWlabel1.AutoSize = true;
            this.PWlabel1.ForeColor = System.Drawing.Color.Gold;
            this.PWlabel1.Location = new System.Drawing.Point(46, 158);
            this.PWlabel1.Name = "PWlabel1";
            this.PWlabel1.Size = new System.Drawing.Size(56, 13);
            this.PWlabel1.TabIndex = 10;
            this.PWlabel1.Text = "Password:";
            this.PWlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PWtextbox1
            // 
            this.PWtextbox1.BackColor = System.Drawing.Color.Maroon;
            this.PWtextbox1.ForeColor = System.Drawing.Color.Yellow;
            this.PWtextbox1.Location = new System.Drawing.Point(108, 155);
            this.PWtextbox1.Name = "PWtextbox1";
            this.PWtextbox1.Size = new System.Drawing.Size(100, 20);
            this.PWtextbox1.TabIndex = 9;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.ForeColor = System.Drawing.Color.Gold;
            this.usernamelabel.Location = new System.Drawing.Point(44, 132);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 13);
            this.usernamelabel.TabIndex = 8;
            this.usernamelabel.Text = "Username:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernametext
            // 
            this.usernametext.BackColor = System.Drawing.Color.Maroon;
            this.usernametext.ForeColor = System.Drawing.Color.Yellow;
            this.usernametext.Location = new System.Drawing.Point(108, 129);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(100, 20);
            this.usernametext.TabIndex = 7;
            // 
            // contactNumberlabel
            // 
            this.contactNumberlabel.AutoSize = true;
            this.contactNumberlabel.ForeColor = System.Drawing.Color.Gold;
            this.contactNumberlabel.Location = new System.Drawing.Point(45, 106);
            this.contactNumberlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumberlabel.Name = "contactNumberlabel";
            this.contactNumberlabel.Size = new System.Drawing.Size(57, 13);
            this.contactNumberlabel.TabIndex = 6;
            this.contactNumberlabel.Text = "Contact #:";
            this.contactNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contacttext
            // 
            this.contacttext.BackColor = System.Drawing.Color.Maroon;
            this.contacttext.ForeColor = System.Drawing.Color.Yellow;
            this.contacttext.Location = new System.Drawing.Point(108, 103);
            this.contacttext.Name = "contacttext";
            this.contacttext.Size = new System.Drawing.Size(100, 20);
            this.contacttext.TabIndex = 5;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.ForeColor = System.Drawing.Color.Gold;
            this.lastNamelabel.Location = new System.Drawing.Point(42, 80);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(61, 13);
            this.lastNamelabel.TabIndex = 4;
            this.lastNamelabel.Text = "Last Name:";
            this.lastNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNametext
            // 
            this.lastNametext.BackColor = System.Drawing.Color.Maroon;
            this.lastNametext.ForeColor = System.Drawing.Color.Yellow;
            this.lastNametext.Location = new System.Drawing.Point(108, 77);
            this.lastNametext.Name = "lastNametext";
            this.lastNametext.Size = new System.Drawing.Size(100, 20);
            this.lastNametext.TabIndex = 3;
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.ForeColor = System.Drawing.Color.Gold;
            this.firstNamelabel.Location = new System.Drawing.Point(42, 54);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(60, 13);
            this.firstNamelabel.TabIndex = 2;
            this.firstNamelabel.Text = "First Name:";
            this.firstNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.IndianRed;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Gold;
            this.AddItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItemButton.Location = new System.Drawing.Point(77, 246);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(100, 28);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(748, 365);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Users";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.TextBox firstNametext;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.TextBox lastNametext;
        private System.Windows.Forms.Label PWlabel1;
        private System.Windows.Forms.TextBox PWtextbox1;
        private System.Windows.Forms.TextBox PWtextbox2;
        private System.Windows.Forms.Label userTypelabel;
        private System.Windows.Forms.ComboBox userTypecombobox;
        private System.Windows.Forms.Label userslabel;
        private System.Windows.Forms.Label contactNumberlabel;
        private System.Windows.Forms.TextBox contacttext;
        private System.Windows.Forms.Button AddItemButton;
    }
}