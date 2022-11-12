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
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usersDataGrid);
            this.panel1.Location = new System.Drawing.Point(343, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 413);
            this.panel1.TabIndex = 0;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(3, 6);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.RowHeadersVisible = false;
            this.usersDataGrid.RowHeadersWidth = 51;
            this.usersDataGrid.Size = new System.Drawing.Size(473, 402);
            this.usersDataGrid.TabIndex = 0;
            // 
            // firstNametext
            // 
            this.firstNametext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNametext.BackColor = System.Drawing.Color.White;
            this.firstNametext.ForeColor = System.Drawing.Color.Black;
            this.firstNametext.Location = new System.Drawing.Point(148, 84);
            this.firstNametext.Name = "firstNametext";
            this.firstNametext.Size = new System.Drawing.Size(145, 24);
            this.firstNametext.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label1);
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
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(310, 413);
            this.panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Re-Type Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemButton.BackColor = System.Drawing.Color.White;
            this.AddItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItemButton.ForeColor = System.Drawing.Color.Black;
            this.AddItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItemButton.Location = new System.Drawing.Point(68, 335);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(172, 33);
            this.AddItemButton.TabIndex = 16;
            this.AddItemButton.Text = "ADD";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // userTypelabel
            // 
            this.userTypelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTypelabel.AutoSize = true;
            this.userTypelabel.BackColor = System.Drawing.Color.Transparent;
            this.userTypelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userTypelabel.Location = new System.Drawing.Point(56, 290);
            this.userTypelabel.Name = "userTypelabel";
            this.userTypelabel.Size = new System.Drawing.Size(80, 18);
            this.userTypelabel.TabIndex = 14;
            this.userTypelabel.Text = "User Type:";
            this.userTypelabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // userTypecombobox
            // 
            this.userTypecombobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTypecombobox.BackColor = System.Drawing.Color.White;
            this.userTypecombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userTypecombobox.ForeColor = System.Drawing.Color.Black;
            this.userTypecombobox.FormattingEnabled = true;
            this.userTypecombobox.Items.AddRange(new object[] {
            "Admin",
            "Encoder",
            "Sales"});
            this.userTypecombobox.Location = new System.Drawing.Point(147, 287);
            this.userTypecombobox.Name = "userTypecombobox";
            this.userTypecombobox.Size = new System.Drawing.Size(144, 26);
            this.userTypecombobox.TabIndex = 13;
            // 
            // userslabel
            // 
            this.userslabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userslabel.AutoSize = true;
            this.userslabel.BackColor = System.Drawing.Color.Transparent;
            this.userslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userslabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userslabel.Location = new System.Drawing.Point(14, 23);
            this.userslabel.Name = "userslabel";
            this.userslabel.Size = new System.Drawing.Size(175, 25);
            this.userslabel.TabIndex = 12;
            this.userslabel.Text = "User Information:";
            this.userslabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userslabel.Click += new System.EventHandler(this.userslabel_Click);
            // 
            // PWtextbox2
            // 
            this.PWtextbox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWtextbox2.BackColor = System.Drawing.Color.White;
            this.PWtextbox2.ForeColor = System.Drawing.Color.Black;
            this.PWtextbox2.Location = new System.Drawing.Point(147, 251);
            this.PWtextbox2.Name = "PWtextbox2";
            this.PWtextbox2.PasswordChar = '*';
            this.PWtextbox2.Size = new System.Drawing.Size(144, 24);
            this.PWtextbox2.TabIndex = 11;
            // 
            // PWlabel1
            // 
            this.PWlabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWlabel1.AutoSize = true;
            this.PWlabel1.BackColor = System.Drawing.Color.Transparent;
            this.PWlabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PWlabel1.Location = new System.Drawing.Point(62, 218);
            this.PWlabel1.Name = "PWlabel1";
            this.PWlabel1.Size = new System.Drawing.Size(79, 18);
            this.PWlabel1.TabIndex = 10;
            this.PWlabel1.Text = "Password:";
            this.PWlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PWtextbox1
            // 
            this.PWtextbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWtextbox1.BackColor = System.Drawing.Color.White;
            this.PWtextbox1.ForeColor = System.Drawing.Color.Black;
            this.PWtextbox1.Location = new System.Drawing.Point(147, 216);
            this.PWtextbox1.Name = "PWtextbox1";
            this.PWtextbox1.PasswordChar = '*';
            this.PWtextbox1.Size = new System.Drawing.Size(145, 24);
            this.PWtextbox1.TabIndex = 9;
            // 
            // usernamelabel
            // 
            this.usernamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernamelabel.Location = new System.Drawing.Point(60, 187);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(81, 18);
            this.usernamelabel.TabIndex = 8;
            this.usernamelabel.Text = "Username:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernametext
            // 
            this.usernametext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernametext.BackColor = System.Drawing.Color.White;
            this.usernametext.ForeColor = System.Drawing.Color.Black;
            this.usernametext.Location = new System.Drawing.Point(148, 184);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(144, 24);
            this.usernametext.TabIndex = 7;
            // 
            // contactNumberlabel
            // 
            this.contactNumberlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactNumberlabel.AutoSize = true;
            this.contactNumberlabel.BackColor = System.Drawing.Color.Transparent;
            this.contactNumberlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contactNumberlabel.Location = new System.Drawing.Point(65, 152);
            this.contactNumberlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumberlabel.Name = "contactNumberlabel";
            this.contactNumberlabel.Size = new System.Drawing.Size(76, 18);
            this.contactNumberlabel.TabIndex = 6;
            this.contactNumberlabel.Text = "Contact #:";
            this.contactNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contacttext
            // 
            this.contacttext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contacttext.BackColor = System.Drawing.Color.White;
            this.contacttext.ForeColor = System.Drawing.Color.Black;
            this.contacttext.Location = new System.Drawing.Point(147, 149);
            this.contacttext.Name = "contacttext";
            this.contacttext.Size = new System.Drawing.Size(145, 24);
            this.contacttext.TabIndex = 5;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNamelabel.Location = new System.Drawing.Point(57, 121);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(84, 18);
            this.lastNamelabel.TabIndex = 4;
            this.lastNamelabel.Text = "Last Name:";
            this.lastNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNametext
            // 
            this.lastNametext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNametext.BackColor = System.Drawing.Color.White;
            this.lastNametext.ForeColor = System.Drawing.Color.Black;
            this.lastNametext.Location = new System.Drawing.Point(147, 118);
            this.lastNametext.Name = "lastNametext";
            this.lastNametext.Size = new System.Drawing.Size(146, 24);
            this.lastNametext.TabIndex = 3;
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNamelabel.Location = new System.Drawing.Point(56, 85);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(85, 18);
            this.firstNamelabel.TabIndex = 2;
            this.firstNamelabel.Text = "First Name:";
            this.firstNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Users
            // 
            this.AcceptButton = this.AddItemButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
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
        private System.Windows.Forms.Label label1;
    }
}