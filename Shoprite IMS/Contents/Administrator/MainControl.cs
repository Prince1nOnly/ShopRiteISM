using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_IMS.Contents.Administrator
{
    public partial class MainControl : UserControl
    {
        private int screen = 0;
        private UserControl inventory;
        private UserControl products;
        private UserControl logs;
        private UserControl access;
        private MainWindow window; 

        public MainControl(MainWindow form, System.Collections.Generic.List<string> values)
        {
            InitializeComponent();
            window = form;
            SetProfile(values);

            inventory = new ManageInventory();
            products = new AllProducts();
            logs = new Logs();
            access = new AccessControl();
            AddUserControl(inventory);
        }

        private void SetProfile(System.Collections.Generic.List<string> values)
        {
            employeeIDValue.Text = "Employee " + values[0];
            employeeNameValue.Text = values[1] + " " + values[2];
        }

        private void AddUserControl(UserControl control)
        {
            contentPane.Controls.Clear();
            contentPane.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (sideBar.Width == sideBar.MaximumSize.Width)
            {
                sideBar.Width = sideBar.MinimumSize.Width;
                profileBtn.Size = new Size(40, 40);
            }
            else
            {
                sideBar.Width = sideBar.MaximumSize.Width;
                profileBtn.Size = new Size(48, 48);
            }
        }

        private void allProdBtn_Click(object sender, EventArgs e)
        {
            if(screen != 1)
            {
                AddUserControl(products);
                screen = 1;
            }
        }

        private void manInventBtn_Click(object sender, EventArgs e)
        {
            if(screen != 0)
            {
                AddUserControl(inventory);
                screen = 0;
            }
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            if(screen != 3)
            {
                AddUserControl(logs);
                screen = 3;
            }
        }

        private void accessControlBtn_Click(object sender, EventArgs e)
        {
            if(screen != 2)
            {
                AddUserControl(access);
                screen = 2;
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                window.AddUserControl(window.GetLogin());
            }
        }
    }
}
