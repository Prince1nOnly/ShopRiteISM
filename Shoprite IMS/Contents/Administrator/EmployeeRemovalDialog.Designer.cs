namespace Shoprite_IMS.Contents.Administrator
{
    partial class EmployeeRemovalDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRemovalDialog));
            this.reasonList = new System.Windows.Forms.ComboBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionBoxLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.removalListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // reasonList
            // 
            this.reasonList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonList.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonList.ForeColor = System.Drawing.SystemColors.GrayText;
            this.reasonList.FormattingEnabled = true;
            this.reasonList.Items.AddRange(new object[] {
            "Died",
            "Layed Off",
            "Resigned",
            "Retired",
            "Terminated",
            "Other (Description Required)"});
            this.reasonList.Location = new System.Drawing.Point(228, 34);
            this.reasonList.Name = "reasonList";
            this.reasonList.Size = new System.Drawing.Size(191, 21);
            this.reasonList.TabIndex = 2;
            this.reasonList.SelectedIndexChanged += new System.EventHandler(this.reasonList_SelectedIndexChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descriptionBox.Location = new System.Drawing.Point(228, 100);
            this.descriptionBox.MaxLength = 250;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(194, 130);
            this.descriptionBox.TabIndex = 3;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reason";
            // 
            // descriptionBoxLabel
            // 
            this.descriptionBoxLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBoxLabel.Image = ((System.Drawing.Image)(resources.GetObject("descriptionBoxLabel.Image")));
            this.descriptionBoxLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.descriptionBoxLabel.Location = new System.Drawing.Point(225, 72);
            this.descriptionBoxLabel.Name = "descriptionBoxLabel";
            this.descriptionBoxLabel.Size = new System.Drawing.Size(194, 16);
            this.descriptionBoxLabel.TabIndex = 9;
            this.descriptionBoxLabel.Text = "Description (Optional)";
            this.descriptionBoxLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.cancelBtn.BorderThickness = 1;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(228, 274);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelBtn.Size = new System.Drawing.Size(80, 24);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.LavenderBlush;
            this.saveBtn.Location = new System.Drawing.Point(339, 274);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveBtn.Size = new System.Drawing.Size(80, 24);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.characterCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCountLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.characterCountLabel.Location = new System.Drawing.Point(225, 233);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(194, 20);
            this.characterCountLabel.TabIndex = 12;
            this.characterCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // removalListBox
            // 
            this.removalListBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.removalListBox.FormattingEnabled = true;
            this.removalListBox.Location = new System.Drawing.Point(12, 34);
            this.removalListBox.Name = "removalListBox";
            this.removalListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.removalListBox.Size = new System.Drawing.Size(191, 264);
            this.removalListBox.TabIndex = 13;
            this.removalListBox.SelectedIndexChanged += new System.EventHandler(this.removalListBox_SelectedIndexChanged);
            // 
            // EmployeeRemovalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.removalListBox);
            this.Controls.Add(this.characterCountLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.descriptionBoxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.reasonList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeRemovalDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remove Employees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeRemovalDialog_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox reasonList;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label descriptionBoxLabel;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.ListBox removalListBox;
    }
}