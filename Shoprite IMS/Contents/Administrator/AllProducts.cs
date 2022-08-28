using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace Shoprite_IMS.Contents.Administrator
{
    public partial class AllProducts : UserControl
    {
        private DataTable table = new DataTable();
        private int countInvalid = 0;
        private bool dimensionMissing = false;

        public AllProducts()
        {
            InitializeComponent();
            loadProdTable();
            prodTable.Columns["Product_ID"].Frozen = true;
            prodTable.Columns["Product"].Frozen = true;
        }

        public void loadProdTable()
        {
            string query = "SELECT * from Products";
            Program.sqlFunc.SetTable(query, prodTable, table);
        }

        private bool isValidBarcode(string text)
        {
            if (text.Trim().Length < 12)
            {
                return false;
            }
            else if (text.Contains(".") || !Int64.TryParse(text, out _))
            {
                return false;
            }

            return true;
        }

        private bool isValidDecimal(string text)
        {
            if ((text.IndexOf(".") != text.LastIndexOf(".")) || !double.TryParse(text, out _))
            {
                return false;
            }

            return true;
        }

        private bool isValidInteger(string text)
        {
            if (text.Contains(".") || !int.TryParse(text, out _))
            {
                return false;
            }

            return true;
        }

        private void ValidateFilled_ValueChanged()
        {
            if (prodTable.CurrentCell.Style.BackColor != Color.FromArgb(225, 225, 255) || prodTable.CurrentCell.Value.ToString().Trim() != "")
            {
                prodTable.CurrentCell.Style.BackColor = Color.FromArgb(225, 225, 255);
                countInvalid++;
            }
            else if (prodTable.CurrentCell.Style.BackColor == Color.FromArgb(225, 225, 255))
            {
                prodTable.CurrentCell.Style.BackColor = SystemColors.Window;
                countInvalid--;
            }
        }

        private void ValidateBarcode_ValueChanged()
        {
            if (!isValidBarcode(prodTable.CurrentCell.Value.ToString()) && prodTable.CurrentCell.Style.BackColor != Color.FromArgb(255, 192, 192) || prodTable.CurrentCell.Value.ToString().Trim() != "")
            {
                prodTable.CurrentCell.Style.BackColor = Color.FromArgb(255, 192, 192);
                countInvalid++;
            }
            else if (prodTable.CurrentCell.Style.BackColor == Color.FromArgb(255, 192, 192))
            {
                prodTable.CurrentCell.Style.BackColor = SystemColors.Window;
                countInvalid--;
            }
        }

        private void ValidateInteger_ValueChanged()
        {
            if (!isValidInteger(prodTable.CurrentCell.Value.ToString()) && prodTable.CurrentCell.Style.BackColor != Color.FromArgb(255, 192, 192) || prodTable.CurrentCell.Value.ToString().Trim() != "")
            {
                prodTable.CurrentCell.Style.BackColor = Color.FromArgb(255, 192, 192);
                countInvalid++;
            }
            else if (prodTable.CurrentCell.Style.BackColor == Color.FromArgb(255, 192, 192))
            {
                prodTable.CurrentCell.Style.BackColor = SystemColors.Window;
                countInvalid--;
            }
        }

        private void ValidateDecimal_ValueChanged()
        {
            if(!isValidDecimal(prodTable.CurrentCell.Value.ToString()) && prodTable.CurrentCell.Style.BackColor != Color.FromArgb(255, 192, 192) || prodTable.CurrentCell.Value.ToString().Trim() != "")
            {
                prodTable.CurrentCell.Style.BackColor = Color.FromArgb(255, 192, 192);
                countInvalid++;
            }
            else if(prodTable.CurrentCell.Style.BackColor == Color.FromArgb(255, 192, 192))
            {
                prodTable.CurrentCell.Style.BackColor = SystemColors.Window;
                countInvalid--;
            }
        }

        private void ValidateDimensions_ValueChanged(DataGridViewDataErrorEventArgs e, string column)
        {
            if(prodTable.Rows[e.RowIndex].Cells["Weight"].Value.ToString().Trim() == "" && prodTable.Rows[e.RowIndex].Cells["Volume"].Value.ToString().Trim() == "" && prodTable.Rows[e.RowIndex].Cells["Size"].Value.ToString().Trim() == "")
            {
                MessageBox.Show(column + "must be an integer!");
            }
        }

        private void enableEditingBtn_CheckedChanged(object sender, System.EventArgs e)
        {
            if(enableEditingBtn.Checked == true)
            {
                prodTable.ReadOnly = false;
                prodTable.Columns["Product_ID"].ReadOnly = true;
            }
            else
            {
                prodTable.ReadOnly = true;
            }
        }

        private void refreshBtn_Click(object sender, System.EventArgs e)
        {
            string query = "Select * from products";
            Program.sqlFunc.ReloadTable(query, table);
        }

        private void prodTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string column = prodTable.CurrentCell.OwningColumn.Name;

            
        }

        private void prodTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string column = prodTable.CurrentCell.OwningColumn.Name;

            if (e.Exception is NoNullAllowedException)
            {
                MessageBox.Show(column + "cannot be null!");
                return;
            }
            else if ((e.Exception) is ConstraintException)
            {
                switch (column)
                {
                    case "Barcode":
                        if(!isValidBarcode(prodTable.CurrentCell.Value.ToString())) MessageBox.Show(column + "not valid!");
                        prodTable.CurrentCell.Selected = true;
                        break;
                    case "Quantity":
                    case "Reorder_Level":
                        MessageBox.Show(column + "must be an integer!");
                        break;
                    case "Size":
                    case "Volume":
                    case "Weight":
                        ValidateDimensions_ValueChanged(e, column);
                        break;
                    case "Unit_Cost_Price":
                    case "Unit_Selling_Price":
                    case "Gross_Price":
                        MessageBox.Show(column + "must be an integer or a decimal number!");
                        break;
                    default:
                        break;
                }

                //e.ThrowException = false;
            }
        }
    }
}
