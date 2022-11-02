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
using System.Web;
using System.Windows;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;


namespace _3FS_System
{
    public partial class Main : Form
    {
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public Main()
        {
            InitializeComponent();
            
           
            MaximumSize = new Size(screenWidth, screenHeight);

            this.WindowState = FormWindowState.Maximized;


        }
        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                MaximumSize = new Size(screenWidth, screenHeight);
                this.WindowState = FormWindowState.Maximized;
                int newval = panel1.Height + 4;
                newval /= 5;
                int buttonheight = newval;
                customers_button.Height = buttonheight;
                customerProfile.Height = buttonheight;
                sales_button.Height = buttonheight;
                Inventory_new.Height = buttonheight;
                users.Height = buttonheight;
                this.BackgroundImage = null;
                // string myfile = System.Reflection.Assembly.GetExecutingAssembly().Location + "hardware_logo transparent.png";
                this.BackgroundImage = Properties.Resources.hardware_logo_transparent;

                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.Height = 650;
                this.Width = 1200;
                int newval = panel1.Height + 4;
                newval /= 5;
                int buttonheight = newval;
                customers_button.Height = buttonheight;
                customerProfile.Height = buttonheight;
                sales_button.Height = buttonheight;
                Inventory_new.Height = buttonheight;
                users.Height = buttonheight;
                this.BackgroundImage = null;

                this.BackgroundImage = Properties.Resources.hardware_logo_transparent;
                //Console.WriteLine(nheight);
                this.WindowState = FormWindowState.Normal;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {

            }
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            
            
            //FormCollection fc = Application.OpenForms;
            //bool bFormNameOpen = false;
            //foreach (Form frm in fc)
            //{
            //    if (frm.Name == "Inventory")
            //    {
            //        bFormNameOpen = true;
            //        frm.Focus();
            //        break;
            //    }
            //    else
            //    {
            //        bFormNameOpen = false;
            //    }
            //}
            //if(bFormNameOpen == false)
            //{
            //    Inventory invtry = new Inventory();
            //    invtry.MdiParent = this;
                
            //    invtry.Show();
            //}


        }

        private void sales_button_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Sales")
                {
                    bFormNameOpen = true;
                    frm.Focus();
                    break;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Sales sales = new Sales();
                sales.MdiParent = this;
                
                sales.Show();
            }
        }

        private void customers_button_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Collectibles")
                {
                    bFormNameOpen = true;
                    frm.Focus();
                    break;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Collectibles collectibles = new Collectibles();
                collectibles.MdiParent = this;
                collectibles.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.

            // Call the method that changes the background color.
           
            int myvalue = panel1.Height+4;
            myvalue = myvalue / 5;
            int buttonheight = myvalue;
            customers_button.Height = buttonheight;
            customerProfile.Height = buttonheight;
            sales_button.Height = buttonheight;
            Inventory_new.Height = buttonheight;
            users.Height = buttonheight;

            SetBackGroundColorOfMDIForm();
        }
        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.IndianRed;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void users_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Users")
                {
                    bFormNameOpen = true;
                    frm.Focus();
                    break;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Users users = new Users();
                users.MdiParent = this;
                users.Show();
            }
        }

        private void customerProfile_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "CustomerProfile")
                {
                    bFormNameOpen = true;
                    frm.Focus();
                    break;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                CustomerProfile customerprofile = new CustomerProfile();
                customerprofile.MdiParent = this;
                customerprofile.Show();
            }
        }

       

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_new_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Inventory")
                {
                    bFormNameOpen = true;
                    frm.Focus();
                    break;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Inventory invtry = new Inventory();
                invtry.MdiParent = this;

                invtry.Show();
            }

        }
    }
}
