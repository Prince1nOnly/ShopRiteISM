using System.Drawing;
using System.Windows.Forms;

namespace Shoprite_IMS.Contents
{
    public partial class LoginScreen : UserControl
    {
        private MainWindow window;
        private UserControl administrator;
        private UserControl attendant;

        public LoginScreen(MainWindow form)
        {
            InitializeComponent();
            loginPanel.BackColor = Color.FromArgb(175, Color.White);
            window = form;
        }

        public void UserAuth()
        {
            if (usernameField.Text.Trim() == "" && passwordField.Text == "")
            {
                MessageBox.Show("Please enter your username and password to continue!");
            }
            else if (usernameField.Text.Trim() == "")
            {
                MessageBox.Show("Username cannot be empty!");
            }
            else if (passwordField.Text == "")
            {
                MessageBox.Show("Password cannot be empty!");
            }
            else
            {
                bool userExists = Program.sqlFunc.Exists($"Select exists(select * from employeeinfo where username = '{usernameField.Text.Trim()}')");
                bool passExists = Program.sqlFunc.Exists($"Select exists(select * from employeeinfo where username = '{usernameField.Text.Trim()}' " +
                    $"and password = '{passwordField.Text}')");

                if(!userExists)
                {
                    MessageBox.Show("Username not found!");
                }
                else if (userExists && !passExists)
                {
                    MessageBox.Show("Password is incorrect! Please try again.");
                }
                else
                {
                    string status = Program.sqlFunc.Select($"Select status from employeeInfo where username = '{usernameField.Text.Trim()}'");
                    System.Collections.Generic.List<string> userValues = Program.sqlFunc.SelectCreateList($"Select employee_id, first_name, last_name from employeeInfo where username = '{usernameField.Text.Trim()}'");

                    switch (status.ToLower())
                    {
                        case "administrator":
                            usernameField.ResetText();
                            passwordField.ResetText();
                            if(administrator == null) administrator = new Administrator.MainControl(window, userValues);
                            window.AddUserControl(administrator);
                            break;
                        case "attendant":
                            usernameField.ResetText();
                            passwordField.ResetText();
                            if (attendant == null) attendant = new Attendant.MainControl(window, userValues);
                            window.AddUserControl(attendant);
                            break;
                        default:
                            MessageBox.Show("Employee status not defined for use within this application! \nPlease contact the developer.");
                            break;
                    }
                }
            }
        }

        private void siginBtn_Click(object sender, System.EventArgs e)
        {
            UserAuth();
        }
    }
}


