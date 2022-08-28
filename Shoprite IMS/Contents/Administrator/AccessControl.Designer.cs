
namespace Shoprite_IMS.Contents.Administrator
{
    partial class AccessControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.editBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telephoneValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.employeeTable);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(520, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // employeeTable
            // 
            this.employeeTable.AllowUserToAddRows = false;
            this.employeeTable.AllowUserToOrderColumns = true;
            this.employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeeTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.employeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employeeTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTable.GridColor = System.Drawing.SystemColors.Window;
            this.employeeTable.Location = new System.Drawing.Point(10, 79);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.ReadOnly = true;
            this.employeeTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeeTable.RowHeadersVisible = false;
            this.employeeTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeTable.Size = new System.Drawing.Size(500, 229);
            this.employeeTable.TabIndex = 8;
            this.employeeTable.SelectionChanged += new System.EventHandler(this.employeeTable_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.searchIcon);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 29);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 1;
            // 
            // newBtn
            // 
            this.newBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newBtn.BackColor = System.Drawing.Color.Transparent;
            this.newBtn.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.newBtn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.newBtn.ImageRotate = 0F;
            this.newBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.newBtn.IndicateFocus = true;
            this.newBtn.Location = new System.Drawing.Point(381, 3);
            this.newBtn.Name = "newBtn";
            this.newBtn.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.newBtn.Size = new System.Drawing.Size(24, 24);
            this.newBtn.TabIndex = 11;
            this.newBtn.UseTransparentBackground = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.CheckedState.ImageSize = new System.Drawing.Size(16, 16);
            this.editBtn.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.editBtn.ImageRotate = 0F;
            this.editBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.editBtn.IndicateFocus = true;
            this.editBtn.Location = new System.Drawing.Point(411, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.editBtn.Size = new System.Drawing.Size(24, 24);
            this.editBtn.TabIndex = 10;
            this.editBtn.UseTransparentBackground = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(441, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.deleteBtn.Size = new System.Drawing.Size(24, 24);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.UseTransparentBackground = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.refreshBtn.Location = new System.Drawing.Point(471, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.PressedState.ImageSize = new System.Drawing.Size(12, 12);
            this.refreshBtn.Size = new System.Drawing.Size(24, 24);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.UseTransparentBackground = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(5, 2);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(24, 25);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon.TabIndex = 7;
            this.searchIcon.TabStop = false;
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
            this.searchBox.Location = new System.Drawing.Point(35, 3);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(200, 24);
            this.searchBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.statusList);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cancelBtn);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Controls.Add(this.passwordValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.emailValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.telephoneValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lastNameValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.firstNameValue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.usernameValue);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.groupBox2.Location = new System.Drawing.Point(40, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(520, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor";
            // 
            // statusList
            // 
            this.statusList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statusList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusList.Enabled = false;
            this.statusList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.statusList.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusList.ForeColor = System.Drawing.SystemColors.GrayText;
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            "Administrator",
            "Attendant"});
            this.statusList.Location = new System.Drawing.Point(81, 167);
            this.statusList.Margin = new System.Windows.Forms.Padding(3, 3, 10, 40);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(150, 24);
            this.statusList.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(33, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Status :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.cancelBtn.BorderThickness = 1;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.Enabled = false;
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(290, 167);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelBtn.Size = new System.Drawing.Size(101, 24);
            this.cancelBtn.TabIndex = 53;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.Enabled = false;
            this.saveBtn.FillColor = System.Drawing.Color.White;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.LavenderBlush;
            this.saveBtn.Location = new System.Drawing.Point(406, 167);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.saveBtn.Size = new System.Drawing.Size(101, 24);
            this.saveBtn.TabIndex = 52;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passwordValue
            // 
            this.passwordValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordValue.DefaultText = "";
            this.passwordValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordValue.Enabled = false;
            this.passwordValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.passwordValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordValue.IconRightSize = new System.Drawing.Size(16, 16);
            this.passwordValue.Location = new System.Drawing.Point(357, 111);
            this.passwordValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.PasswordChar = '\0';
            this.passwordValue.PlaceholderText = "";
            this.passwordValue.SelectedText = "";
            this.passwordValue.Size = new System.Drawing.Size(150, 24);
            this.passwordValue.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(292, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Password :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // emailValue
            // 
            this.emailValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailValue.DefaultText = "";
            this.emailValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailValue.Enabled = false;
            this.emailValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emailValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailValue.IconRightSize = new System.Drawing.Size(16, 16);
            this.emailValue.Location = new System.Drawing.Point(357, 74);
            this.emailValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.emailValue.Name = "emailValue";
            this.emailValue.PasswordChar = '\0';
            this.emailValue.PlaceholderText = "";
            this.emailValue.SelectedText = "";
            this.emailValue.Size = new System.Drawing.Size(150, 24);
            this.emailValue.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(314, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Email :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // telephoneValue
            // 
            this.telephoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.telephoneValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telephoneValue.DefaultText = "";
            this.telephoneValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telephoneValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telephoneValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telephoneValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telephoneValue.Enabled = false;
            this.telephoneValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telephoneValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.telephoneValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telephoneValue.IconRightSize = new System.Drawing.Size(16, 16);
            this.telephoneValue.Location = new System.Drawing.Point(357, 37);
            this.telephoneValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.telephoneValue.Name = "telephoneValue";
            this.telephoneValue.PasswordChar = '\0';
            this.telephoneValue.PlaceholderText = "";
            this.telephoneValue.SelectedText = "";
            this.telephoneValue.Size = new System.Drawing.Size(150, 24);
            this.telephoneValue.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(287, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Telephone :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameValue.DefaultText = "";
            this.lastNameValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameValue.Enabled = false;
            this.lastNameValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lastNameValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameValue.IconRightSize = new System.Drawing.Size(16, 16);
            this.lastNameValue.Location = new System.Drawing.Point(81, 111);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.PasswordChar = '\0';
            this.lastNameValue.PlaceholderText = "";
            this.lastNameValue.SelectedText = "";
            this.lastNameValue.Size = new System.Drawing.Size(150, 24);
            this.lastNameValue.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Username :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameValue.DefaultText = "";
            this.firstNameValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameValue.Enabled = false;
            this.firstNameValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.firstNameValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameValue.IconRightSize = new System.Drawing.Size(16, 16);
            this.firstNameValue.Location = new System.Drawing.Point(81, 74);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.PasswordChar = '\0';
            this.firstNameValue.PlaceholderText = "";
            this.firstNameValue.SelectedText = "";
            this.firstNameValue.Size = new System.Drawing.Size(150, 24);
            this.firstNameValue.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Last Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // usernameValue
            // 
            this.usernameValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameValue.DefaultText = "";
            this.usernameValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameValue.Enabled = false;
            this.usernameValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.usernameValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameValue.IconRight = ((System.Drawing.Image)(resources.GetObject("usernameValue.IconRight")));
            this.usernameValue.IconRightSize = new System.Drawing.Size(16, 16);
            this.usernameValue.Location = new System.Drawing.Point(81, 37);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.PasswordChar = '\0';
            this.usernameValue.PlaceholderText = "";
            this.usernameValue.SelectedText = "";
            this.usernameValue.Size = new System.Drawing.Size(150, 24);
            this.usernameValue.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(11, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "First Name :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AccessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccessControl";
            this.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.Size = new System.Drawing.Size(600, 600);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox passwordValue;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox emailValue;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox telephoneValue;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox lastNameValue;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox firstNameValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox usernameValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton deleteBtn;
        private Guna.UI2.WinForms.Guna2ImageButton refreshBtn;
        private System.Windows.Forms.PictureBox searchIcon;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.DataGridView employeeTable;
        private Guna.UI2.WinForms.Guna2ImageButton newBtn;
        private Guna.UI2.WinForms.Guna2ImageButton editBtn;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label label6;
    }
}
