namespace _3FS_Inc._System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (this.user_text.Text == "admin")
            {
                if (this.password_text.Text == "3flowerstore")
                {
                    Main mainwin = new(this.user_text.Text);
                    this.Hide();
                    mainwin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong password!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.user_text.Text == "nonadmin")
            {
                Main mainwin = new(this.user_text.Text);
                this.Hide();
                mainwin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter credentials!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}