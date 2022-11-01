using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _3FS_System
{
    public partial class splashscreen : Form
    {
        Thread thrd;
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Increment(2);
            if (progressBar1.Value == 100) 
            {

                
                Login frm = new Login();

                timer1.Enabled=false;
                
                thrd = new Thread(openLogin);
                thrd.SetApartmentState(ApartmentState.STA);
                thrd.Start();
                this.Close();
            }

        }
        private void openLogin()
        {
            Application.Run(new Login());
        }
    }
}
