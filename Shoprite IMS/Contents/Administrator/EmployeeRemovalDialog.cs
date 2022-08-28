using System;
using System.Windows.Forms;

namespace Shoprite_IMS.Contents.Administrator
{
    public partial class EmployeeRemovalDialog : Form
    {
        System.Collections.Generic.List<string[]> toBeRemoved = new System.Collections.Generic.List<string[]>();
        System.Collections.Generic.List<int> otherReasons = new System.Collections.Generic.List<int>();
        System.Drawing.Image warningIcon;
        bool multiSelectProcessing = false;

        public EmployeeRemovalDialog()
        {
            InitializeComponent();
            warningIcon = descriptionBoxLabel.Image;
            descriptionBoxLabel.Image = null;
            characterCountLabel.Text = "Characters Left: " + descriptionBox.MaxLength.ToString();
            this.Hide();
        }

        public System.Collections.Generic.List<string[]> ToBeRemoved { get { return toBeRemoved; } }

        public void SetListBoxSource(System.Collections.Generic.List<string[]> values)
        {
            toBeRemoved = values;

            foreach(var item in values)
            {
                removalListBox.Items.Add(item[0]);
            }

            removalListBox.SelectedIndex = 0;
        }

        private void ResetDialog()
        {
            removalListBox.Items.Clear();
            otherReasons.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            ResetDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder callValues = new System.Text.StringBuilder();
            int counter = 0;

            for(int x = toBeRemoved.Count - 1; x >= 0; x--)
            {
                if (toBeRemoved[x][1] == null)
                {
                    counter++;

                    if (counter > 1) callValues.Insert(0, ", " + toBeRemoved[x][0]);
                    else callValues.Insert(0, ", and " + toBeRemoved[x][0]);
                }
            }

            if(callValues.Length > 0)
            {
                if (counter == 1) callValues.Replace(", and", "");
                callValues.Insert(0, "No reason(s) provided for");
                callValues.Replace("for, ", "for ");
                callValues.Append(".");
            }

            if(otherReasons.Count > 0)
            {
                counter = 0;

                for(int x = otherReasons.Count - 1; x >= 0; x--)
                {
                    if (toBeRemoved[otherReasons[x]][1] == "Other (Description Required)" && (toBeRemoved[otherReasons[x]][2] == null || toBeRemoved[otherReasons[x]][2].Length == 0))
                    {
                        if (counter == 0 && callValues.Length > 2) callValues.Insert(0, "\n\n");
                        counter++;

                        if (x < otherReasons.Count - 1 && otherReasons.Count > 1) callValues.Insert(0, removalListBox.Items[otherReasons[x]] + ", ");
                        else if(x == otherReasons.Count - 1 && otherReasons.Count > 1) callValues.Insert(0, "and " + removalListBox.Items[otherReasons[x]] + ".");
                        else callValues.Insert(0, removalListBox.Items[otherReasons[x]] + ".");
                    }
                    else otherReasons.RemoveAt(x);

                    if (counter > 0 && x == 0) callValues.Insert(0, "Please provide description(s) to reason(s) for ");
                }
            }

            if (callValues.Length > 0)
            {
                MessageBox.Show(callValues + "");
                return;
            }

            ResetDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void removalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(removalListBox.SelectedItems.Count == 1)
            {
                if (toBeRemoved[removalListBox.SelectedIndex][1] == null)
                {
                    reasonList.SelectedIndex = -1;
                }
                else
                {
                    reasonList.SelectedItem = toBeRemoved[removalListBox.SelectedIndex][1];
                }

                descriptionBox.Text = toBeRemoved[removalListBox.SelectedIndex][2];
            }
            else
            {
                if (!multiSelectProcessing) multiSelectProcessing = true;

                reasonList.SelectedIndex = -1;
                descriptionBox.Text = null;

                multiSelectProcessing = false;

                foreach (int index in removalListBox.SelectedIndices)
                {
                    if (toBeRemoved[removalListBox.SelectedIndices[0]][1] != toBeRemoved[index][1]) return;
                    if (toBeRemoved[removalListBox.SelectedIndices[0]][2] != toBeRemoved[index][2]) return;
                }

                reasonList.SelectedItem = toBeRemoved[removalListBox.SelectedIndex][1];
                descriptionBox.Text = toBeRemoved[removalListBox.SelectedIndex][2];
            }
        }

        private void reasonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removalListBox.SelectedItems.Count == 1 && !multiSelectProcessing)
            {
                toBeRemoved[removalListBox.SelectedIndex][1] = reasonList.Text;
            }
            else if(!multiSelectProcessing)
            {
                foreach (int index in removalListBox.SelectedIndices)
                {
                    toBeRemoved[index][1] = reasonList.Text;
                }
            }

            if (reasonList.Text == "Other (Description Required)")
            {
                if (descriptionBoxLabel.Text == "Description (Optional)") descriptionBoxLabel.Text = "Description";
                if (descriptionBoxLabel.Image == null) descriptionBoxLabel.Image = warningIcon;

                foreach (int index in removalListBox.SelectedIndices)
                {
                    if (!otherReasons.Contains(index)) otherReasons.Add(index);
                }

                if(descriptionBox.Text.Length == 0 && descriptionBox.BackColor == System.Drawing.SystemColors.Window)
                {
                    descriptionBox.BackColor = System.Drawing.Color.FromArgb(225, 225, 255);
                }
            }
            else
            {
                if (descriptionBoxLabel.Text == "Description") descriptionBoxLabel.Text = "Description (Optional)";
                if (descriptionBoxLabel.Image != null) descriptionBoxLabel.Image = null;
                if (descriptionBox.BackColor != System.Drawing.SystemColors.Window) descriptionBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            characterCountLabel.Text = "Characters Left: " + (descriptionBox.MaxLength - descriptionBox.Text.Length).ToString();

            if (reasonList.Text == "Other (Description Required)")
            {
                if (descriptionBoxLabel.Text == "Description (Optional)") descriptionBoxLabel.Text = "Description";
                if (descriptionBoxLabel.Image == null) descriptionBoxLabel.Image = warningIcon;

                if (descriptionBox.Text.Length > 0 && descriptionBox.BackColor == System.Drawing.Color.FromArgb(225, 225, 255))
                {
                    descriptionBox.BackColor = System.Drawing.SystemColors.Window;
                }
                else if (descriptionBox.Text.Length == 0 && descriptionBox.BackColor == System.Drawing.SystemColors.Window)
                {
                    descriptionBox.BackColor = System.Drawing.Color.FromArgb(225, 225, 255);
                }
            }
        }

        private void EmployeeRemovalDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResetDialog();
        }

        private void descriptionBox_Leave(object sender, EventArgs e)
        {
            if(removalListBox.SelectedItems.Count == 1)
            {
                toBeRemoved[removalListBox.SelectedIndex][2] = descriptionBox.Text;
            }
            else
            {
                foreach(int index in removalListBox.SelectedIndices)
                {
                    toBeRemoved[index][2] = descriptionBox.Text;
                }
            }
        }
    }
}
