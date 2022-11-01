namespace _3FS_System
{
    partial class Login
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
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(115, 29);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(100, 20);
            this.username_text.TabIndex = 0;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(115, 55);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(100, 20);
            this.password_text.TabIndex = 1;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(53, 32);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(56, 13);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(54, 58);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(55, 13);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "password:";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(127, 81);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 125);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.MaximumSize = new System.Drawing.Size(284, 164);
            this.MinimumSize = new System.Drawing.Size(284, 164);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button login_button;
    }
}

