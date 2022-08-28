﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_IMS
{
    public partial class MainWindow : Form
    {
        private UserControl login;

        public MainWindow()
        {
            InitializeComponent();

            this.login = new Contents.LoginScreen(this);
            this.AddUserControl(login);
        }

        public UserControl GetLogin()
        {
            return login;
        }

        public void AddUserControl(UserControl control)
        {
            this.Controls.Clear();
            this.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
