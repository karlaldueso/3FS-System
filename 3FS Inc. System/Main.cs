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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        private void inventory_button_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Inventory")
                {
                    bFormNameOpen = true;
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if(bFormNameOpen == false)
            {
                Inventory invtry = new Inventory();
                invtry.Show();
            }
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
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Sales sales = new Sales();
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
                }
                else
                {
                    bFormNameOpen = false;
                }
            }
            if (bFormNameOpen == false)
            {
                Collectibles collectibles = new Collectibles();
                collectibles.Show();
            }
        }
    }
}
