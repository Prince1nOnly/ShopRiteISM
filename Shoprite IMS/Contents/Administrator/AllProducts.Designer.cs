
namespace Shoprite_IMS.Contents.Administrator
{
    partial class AllProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.enableEditingBtn = new System.Windows.Forms.CheckBox();
            this.prodTable = new System.Windows.Forms.DataGridView();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(73, 44);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(200, 24);
            this.searchBox.TabIndex = 1;
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(43, 43);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(24, 25);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon.TabIndex = 2;
            this.searchIcon.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.saveBtn.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.saveBtn.ImageRotate = 0F;
            this.saveBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.saveBtn.IndicateFocus = true;
            this.saveBtn.Location = new System.Drawing.Point(533, 44);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PressedState.ImageSize = new System.Drawing.Size(12, 12);
            this.saveBtn.Size = new System.Drawing.Size(24, 24);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.UseTransparentBackground = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.refreshBtn.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.refreshBtn.ImageRotate = 0F;
            this.refreshBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.refreshBtn.IndicateFocus = true;
            this.refreshBtn.Location = new System.Drawing.Point(503, 44);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.PressedState.ImageSize = new System.Drawing.Size(12, 12);
            this.refreshBtn.Size = new System.Drawing.Size(24, 24);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.UseTransparentBackground = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.deleteBtn.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteBtn.ImageRotate = 0F;
            this.deleteBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.deleteBtn.IndicateFocus = true;
            this.deleteBtn.Location = new System.Drawing.Point(473, 44);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.deleteBtn.Size = new System.Drawing.Size(24, 24);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.UseTransparentBackground = true;
            // 
            // enableEditingBtn
            // 
            this.enableEditingBtn.AutoSize = true;
            this.enableEditingBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableEditingBtn.Location = new System.Drawing.Point(286, 48);
            this.enableEditingBtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.enableEditingBtn.Name = "enableEditingBtn";
            this.enableEditingBtn.Size = new System.Drawing.Size(101, 17);
            this.enableEditingBtn.TabIndex = 6;
            this.enableEditingBtn.Text = "Enable Editing";
            this.enableEditingBtn.UseVisualStyleBackColor = true;
            this.enableEditingBtn.CheckedChanged += new System.EventHandler(this.enableEditingBtn_CheckedChanged);
            // 
            // prodTable
            // 
            this.prodTable.AllowUserToAddRows = false;
            this.prodTable.AllowUserToOrderColumns = true;
            this.prodTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.prodTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.prodTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.prodTable.Location = new System.Drawing.Point(40, 94);
            this.prodTable.Name = "prodTable";
            this.prodTable.ReadOnly = true;
            this.prodTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.prodTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.prodTable.Size = new System.Drawing.Size(520, 486);
            this.prodTable.TabIndex = 7;
            this.prodTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodTable_CellValueChanged);
            this.prodTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.prodTable_DataError);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(413, 44);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.TabIndex = 9;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2ImageButton2.IndicateFocus = true;
            this.guna2ImageButton2.Location = new System.Drawing.Point(443, 44);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(12, 12);
            this.guna2ImageButton2.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.TabIndex = 8;
            this.guna2ImageButton2.UseTransparentBackground = true;
            // 
            // AllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.prodTable);
            this.Controls.Add(this.enableEditingBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.searchBox);
            this.Name = "AllProducts";
            this.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.PictureBox searchIcon;
        private Guna.UI2.WinForms.Guna2ImageButton saveBtn;
        private Guna.UI2.WinForms.Guna2ImageButton refreshBtn;
        private Guna.UI2.WinForms.Guna2ImageButton deleteBtn;
        private System.Windows.Forms.CheckBox enableEditingBtn;
        private System.Windows.Forms.DataGridView prodTable;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
    }
}
