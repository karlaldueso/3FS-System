﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Threading;

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