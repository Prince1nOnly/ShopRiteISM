using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shoprite_IMS.Contents.Administrator
{
    public partial class ManageInventory : UserControl
    {
        private Guna.UI2.WinForms.Guna2TextBox[] infoFields = new Guna.UI2.WinForms.Guna2TextBox[10];
        private string[] temp = new string[12];
        private Color infoFieldsBorderColor;
        private Image infoFieldsWarnIcon;
        private string opStatus = null;
        private bool invalidInputPresent = false;

        public ManageInventory()
        {
            InitializeComponent();

            CreateTextBoxArray();
            infoFieldsBorderColor = quantityValue.BorderColor;
            infoFieldsWarnIcon = quantityValue.IconRight;
            quantityValue.IconRight = null;
            FillList("Select * from productcategories", prodCatList);

            AddBarcodeEventHandler(barcodeValue);
            AddIntegerEventHandler(quantityValue);
            AddIntegerEventHandler(reorderLevValue);
            AddDecimalEventHandler(unitCostPriceValue);
            AddDecimalEventHandler(unitSellPriceValue);
            AddDecimalEventHandler(grossPriceValue);
            AddDimensionsEventHandler(sizeValue);
            AddDimensionsEventHandler(weightValue);
            AddDimensionsEventHandler(volumeValue);
        }

        private void CreateTextBoxArray()
        {
            infoFields[0] = barcodeValue;
            infoFields[1] = quantityValue;
            infoFields[2] = reorderLevValue;
            infoFields[3] = sizeValue;
            infoFields[4] = weightValue;
            infoFields[5] = volumeValue;
            infoFields[6] = unitCostPriceValue;
            infoFields[7] = unitSellPriceValue;
            infoFields[8] = grossPriceValue;
            infoFields[9] = totalCostValue;
        }

        private void EnableControls()
        {
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            foreach(Guna.UI2.WinForms.Guna2TextBox field in infoFields)
            {
                field.ReadOnly = false;
            }
        }

        private void DisableControls()
        {
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            foreach(Guna.UI2.WinForms.Guna2TextBox field in infoFields)
            {
                field.ReadOnly = true;
            }
        }

        private void FillList(string query, ComboBox box)
        {
            List<string> list = new List<string>();
            list = Program.sqlFunc.SelectCreateList(query);
            box.Items.Clear();

            foreach(string value in list)
            {
                box.Items.Add(value);
            }

            box.SelectedIndex = 0;
        }

        private void SetInfoFields(string query)
        {
            List<string> list = new List<string>();
            list = Program.sqlFunc.SelectCreateList(query);

            int count = 0;
            foreach(string value in list)
            {
                infoFields[count].Text = value;
                count++;
            }

            string toltalCost = string.Format("{0:0.00}", (Convert.ToInt32(infoFields[1].Text) * Convert.ToDouble(infoFields[8].Text)));
            infoFields[9].Text = toltalCost;

        }

        private void ResetInfoFields()
        {
            foreach(Guna.UI2.WinForms.Guna2TextBox field in infoFields)
            {
                field.ResetText();
            }

            //Secondary functions
            if(opStatus != null)
            {
                prodList.DropDownStyle = ComboBoxStyle.Simple;
                prodList.ResetText();
            }
        }

        private void TrimInfoFields()
        {
            foreach(Guna.UI2.WinForms.Guna2TextBox field in infoFields)
            {
                field.Text = field.Text.Trim();
            }

            prodList.Text = prodList.Text.Trim();
        }

        private void restoreInfoFields()
        {
            int count = 0;
            foreach(Guna.UI2.WinForms.Guna2TextBox field in infoFields)
            {
                field.Text = temp[count];
                count++;
            }

            //Secondary functions
            prodCatList.SelectedItem = temp[count];
            prodList.DropDownStyle = ComboBoxStyle.DropDown;
            prodList.SelectedItem = temp[++count];
        }

        private void SetTemp()
        {
            int count = 0;
            foreach(Guna.UI2.WinForms.Guna2TextBox field in infoFields)
            {
                temp[count] = field.Text;
                count++;
            }

            //Secondary function
            temp[count] = (string)prodCatList.SelectedItem;
            temp[++count] = (string)prodList.SelectedItem;
        }

        private void prodCatList_SelectedValueChanged(object sender, EventArgs e)
        {
            if(opStatus == null)
            {
                FillList($"Select product from products where category = '{(prodCatList.SelectedItem).ToString()}'", prodList);
            }
        }

        private void prodCatList_TextChanged(object sender, EventArgs e)
        {
            if(opStatus == null)
            {
                if(prodCatList.SelectedItem == null && prodList.Items.Count > 0)
                {
                    prodList.Items.Clear();
                    prodList.ResetText();
                }
            }
        }

        private bool manFieldsCompleted()
        {
            int specialCount = 0;
            int normalCount = 0;
            String invalidWarning = "";

            for(int i = 0; i < infoFields.Length - 1; i++)
            {
                if(i > 2 && i < 6)
                {
                    if(infoFields[i].Text == "")
                    {
                        specialCount++;
                        normalCount++;
                    }
                }
                else if(infoFields[i].Text == "")
                {
                    normalCount++;
                }

                if(i == 5)
                {
                    PaintUnresolvedFields(specialCount);
                    if(invalidInputPresent)
                    {
                        invalidWarning = "\n\nInvalid input(s) detected! Please ensure that all provided data meet their constraints.";
                    }
                }

                if(normalCount == 3 && specialCount == 3 && prodList.Text.Trim() == "")
                {
                    MessageBox.Show("Product name cannot be empty! Please complete at least one of the other fields!" + invalidWarning);
                    return false;
                }
                else if(normalCount == 3 && specialCount == 3)
                {
                    MessageBox.Show("Please complete at least one of the other fields!" + invalidWarning);
                    return false;
                }
                else if(normalCount > 3 && specialCount == 3 && prodList.Text.Trim() == "")
                {
                    MessageBox.Show("Product name cannot be empty! Please complete all mandatory fields and at least one of the other fields!" + invalidWarning);
                    return false;
                }
                else if(normalCount > 3 && specialCount == 3)
                {
                    MessageBox.Show("Please complete all mandatory fields and at least one of the other fields!" + invalidWarning);
                    return false;
                }
                else if(i == infoFields.Length - 2 && prodList.Text.Trim() == "" && normalCount > 0 && specialCount < 3)
                {
                    MessageBox.Show("Product name cannot be empty! Please complete all mandatory fields!" + invalidWarning);
                    return false;
                }
                else if(i == infoFields.Length - 2 && normalCount > 0 && specialCount == 0)
                {
                    MessageBox.Show("Please complete all mandatory fields!" + invalidWarning);
                    return false;
                }
                else if(i == infoFields.Length - 2 && prodList.Text.Trim() == "")
                {
                    MessageBox.Show("Product name cannot be empty!" + invalidWarning);
                    return false;
                }
            }

            if(invalidInputPresent)
            {
                MessageBox.Show("\r" + invalidWarning);
                return false;
            }

            return true;
        }

        private void paintConstraints()
        {
            for(int i = 0; i < infoFields.Length; i++)
            {
                if(i > 2 && i < 6)
                {
                    infoFields[i].BorderColor = Color.FromArgb(0, Color.SteelBlue);
                }
                else
                {
                    infoFields[i].BorderColor = Color.FromArgb(250, 88, 88);
                }
            }
        }

        private void PaintUnresolvedFields(int special)
        {
            int countInvalid = 0;

            for(int i = 0; i < infoFields.Length - 1; i++)
            {
                if(i > 2 && i < 6 && special < 3)
                {
                    continue;
                }
                else if(special == 3 && infoFields[2].FillColor != Color.FromArgb(225, 225, 255))
                {
                    for(int j = 3; j < 6; j++)
                    {
                        infoFields[j].FillColor = Color.FromArgb(225, 225, 255);
                        infoFields[j].IconRight = infoFieldsWarnIcon;
                    }
                }

                //Secondary function
                if(infoFields[i].FillColor == Color.FromArgb(255, 192, 192))
                {
                    if(!invalidInputPresent)
                    {
                        invalidInputPresent = true;
                    }
                    countInvalid++;
                }//end

                if(infoFields[i].Text.Trim() == "" && infoFields[i].FillColor != Color.FromArgb(225, 225, 255))
                {
                    infoFields[i].FillColor = Color.FromArgb(225, 225, 255);
                    infoFields[i].IconRight = infoFieldsWarnIcon;
                }
                else if(infoFields[i].FillColor == Color.FromArgb(225, 225, 255) && infoFields[i].Text.Trim() != "")
                {
                    infoFields[i].FillColor = SystemColors.Window;
                    infoFields[i].IconRight = null;
                }
            }

            if(countInvalid == 0)
            {
                invalidInputPresent = false;
            }
        }

        private void UnPaintUnresolvedFields()
        {
            for(int i = 0; i < infoFields.Length - 1; i++)
            {
                infoFields[i].FillColor = SystemColors.Window;
                infoFields[i].IconRight = null;
            }
        }

        private void remPaintConstraints()
        {
            for(int i = 0; i < infoFields.Length; i++)
            {
                infoFields[i].BorderColor = infoFieldsBorderColor;
            }
        }

        private void prodList_SelectedValueChanged(object sender, EventArgs e)
        {
            if(opStatus == null)
            {
                string query = $"Select barcode, quantity, reorder_level, size, weight, volume, " +
                                $"unit_cost_price, unit_selling_price, gross_price from products " +
                                $"where product = '{(prodList.SelectedItem).ToString()}' and category = '{(prodCatList.SelectedItem).ToString()}'";

                SetInfoFields(query);
            }
        }

        private void prodList_TextChanged(object sender, EventArgs e)
        {
            if(prodList.SelectedItem == null && opStatus == null)
            {
                ResetInfoFields();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(prodList.SelectedItem == null || prodCatList.SelectedItem == null)
            {
                MessageBox.Show("No product Selected!");
            }
            else
            {
                EnableControls();
                paintConstraints();
                totalCostValue.Enabled = false;
                editBtn.Enabled = false;
                newBtn.Enabled = false;
                rmBtn.Enabled = false;

                opStatus = "Edit Product";
                prodList.DropDownStyle = ComboBoxStyle.Simple;
                SetTemp();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            opStatus = "Add New Product";

            EnableControls();
            paintConstraints();
            totalCostValue.Enabled = false;
            newBtn.Enabled = false;
            editBtn.Enabled = false;
            rmBtn.Enabled = false;

            SetTemp();
            ResetInfoFields();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TrimInfoFields();

            StringBuilder insertQuery = new StringBuilder(($"insert into products (product, category, barcode, quantity, " +
                $"reorder_level, size, weight, volume, unit_cost_price, unit_selling_price, gross_price)" +
                $"values('{prodList.Text}', '{prodCatList.Text}', '{infoFields[0].Text}', {infoFields[1].Text}, " +
                $"{infoFields[2].Text}, '{infoFields[3].Text}', '{infoFields[4].Text}', '{infoFields[5].Text}', " +
                $"{infoFields[6].Text}, {infoFields[7].Text}, {infoFields[8].Text})").Replace("''", "Null").Replace("N/A", "Null"));

            StringBuilder updateQuery = new StringBuilder(($"update products " +
                $"set product = '{prodList.Text}', barcode = '{infoFields[0].Text}', quantity = {infoFields[1].Text}, " +
                $"reorder_level = {infoFields[2].Text}, size = '{infoFields[3].Text}', weight = '{infoFields[4].Text}', " +
                $"volume = '{infoFields[5].Text}', unit_cost_price = {infoFields[6].Text}, unit_selling_price = {infoFields[7].Text}, " +
                $"gross_price = {infoFields[8].Text} " +
                $"where product = '{temp[11]}' and barcode = '{temp[0]}'").Replace("''", "Null").Replace("N/A", "Null"));

            if(manFieldsCompleted() && !invalidInputPresent)
            {
                switch (opStatus)
                {
                    case "Add New Product":
                        if(!prodCatList.Items.Contains(prodCatList.Text))
                        {
                            MessageBox.Show("Please select a valid category!");
                            return;
                        }
                        remPaintConstraints();
                        ResetInfoFields();
                        Program.sqlFunc.Insert(insertQuery.ToString());
                        return;
                    case "Edit Product":
                        if(!prodCatList.Items.Contains(prodCatList.Text))
                        {
                            MessageBox.Show("Please select a valid category!");
                            return;
                        }
                        Program.sqlFunc.Update(updateQuery.ToString());
                        break;
                    default:
                        break;
                }

                if(!prodList.Items.Contains(prodList.Text))
                {
                    prodList.Items.Add(prodList.Text);
                }

                remPaintConstraints();
                DisableControls();
                totalCostValue.Enabled = true;
                prodList.DropDownStyle = ComboBoxStyle.DropDown;
                editBtn.Enabled = true;
                newBtn.Enabled = true;
                rmBtn.Enabled = true;
                opStatus = null;
            }
        }

        private void rmBtn_Click(object sender, EventArgs e)
        {
            if(prodList.Items.Contains(prodList.Text))
            {
                string message = "Are you sure you want to remove the current product selection?";
                string title = "Remove Product";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if(result == DialogResult.Yes)
                {
                    Program.sqlFunc.Delete($"delete from products where product = '{prodList.Text}' and barcode = '{barcodeValue.Text}'");
                    prodList.Items.Remove(prodList.Text);
                    prodList.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid product!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DisableControls();
            UnPaintUnresolvedFields();
            totalCostValue.Enabled = true;
            editBtn.Enabled = true;
            newBtn.Enabled = true;
            rmBtn.Enabled = true;

            opStatus = null;
            remPaintConstraints();
            restoreInfoFields();
        }

        private void AddDimensionsEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateDimensions_TextChanged;
        }

        private void AddBarcodeEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateBarcode_TextChanged;
        }

        private void AddIntegerEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateInteger_TextChanged;
        }

        private void AddDecimalEventHandler(Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            textBox.TextChanged += ValidateDecimal_TextChanged;
        }

        private bool isValidBarcode(string text)
        {
            if(text.Trim().Length < 12)
            {
                return false;
            }
            else if(text.Contains(".") || !Int64.TryParse(text, out _))
            {
                return false;
            }

            return true;
        }

        private bool isValidDecimal(string text)
        {
            if((text.IndexOf(".") != text.LastIndexOf(".")) || !double.TryParse(text, out _))
            {
                return false;
            }

            return true;
        }

        private bool isValidInteger(string text)
        {
            if(text.Contains(".") || !int.TryParse(text, out _))
            {
                return false;
            }

            return true;
        }

        private void ValidateBarcode_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if(!isValidBarcode(textBox.Text) && textBox.Text != "" && opStatus != null)
            {
                textBox.FillColor = Color.FromArgb(255, 192, 192);
                textBox.IconRight = infoFieldsWarnIcon;
            }
            else if(textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void ValidateInteger_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if(!isValidInteger(textBox.Text) && textBox.Text != "" && opStatus != null)
            {
                textBox.FillColor = Color.FromArgb(255, 192, 192);
                textBox.IconRight = infoFieldsWarnIcon;
            }
            else if(textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void ValidateDecimal_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if(!isValidDecimal(textBox.Text) && textBox.Text != "" && opStatus != null)
            {
                textBox.FillColor = Color.FromArgb(255, 192, 192);
                textBox.IconRight = infoFieldsWarnIcon;
            }
            else if(textBox.IconRight != null)
            {
                textBox.FillColor = SystemColors.Window;
                textBox.IconRight = null;
            }
        }

        private void ValidateDimensions_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;

            if(textBox.FillColor == Color.FromArgb(225, 225, 255))
            {
                for(int i = 3; i < 6; i++)
                {
                    infoFields[i].FillColor = SystemColors.Window;
                    infoFields[i].IconRight = null;
                }
            }
        }

        #region Archived Code Snippet
        /*
            //To add type contraint (integers) to TextBox; also watches out forCTRL + V invalid pastes
            private void IntegerOnly_KeyPress(object sender, KeyPressEventArgs e)
            {
                var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
                char ch = e.KeyChar;

                e.Handled = (ch == '.' || !int.TryParse(e.KeyChar.ToString(), out _) && ch != 8 && ch != 46) && !(char.IsControl(ch) && int.TryParse(Clipboard.GetText(), out _));
            }

            //To add type contraint (decimals) to TextBox; also watches out forCTRL + V invalid pastes
            private void DecimalOnly_KeyPress(object sender, KeyPressEventArgs e)
            {
                var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
                char ch = e.KeyChar;

                e.Handled = ((ch == '.' && textBox.Text.IndexOf('.') > -1) || (!int.TryParse(e.KeyChar.ToString(), out _) && ch != 8 && ch != 46))
                       && !(char.IsControl(ch) && int.TryParse(Clipboard.GetText(), out _));
            }
        */
        #endregion
    }
}
