using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3FS_System
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(firstNametext.Text)) || (String.IsNullOrEmpty(lastNametext.Text)) || (String.IsNullOrEmpty(contacttext.Text)) || (String.IsNullOrEmpty(usernametext.Text)) || (String.IsNullOrEmpty(PWtextbox1.Text)) || (String.IsNullOrEmpty(PWtextbox2.Text)))
            {
                MessageBox.Show("Enter complete details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
