using System;
using System.Threading;
using System.Windows.Forms;

namespace _3FS_System
{
    public partial class Login : Form
    {
        Thread thrd;
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //if((username_text.Text == "admin")&&(password_text.Text == "ab&j"))
            //{
            //    this.Close();
            //    thrd = new Thread(openMain);
            //    thrd.SetApartmentState(ApartmentState.STA);
            //    thrd.Start();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username/password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

              this.Close();
              thrd = new Thread(openMain);
              thrd.SetApartmentState(ApartmentState.STA);
              thrd.Start();
        }

        private void openMain()
        {
            Application.Run(new Main());
        }
    }
}
