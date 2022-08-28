using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shoprite_IMS.Contents.Attendant
{
    public partial class MainControl : UserControl
    {
        private int screen = 0;
        UserControl sales;
        UserControl logs;
        private MainWindow window;

        public MainControl(MainWindow form, System.Collections.Generic.List<string> values)
        {
            InitializeComponent();
            window = form;
            SetProfile(values);

            sales = new SalesPoint();
            logs = new Logs();
            AddUserControl(sales);
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

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            if (screen != 0)
            {
                AddUserControl(sales);
                screen = 0;
            }
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            if(screen != 1)
            {
                AddUserControl(logs);
                screen = 1;
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

