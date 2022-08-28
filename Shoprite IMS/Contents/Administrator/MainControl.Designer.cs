
namespace Shoprite_IMS.Contents.Administrator
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.employeeIDValue = new System.Windows.Forms.Label();
            this.employeeNameValue = new System.Windows.Forms.Label();
            this.profileBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.menuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.manInventBtn = new Guna.UI2.WinForms.Guna2Button();
            this.allProdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.accessControlBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.contentPane = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.sideBar.Controls.Add(this.guna2Panel1);
            this.sideBar.Controls.Add(this.manInventBtn);
            this.sideBar.Controls.Add(this.allProdBtn);
            this.sideBar.Controls.Add(this.accessControlBtn);
            this.sideBar.Controls.Add(this.logsBtn);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.sideBar.MinimumSize = new System.Drawing.Size(50, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(200, 600);
            this.sideBar.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.employeeIDValue);
            this.guna2Panel1.Controls.Add(this.employeeNameValue);
            this.guna2Panel1.Controls.Add(this.profileBtn);
            this.guna2Panel1.Controls.Add(this.menuBtn);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 150);
            this.guna2Panel1.TabIndex = 5;
            // 
            // employeeIDValue
            // 
            this.employeeIDValue.AutoSize = true;
            this.employeeIDValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDValue.ForeColor = System.Drawing.Color.White;
            this.employeeIDValue.Location = new System.Drawing.Point(57, 37);
            this.employeeIDValue.Name = "employeeIDValue";
            this.employeeIDValue.Size = new System.Drawing.Size(46, 11);
            this.employeeIDValue.TabIndex = 3;
            this.employeeIDValue.Text = "Employee #";
            // 
            // employeeNameValue
            // 
            this.employeeNameValue.AutoSize = true;
            this.employeeNameValue.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameValue.ForeColor = System.Drawing.Color.White;
            this.employeeNameValue.Location = new System.Drawing.Point(57, 53);
            this.employeeNameValue.Name = "employeeNameValue";
            this.employeeNameValue.Size = new System.Drawing.Size(125, 16);
            this.employeeNameValue.TabIndex = 0;
            this.employeeNameValue.Text = "Employee\'s Name";
            // 
            // profileBtn
            // 
            this.profileBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.profileBtn.BorderThickness = 4;
            this.profileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.profileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.profileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.profileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.profileBtn.FillColor = System.Drawing.Color.White;
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.profileBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.profileBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.profileBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(3, 28);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.profileBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profileBtn.Size = new System.Drawing.Size(48, 48);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuBtn.FillColor = System.Drawing.Color.Transparent;
            this.menuBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menuBtn.ImageSize = new System.Drawing.Size(26, 26);
            this.menuBtn.Location = new System.Drawing.Point(0, 94);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuBtn.Size = new System.Drawing.Size(200, 50);
            this.menuBtn.TabIndex = 2;
            this.menuBtn.Text = "Menu";
            this.menuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menuBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // manInventBtn
            // 
            this.manInventBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.manInventBtn.Checked = true;
            this.manInventBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manInventBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.manInventBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manInventBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manInventBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manInventBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manInventBtn.FillColor = System.Drawing.Color.Transparent;
            this.manInventBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manInventBtn.ForeColor = System.Drawing.Color.White;
            this.manInventBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manInventBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.manInventBtn.Image = ((System.Drawing.Image)(resources.GetObject("manInventBtn.Image")));
            this.manInventBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manInventBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.manInventBtn.Location = new System.Drawing.Point(3, 159);
            this.manInventBtn.Name = "manInventBtn";
            this.manInventBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.manInventBtn.Size = new System.Drawing.Size(200, 50);
            this.manInventBtn.TabIndex = 1;
            this.manInventBtn.Text = "Manage Inventory";
            this.manInventBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manInventBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.manInventBtn.Click += new System.EventHandler(this.manInventBtn_Click);
            // 
            // allProdBtn
            // 
            this.allProdBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.allProdBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.allProdBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.allProdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.allProdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.allProdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.allProdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.allProdBtn.FillColor = System.Drawing.Color.Transparent;
            this.allProdBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProdBtn.ForeColor = System.Drawing.Color.White;
            this.allProdBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.allProdBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.allProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("allProdBtn.Image")));
            this.allProdBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allProdBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.allProdBtn.Location = new System.Drawing.Point(3, 215);
            this.allProdBtn.Name = "allProdBtn";
            this.allProdBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.allProdBtn.Size = new System.Drawing.Size(200, 50);
            this.allProdBtn.TabIndex = 3;
            this.allProdBtn.Text = "All Products";
            this.allProdBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allProdBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.allProdBtn.Click += new System.EventHandler(this.allProdBtn_Click);
            // 
            // accessControlBtn
            // 
            this.accessControlBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.accessControlBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accessControlBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.accessControlBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accessControlBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accessControlBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accessControlBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accessControlBtn.FillColor = System.Drawing.Color.Transparent;
            this.accessControlBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessControlBtn.ForeColor = System.Drawing.Color.White;
            this.accessControlBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accessControlBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.accessControlBtn.Image = ((System.Drawing.Image)(resources.GetObject("accessControlBtn.Image")));
            this.accessControlBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accessControlBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.accessControlBtn.Location = new System.Drawing.Point(3, 271);
            this.accessControlBtn.Name = "accessControlBtn";
            this.accessControlBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.accessControlBtn.Size = new System.Drawing.Size(200, 50);
            this.accessControlBtn.TabIndex = 4;
            this.accessControlBtn.Text = "Access Control";
            this.accessControlBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accessControlBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.accessControlBtn.Click += new System.EventHandler(this.accessControlBtn_Click);
            // 
            // logsBtn
            // 
            this.logsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logsBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logsBtn.FillColor = System.Drawing.Color.Transparent;
            this.logsBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsBtn.ForeColor = System.Drawing.Color.White;
            this.logsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logsBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.logsBtn.Image = ((System.Drawing.Image)(resources.GetObject("logsBtn.Image")));
            this.logsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logsBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.logsBtn.Location = new System.Drawing.Point(3, 327);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logsBtn.Size = new System.Drawing.Size(200, 50);
            this.logsBtn.TabIndex = 2;
            this.logsBtn.Text = "Logs";
            this.logsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logsBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.logsBtn.Click += new System.EventHandler(this.logsBtn_Click);
            // 
            // contentPane
            // 
            this.contentPane.BackColor = System.Drawing.SystemColors.Window;
            this.contentPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPane.Location = new System.Drawing.Point(200, 0);
            this.contentPane.Name = "contentPane";
            this.contentPane.Size = new System.Drawing.Size(600, 600);
            this.contentPane.TabIndex = 1;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentPane);
            this.Controls.Add(this.sideBar);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.sideBar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private Guna.UI2.WinForms.Guna2Button manInventBtn;
        private Guna.UI2.WinForms.Guna2Button logsBtn;
        private Guna.UI2.WinForms.Guna2Button allProdBtn;
        private Guna.UI2.WinForms.Guna2Button accessControlBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button menuBtn;
        private System.Windows.Forms.Panel contentPane;
        private System.Windows.Forms.Label employeeNameValue;
        private Guna.UI2.WinForms.Guna2CircleButton profileBtn;
        private System.Windows.Forms.Label employeeIDValue;
    }
}
