using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shoprite_IMS.Contents.Administrator
{
    public partial class AccessControl : UserControl
    {
        string[] employeeIDs;
        string ignoreUnique;
        private DataTable table = new DataTable();
        private int rowIndex = 0;
        private string employeeID = null;
        private Guna.UI2.WinForms.Guna2TextBox[] textFields = new Guna.UI2.WinForms.Guna2TextBox[6];
        private string opStatus = null;
        private Image textFieldsWarnIcon;
        private bool invalidInputPresent = false;
        EmployeeRemovalDialog dialog;

        public AccessControl()
        {
            InitializeComponent();

            LoadEmployeeTable();
            CreateTextBoxArray();
            dialog = new EmployeeRemovalDialog();
            textFieldsWarnIcon = usernameValue.IconRight;
            usernameValue.IconRight = null;

            AddEmailEventHandler(emailValue);
            AddLettersEventHandler(firstNameValue);
            AddLettersEventHandler(lastNameValue);
            AddPhoneNumberEventHandler(telephoneValue);
            AddUniquenessEventHandler(usernameValue);
            passwordValue.TextChanged += RemoveWarning_TextChanged;
        }

        private void CreateTextBoxArray()
        {
            textFields[0] = usernameValue;
            textFields[1] = firstNameValue;
            textFields[2] = lastNameValue;
            textFields[3] = emailValue;
            textFields[4] = telephoneValue;
            textFields[5] = passwordValue;
        }

        private void EnableTextFields()
        {
            foreach(var field in textFields)
            {
                field.Enabled = true;
            }

            statusList.Enabled = true;
        }

        private void DisableTextFields()
        {
            foreach(var field in textFields)
            {
                field.Enabled = false;
            }

            statusList.Enabled = false;
        }

        private void ResetTextFields()
        {
            foreach(var field in textFields)
            {
                field.Text = "";
            }

            statusList.SelectedIndex = -1;
        }

        private void EnableControls()
        {
            newBtn.Enabled = true;
            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
        }

        private void DisableControls()
        {
            newBtn.Enabled = false;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void SetTextFields()
        {
            rowIndex = employeeTable.CurrentRow.Index;
            ignoreUnique = employeeTable.Rows[rowIndex].Cells[1].Value.ToString().ToLower();

            for (int i = 0; i < 6; i++)
            {
                textFields[i].Text = employeeTable.Rows[rowIndex].Cells[i + 1].Value.ToString();
            }

            employeeID = employeeTable.Rows[rowIndex].Cells[0].Value.ToString();
            statusList.SelectedItem = employeeTable.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private System.Collections.Generic.List<string[]> GetToBeRemoved()
        {
            int selectedRowCount = employeeTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            System.Collections.Generic.List<string[]> toBeRemoved = new System.Collections.Generic.List<string[]>();

            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append(employeeTable.SelectedRows[i].Cells["First_Name"].Value.ToString() + " ");
                    sb.Append(employeeTable.SelectedRows[i].Cells["Last_Name"].Value.ToString() + " (");
                    sb.Append(employeeTable.SelectedRows[i].Cells["Employee_ID"].Value.ToString() + ")");
                    toBeRemoved.Insert(0, new string[3]);
                    toBeRemoved[0][0] = sb.ToString();
                    sb.Clear();
                }
            }

            return toBeRemoved;
        }

        private void TrimTextFields()
        {
            foreach(Guna.UI2.WinForms.Guna2TextBox field in textFields)
            {
                field.Text = field.Text.Trim();
            }
        }

        private bool ManFieldsCompleted()
        {
            String invalidWarning = "\n\nInvalid input(s) detected! Please ensure that all provided data meet their constraints.";
            bool incomplete = false;

            foreach (var field in textFields)
            {
                if(field.Text.Trim() == "")
                {
                    if(!incomplete) incomplete = true;
                    field.FillColor = Color.FromArgb(225, 225, 255);
                    field.IconRight = textFieldsWarnIcon;
                }
                else if(!invalidInputPresent && field.IconRight == textFieldsWarnIcon)
                {
                    invalidInputPresent = true;
                }
            }

            if(incomplete || invalidInputPresent)
            {
                string statusWarning = " select an employee's status ";

                if(!incomplete)
                {
                    MessageBox.Show(String.Format("{0}{1}", ((statusList.SelectedIndex < 0) ? "Please" + statusWarning + "!": ""), (invalidInputPresent ? invalidWarning : "")).Trim());
                    return false;
                }
                else
                {
                    MessageBox.Show(String.Format("Please{0}complete all fields!{1}", ((statusList.SelectedIndex < 0) ? statusWarning + "and " : ""), (invalidInputPresent ? invalidWarning : "")));
                    return false;
                }
            }

            return true;
        }

        private void LoadEmployeeTable()
        {
            string query = "Select Employee_ID, Username, First_Name, Last_Name, Email, Telephone, cast(password as char) as Password, Status from employeeinfo";
            Program.sqlFunc.SetTable(query, employeeTable, table);
        }

        private void DeleteRows()
        {
            foreach (var id in employeeIDs)
            {
                Program.sqlFunc.Delete($"delete from employeeinfo where employee_id = '{id}'");
                table.Select($"Employee_ID = {id}")[0].Delete();
            }

            table.AcceptChanges();
        }

        private void UpdateSelectedRow()
        {
            for(int i = 0; i < textFields.Length; i++)
            {
                table.Rows[rowIndex].SetField(i+1, textFields[i].Text);
            }

            table.Rows[rowIndex].SetField(7, statusList.Text);

            table.AcceptChanges();
        }

        private void UnPaintUnresolvedFields()
        {
            foreach(var field in textFields)
            {
                if(field.Text.Trim() != "" && field.FillColor == Color.FromArgb(225, 225, 255))
                {
                    field.FillColor = SystemColors.Window;
                    field.IconRight = null;
                }
            }
        }

        private bool containsInvalidIndicesEmail(string text)
        {
            string characters = "!#$%&'*+-/=?^_`{}|@.";

            foreach(var ch in characters)
            {
                if(text.IndexOf(ch) > -1 && text.IndexOf(ch) < text.Length - 2 && text[text.IndexOf(ch)] == text[text.IndexOf(ch) + 1])
                {
                    Console.WriteLine("love");
                    return true;
                }
                else if(text.IndexOf(ch) == 0 || text.LastIndexOf(ch) == text.Length - 1)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isValidLetter(string text)
        {
            if(text.All(Char.IsLetter))
            {
                return true;
            }

            return false;
        }

        private bool IsValidEmail(string text)
        {
            if(text.IndexOf("@") > -1 && Regex.IsMatch(text, @"^[a-zA-Z0-9!#$%&'*+\-/=?^_`{}|@.]+$") && !containsInvalidIndicesEmail(text))
            {
                if(text.IndexOf("@") == text.LastIndexOf("@") && text.IndexOf(".", text.IndexOf("@")) > text.IndexOf("@"))
                {
                    return true;
                }
            }

            return false;
        }

        private bool isValidPhoneNumber(string text)
        {
            if(Regex.IsMatch(text, @"^[0-9+]+$"))
            {
                if(text.Contains("+") && text.IndexOf("+") != 0 && text.LastIndexOf("+") != 0)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public void AddPhoneNumberEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidatePhoneNumber_TextChanged;
        }

        public void AddEmailEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateEmail_TextChanged;
        }

        public void AddLettersEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateLetters_TextChanged;
        }

        public void AddUniquenessEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateUniqueness_TextChanged;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            EnableTextFields();
            cancelBtn.Enabled = true;
            saveBtn.Enabled = true;
            DisableControls();
            opStatus = "Add New Employee";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            UnPaintUnresolvedFields();
            ResetTextFields();
            DisableTextFields();
            cancelBtn.Enabled = false;
            saveBtn.Enabled = false;
            EnableControls();
            opStatus = null;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EnableTextFields();
            cancelBtn.Enabled = true;
            saveBtn.Enabled = true;
            DisableControls();
            opStatus = "Edit Employee";
            SetTextFields();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TrimTextFields();

            StringBuilder insertQuery = new StringBuilder($"insert into employeeinfo (Username, First_Name, Last_Name, " +
                $"Email, Telephone, Password, Status) " +
                $"values('{usernameValue.Text}', '{firstNameValue.Text}', '{lastNameValue.Text}', '{emailValue.Text}', " +
                $"'{telephoneValue.Text}', '{passwordValue.Text}', '{statusList.Text}')");

            StringBuilder updateQuery = new StringBuilder($"update employeeinfo " +
                $"set username = '{usernameValue.Text}', first_name = '{firstNameValue.Text}', last_name = '{lastNameValue.Text}', " +
                $"email = '{emailValue.Text}', telephone = '{telephoneValue.Text}', password = '{passwordValue.Text}', status = '{statusList.Text}'" +
                $"where employee_id = '{employeeID}'");

            if(ManFieldsCompleted() && !invalidInputPresent)
            {
                switch (opStatus)
                {
                    case "Add New Employee":
                        Program.sqlFunc.Insert(insertQuery.ToString());
                        MessageBox.Show(table.Rows.Count.ToString());
                        table.Rows.Add(new Object[] {(table.Rows.Count + 1).ToString(), usernameValue.Text, firstNameValue.Text, lastNameValue.Text, emailValue.Text, telephoneValue.Text, passwordValue.Text, statusList.Text });
                        table.AcceptChanges();
                        return;
                    case "Edit Employee":
                        Program.sqlFunc.Update(updateQuery.ToString());
                        UpdateSelectedRow();
                        break;
                    default:
                        break;
                }

                ResetTextFields();
                DisableTextFields();
                cancelBtn.Enabled = false;
                saveBtn.Enabled = false;
                EnableControls();
                opStatus = null;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string query = "Select Employee_ID, Username, First_Name, Last_Name, Email, Telephone, cast(password as char) as Password, Status from employeeinfo";
            Program.sqlFunc.ReloadTable(query, table);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dialog.SetListBoxSource(GetToBeRemoved());
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                int selectedRowCount = employeeTable.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount > 0)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("Insert into PastEmployees values\n");

                    for (int i = selectedRowCount - 1; i >= 0; i--)
                    {
                        sb.Append("(" + employeeTable.SelectedRows[i].Cells["Employee_ID"].Value.ToString() + ", ");
                        sb.Append("'" + employeeTable.SelectedRows[i].Cells["First_Name"].Value.ToString() + "', ");
                        sb.Append("'" + employeeTable.SelectedRows[i].Cells["Last_Name"].Value.ToString() + "', ");
                        sb.Append("'" + employeeTable.SelectedRows[i].Cells["Email"].Value.ToString() + "', ");
                        sb.Append("'" + employeeTable.SelectedRows[i].Cells["Telephone"].Value.ToString() + "', ");
                        sb.Append("'" + employeeTable.SelectedRows[i].Cells["Status"].Value.ToString() + "', ");
                        sb.Append("'" + dialog.ToBeRemoved[Math.Abs(i - selectedRowCount + 1)][1] + "', ");
                        sb.Append("'" + dialog.ToBeRemoved[Math.Abs(i - selectedRowCount + 1)][2] + "')");
                        if(i != 0) sb.Append(",\n");
                    }

                    Program.sqlFunc.Insert("" + sb.Replace("''", "Null"));
                    DeleteRows();
                }
            }
        }

        private void ValidatePhoneNumber_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (!isValidPhoneNumber(textBox.Text) && textBox.Text != "" && opStatus != null)
            {
                textBox.FillColor = Color.FromArgb(255, 192, 192);
                textBox.IconRight = textFieldsWarnIcon;
            }
            else if (textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void ValidateEmail_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (!IsValidEmail(textBox.Text) && textBox.Text != "" && opStatus != null)
            {
                textBox.FillColor = Color.FromArgb(255, 192, 192);
                textBox.IconRight = textFieldsWarnIcon;
            }
            else if (textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void ValidateUniqueness_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
            bool unique = true;
            
            foreach (DataGridViewRow row in employeeTable.Rows)
            {
                if (opStatus == "Edit Employee" && ignoreUnique == textBox.Text.ToLower())
                {
                    break;
                }

                if (row.Cells["Username"].Value.ToString().ToLower() == textBox.Text.ToLower())
                {
                    textBox.FillColor = Color.FromArgb(255, 192, 192);
                    textBox.IconRight = textFieldsWarnIcon;
                    unique = false;
                    return;
                }
            }

            if (textBox.IconRight != null && unique == true)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void ValidateLetters_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (!isValidLetter(textBox.Text) && textBox.Text != "" && opStatus != null)
            {
                textBox.FillColor = Color.FromArgb(255, 192, 192);
                textBox.IconRight = textFieldsWarnIcon;
            }
            else if (textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void RemoveWarning_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void employeeTable_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = employeeTable.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1 && opStatus == null)
            {
                if (!editBtn.Enabled) editBtn.Enabled = true;
            }
            else
            {
                if (editBtn.Enabled) editBtn.Enabled = false;
            }

            if (selectedRowCount > 0)
            {
                employeeIDs = new string[selectedRowCount];

                for (int i = 0; i < selectedRowCount; i++)
                {
                    employeeIDs[i] = employeeTable.SelectedRows[i].Cells["Employee_ID"].Value.ToString();
                }
            }
        }
    }
}
