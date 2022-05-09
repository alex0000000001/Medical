﻿
namespace Medical
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.SideNav = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SideNavButtonContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.BtnMyDoctor = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneRatingStar1 = new Siticone.Desktop.UI.WinForms.SiticoneRatingStar();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SettingBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SalesBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.LogonBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DashboardBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DragPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.BtnArticle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnInfo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnStore = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnDoctorTeam = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnTreatment = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnClinic = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ReportsBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TopHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SideNav.SuspendLayout();
            this.SideNavButtonContainer.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.TopHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.SideNav.Controls.Add(this.SideNavButtonContainer);
            this.SideNav.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SideNav.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.SideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.SideNav.Location = new System.Drawing.Point(0, 87);
            this.SideNav.MaximumSize = new System.Drawing.Size(170, 0);
            this.SideNav.MinimumSize = new System.Drawing.Size(55, 0);
            this.SideNav.Name = "SideNav";
            this.SideNav.ShadowDecoration.Parent = this.SideNav;
            this.SideNav.Size = new System.Drawing.Size(170, 611);
            this.SideNav.TabIndex = 0;
            // 
            // SideNavButtonContainer
            // 
            this.SideNavButtonContainer.BackColor = System.Drawing.Color.Transparent;
            this.SideNavButtonContainer.Controls.Add(this.BtnMyDoctor);
            this.SideNavButtonContainer.Controls.Add(this.siticoneRatingStar1);
            this.SideNavButtonContainer.Controls.Add(this.siticoneHtmlLabel2);
            this.SideNavButtonContainer.Controls.Add(this.SettingBtn);
            this.SideNavButtonContainer.Controls.Add(this.SalesBtn);
            this.SideNavButtonContainer.Controls.Add(this.LogonBtn);
            this.SideNavButtonContainer.Controls.Add(this.DashboardBtn);
            this.SideNavButtonContainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SideNavButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideNavButtonContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SideNavButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.SideNavButtonContainer.Name = "SideNavButtonContainer";
            this.SideNavButtonContainer.ShadowDecoration.Parent = this.SideNavButtonContainer;
            this.SideNavButtonContainer.Size = new System.Drawing.Size(170, 611);
            this.SideNavButtonContainer.TabIndex = 1;
            // 
            // BtnMyDoctor
            // 
            this.BtnMyDoctor.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnMyDoctor.CheckedState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.BtnMyDoctor.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BtnMyDoctor.CheckedState.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnMyDoctor.CheckedState.Image = global::Medical.Properties.Resources.settings_dark;
            this.BtnMyDoctor.CheckedState.Parent = this.BtnMyDoctor;
            this.BtnMyDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMyDoctor.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.BtnMyDoctor.CustomImages.Parent = this.BtnMyDoctor;
            this.BtnMyDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMyDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMyDoctor.DisabledState.FillColor = System.Drawing.Color.Black;
            this.BtnMyDoctor.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.BtnMyDoctor.DisabledState.Parent = this.BtnMyDoctor;
            this.BtnMyDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMyDoctor.FillColor = System.Drawing.Color.Transparent;
            this.BtnMyDoctor.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnMyDoctor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnMyDoctor.ForeColor = System.Drawing.Color.Black;
            this.BtnMyDoctor.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnMyDoctor.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnMyDoctor.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnMyDoctor.HoverState.Parent = this.BtnMyDoctor;
            this.BtnMyDoctor.Image = global::Medical.Properties.Resources.settings_dark;
            this.BtnMyDoctor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMyDoctor.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnMyDoctor.Location = new System.Drawing.Point(0, 200);
            this.BtnMyDoctor.Name = "BtnMyDoctor";
            this.BtnMyDoctor.ShadowDecoration.Parent = this.BtnMyDoctor;
            this.BtnMyDoctor.Size = new System.Drawing.Size(170, 50);
            this.BtnMyDoctor.TabIndex = 14;
            this.BtnMyDoctor.Text = "MyDoctor";
            this.BtnMyDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMyDoctor.TextOffset = new System.Drawing.Point(20, 0);
            this.BtnMyDoctor.Click += new System.EventHandler(this.BtnMyDoctor_Click);
            // 
            // siticoneRatingStar1
            // 
            this.siticoneRatingStar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.siticoneRatingStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneRatingStar1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRatingStar1.Location = new System.Drawing.Point(12, 468);
            this.siticoneRatingStar1.Name = "siticoneRatingStar1";
            this.siticoneRatingStar1.RatingColor = System.Drawing.Color.Cyan;
            this.siticoneRatingStar1.Size = new System.Drawing.Size(120, 28);
            this.siticoneRatingStar1.TabIndex = 13;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(14, 450);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(30, 17);
            this.siticoneHtmlLabel2.TabIndex = 12;
            this.siticoneHtmlLabel2.Text = "RATE";
            // 
            // SettingBtn
            // 
            this.SettingBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.SettingBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.SettingBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SettingBtn.CheckedState.ForeColor = System.Drawing.Color.Fuchsia;
            this.SettingBtn.CheckedState.Image = global::Medical.Properties.Resources.settings_dark;
            this.SettingBtn.CheckedState.Parent = this.SettingBtn;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SettingBtn.CustomImages.Parent = this.SettingBtn;
            this.SettingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingBtn.DisabledState.FillColor = System.Drawing.Color.Black;
            this.SettingBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.SettingBtn.DisabledState.Parent = this.SettingBtn;
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FillColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.SettingBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SettingBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.SettingBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SettingBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.HoverState.Parent = this.SettingBtn;
            this.SettingBtn.Image = global::Medical.Properties.Resources.settings_dark;
            this.SettingBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.SettingBtn.Location = new System.Drawing.Point(0, 150);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.ShadowDecoration.Parent = this.SettingBtn;
            this.SettingBtn.Size = new System.Drawing.Size(170, 50);
            this.SettingBtn.TabIndex = 6;
            this.SettingBtn.Text = "Settings";
            this.SettingBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.SalesBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.SalesBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SalesBtn.CheckedState.ForeColor = System.Drawing.Color.Fuchsia;
            this.SalesBtn.CheckedState.Image = global::Medical.Properties.Resources.sales_dark;
            this.SalesBtn.CheckedState.Parent = this.SalesBtn;
            this.SalesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SalesBtn.CustomImages.Parent = this.SalesBtn;
            this.SalesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesBtn.DisabledState.FillColor = System.Drawing.Color.Black;
            this.SalesBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.SalesBtn.DisabledState.Parent = this.SalesBtn;
            this.SalesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesBtn.FillColor = System.Drawing.Color.Transparent;
            this.SalesBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.SalesBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SalesBtn.ForeColor = System.Drawing.Color.Black;
            this.SalesBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.SalesBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SalesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SalesBtn.HoverState.Parent = this.SalesBtn;
            this.SalesBtn.Image = global::Medical.Properties.Resources.sales_dark;
            this.SalesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.SalesBtn.Location = new System.Drawing.Point(0, 100);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.ShadowDecoration.Parent = this.SalesBtn;
            this.SalesBtn.Size = new System.Drawing.Size(170, 50);
            this.SalesBtn.TabIndex = 4;
            this.SalesBtn.Text = "ShoppingCart";
            this.SalesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // LogonBtn
            // 
            this.LogonBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.LogonBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.LogonBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LogonBtn.CheckedState.ForeColor = System.Drawing.Color.Fuchsia;
            this.LogonBtn.CheckedState.Image = global::Medical.Properties.Resources.chat_dark;
            this.LogonBtn.CheckedState.Parent = this.LogonBtn;
            this.LogonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogonBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.LogonBtn.CustomImages.Parent = this.LogonBtn;
            this.LogonBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogonBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogonBtn.DisabledState.FillColor = System.Drawing.Color.Black;
            this.LogonBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.LogonBtn.DisabledState.Parent = this.LogonBtn;
            this.LogonBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogonBtn.FillColor = System.Drawing.Color.Transparent;
            this.LogonBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.LogonBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LogonBtn.ForeColor = System.Drawing.Color.Black;
            this.LogonBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.LogonBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.LogonBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.LogonBtn.HoverState.Parent = this.LogonBtn;
            this.LogonBtn.Image = global::Medical.Properties.Resources.chat_dark;
            this.LogonBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogonBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.LogonBtn.Location = new System.Drawing.Point(0, 50);
            this.LogonBtn.Name = "LogonBtn";
            this.LogonBtn.ShadowDecoration.Parent = this.LogonBtn;
            this.LogonBtn.Size = new System.Drawing.Size(170, 50);
            this.LogonBtn.TabIndex = 2;
            this.LogonBtn.Text = "Logon";
            this.LogonBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogonBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.LogonBtn.Click += new System.EventHandler(this.BtnLogon_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.DashboardBtn.Checked = true;
            this.DashboardBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.DashboardBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.CheckedState.ForeColor = System.Drawing.Color.Fuchsia;
            this.DashboardBtn.CheckedState.Image = global::Medical.Properties.Resources.dashboard_dark;
            this.DashboardBtn.CheckedState.Parent = this.DashboardBtn;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.DashboardBtn.CustomImages.Parent = this.DashboardBtn;
            this.DashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardBtn.DisabledState.FillColor = System.Drawing.Color.Black;
            this.DashboardBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.DashboardBtn.DisabledState.Parent = this.DashboardBtn;
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DashboardBtn.ForeColor = System.Drawing.Color.Black;
            this.DashboardBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.DashboardBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.DashboardBtn.HoverState.Parent = this.DashboardBtn;
            this.DashboardBtn.Image = global::Medical.Properties.Resources.dashboard_dark;
            this.DashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.DashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.ShadowDecoration.Parent = this.DashboardBtn;
            this.DashboardBtn.Size = new System.Drawing.Size(170, 50);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Menu";
            this.DashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.Controls.Add(this.BtnArticle);
            this.DragPanel.Controls.Add(this.BtnInfo);
            this.DragPanel.Controls.Add(this.BtnStore);
            this.DragPanel.Controls.Add(this.BtnDoctorTeam);
            this.DragPanel.Controls.Add(this.BtnTreatment);
            this.DragPanel.Controls.Add(this.BtnClinic);
            this.DragPanel.Controls.Add(this.ReportsBtn);
            this.DragPanel.Controls.Add(this.TopHeader);
            this.DragPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DragPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DragPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.ShadowDecoration.Parent = this.DragPanel;
            this.DragPanel.Size = new System.Drawing.Size(1277, 87);
            this.DragPanel.TabIndex = 1;
            // 
            // BtnArticle
            // 
            this.BtnArticle.Animated = true;
            this.BtnArticle.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnArticle.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnArticle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnArticle.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnArticle.CheckedState.Parent = this.BtnArticle;
            this.BtnArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArticle.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnArticle.CustomImages.Parent = this.BtnArticle;
            this.BtnArticle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnArticle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnArticle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnArticle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnArticle.DisabledState.Parent = this.BtnArticle;
            this.BtnArticle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnArticle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArticle.ForeColor = System.Drawing.Color.DimGray;
            this.BtnArticle.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnArticle.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnArticle.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnArticle.HoverState.Parent = this.BtnArticle;
            this.BtnArticle.Location = new System.Drawing.Point(958, 42);
            this.BtnArticle.Name = "BtnArticle";
            this.BtnArticle.PressedColor = System.Drawing.Color.White;
            this.BtnArticle.ShadowDecoration.Parent = this.BtnArticle;
            this.BtnArticle.Size = new System.Drawing.Size(154, 45);
            this.BtnArticle.TabIndex = 7;
            this.BtnArticle.Text = "衛教保健";
            this.BtnArticle.Click += new System.EventHandler(this.BtnArticle_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Animated = true;
            this.BtnInfo.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnInfo.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnInfo.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.CheckedState.Parent = this.BtnInfo;
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnInfo.CustomImages.Parent = this.BtnInfo;
            this.BtnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnInfo.DisabledState.Parent = this.BtnInfo;
            this.BtnInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.ForeColor = System.Drawing.Color.DimGray;
            this.BtnInfo.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnInfo.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.HoverState.Parent = this.BtnInfo;
            this.BtnInfo.Location = new System.Drawing.Point(798, 42);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.PressedColor = System.Drawing.Color.White;
            this.BtnInfo.ShadowDecoration.Parent = this.BtnInfo;
            this.BtnInfo.Size = new System.Drawing.Size(154, 45);
            this.BtnInfo.TabIndex = 6;
            this.BtnInfo.Text = "網站資訊";
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnStore
            // 
            this.BtnStore.Animated = true;
            this.BtnStore.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnStore.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnStore.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnStore.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnStore.CheckedState.Parent = this.BtnStore;
            this.BtnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStore.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnStore.CustomImages.Parent = this.BtnStore;
            this.BtnStore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStore.DisabledState.Parent = this.BtnStore;
            this.BtnStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnStore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStore.ForeColor = System.Drawing.Color.DimGray;
            this.BtnStore.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnStore.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnStore.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnStore.HoverState.Parent = this.BtnStore;
            this.BtnStore.Location = new System.Drawing.Point(638, 42);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.PressedColor = System.Drawing.Color.White;
            this.BtnStore.ShadowDecoration.Parent = this.BtnStore;
            this.BtnStore.Size = new System.Drawing.Size(154, 45);
            this.BtnStore.TabIndex = 5;
            this.BtnStore.Text = "線上商城";
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // BtnDoctorTeam
            // 
            this.BtnDoctorTeam.Animated = true;
            this.BtnDoctorTeam.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnDoctorTeam.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnDoctorTeam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnDoctorTeam.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnDoctorTeam.CheckedState.Parent = this.BtnDoctorTeam;
            this.BtnDoctorTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoctorTeam.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnDoctorTeam.CustomImages.Parent = this.BtnDoctorTeam;
            this.BtnDoctorTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDoctorTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDoctorTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDoctorTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDoctorTeam.DisabledState.Parent = this.BtnDoctorTeam;
            this.BtnDoctorTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnDoctorTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctorTeam.ForeColor = System.Drawing.Color.DimGray;
            this.BtnDoctorTeam.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnDoctorTeam.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnDoctorTeam.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDoctorTeam.HoverState.Parent = this.BtnDoctorTeam;
            this.BtnDoctorTeam.Location = new System.Drawing.Point(478, 41);
            this.BtnDoctorTeam.Name = "BtnDoctorTeam";
            this.BtnDoctorTeam.PressedColor = System.Drawing.Color.White;
            this.BtnDoctorTeam.ShadowDecoration.Parent = this.BtnDoctorTeam;
            this.BtnDoctorTeam.Size = new System.Drawing.Size(154, 45);
            this.BtnDoctorTeam.TabIndex = 4;
            this.BtnDoctorTeam.Text = "醫療團隊";
            this.BtnDoctorTeam.Click += new System.EventHandler(this.BtnDoctorTeam_Click);
            // 
            // BtnTreatment
            // 
            this.BtnTreatment.Animated = true;
            this.BtnTreatment.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnTreatment.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnTreatment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnTreatment.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnTreatment.CheckedState.Parent = this.BtnTreatment;
            this.BtnTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTreatment.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnTreatment.CustomImages.Parent = this.BtnTreatment;
            this.BtnTreatment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTreatment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTreatment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTreatment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTreatment.DisabledState.Parent = this.BtnTreatment;
            this.BtnTreatment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnTreatment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTreatment.ForeColor = System.Drawing.Color.DimGray;
            this.BtnTreatment.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnTreatment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnTreatment.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnTreatment.HoverState.Parent = this.BtnTreatment;
            this.BtnTreatment.Location = new System.Drawing.Point(324, 41);
            this.BtnTreatment.Name = "BtnTreatment";
            this.BtnTreatment.PressedColor = System.Drawing.Color.White;
            this.BtnTreatment.ShadowDecoration.Parent = this.BtnTreatment;
            this.BtnTreatment.Size = new System.Drawing.Size(154, 45);
            this.BtnTreatment.TabIndex = 3;
            this.BtnTreatment.Text = "服務項目";
            this.BtnTreatment.Click += new System.EventHandler(this.BtnTreatment_Click);
            // 
            // BtnClinic
            // 
            this.BtnClinic.Animated = true;
            this.BtnClinic.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnClinic.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnClinic.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnClinic.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnClinic.CheckedState.Parent = this.BtnClinic;
            this.BtnClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClinic.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnClinic.CustomImages.Parent = this.BtnClinic;
            this.BtnClinic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClinic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClinic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClinic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClinic.DisabledState.Parent = this.BtnClinic;
            this.BtnClinic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnClinic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClinic.ForeColor = System.Drawing.Color.DimGray;
            this.BtnClinic.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnClinic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnClinic.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnClinic.HoverState.Parent = this.BtnClinic;
            this.BtnClinic.Location = new System.Drawing.Point(170, 41);
            this.BtnClinic.Name = "BtnClinic";
            this.BtnClinic.PressedColor = System.Drawing.Color.White;
            this.BtnClinic.ShadowDecoration.Parent = this.BtnClinic;
            this.BtnClinic.Size = new System.Drawing.Size(154, 45);
            this.BtnClinic.TabIndex = 2;
            this.BtnClinic.Text = "門診資訊";
            this.BtnClinic.Click += new System.EventHandler(this.BtnClinic_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Animated = true;
            this.ReportsBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.ReportsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.ReportsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ReportsBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.CheckedState.Parent = this.ReportsBtn;
            this.ReportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ReportsBtn.CustomImages.Parent = this.ReportsBtn;
            this.ReportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportsBtn.DisabledState.Parent = this.ReportsBtn;
            this.ReportsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ReportsBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ReportsBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.ReportsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ReportsBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.HoverState.Parent = this.ReportsBtn;
            this.ReportsBtn.Location = new System.Drawing.Point(16, 41);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.PressedColor = System.Drawing.Color.White;
            this.ReportsBtn.ShadowDecoration.Parent = this.ReportsBtn;
            this.ReportsBtn.Size = new System.Drawing.Size(154, 45);
            this.ReportsBtn.TabIndex = 1;
            this.ReportsBtn.Text = "線上掛號";
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // TopHeader
            // 
            this.TopHeader.Controls.Add(this.lbRole);
            this.TopHeader.Controls.Add(this.lbMemberID);
            this.TopHeader.Controls.Add(this.siticoneControlBox2);
            this.TopHeader.Controls.Add(this.siticoneControlBox1);
            this.TopHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TopHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.TopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.ShadowDecoration.Parent = this.TopHeader;
            this.TopHeader.Size = new System.Drawing.Size(1277, 40);
            this.TopHeader.TabIndex = 0;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(112, 12);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(43, 23);
            this.lbRole.TabIndex = 5;
            this.lbRole.Text = "Role";
            this.lbRole.Visible = false;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(8, 12);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(91, 23);
            this.lbMemberID.TabIndex = 3;
            this.lbMemberID.Text = "MemberID";
            this.lbMemberID.Visible = false;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.siticoneControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1175, 8);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(39, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1226, 8);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(39, 29);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // PanelSlider
            // 
            this.PanelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelSlider.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelSlider.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelSlider.Location = new System.Drawing.Point(165, 87);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(1112, 611);
            this.PanelSlider.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1277, 698);
            this.Controls.Add(this.SideNav);
            this.Controls.Add(this.PanelSlider);
            this.Controls.Add(this.DragPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SideNav.ResumeLayout(false);
            this.SideNavButtonContainer.ResumeLayout(false);
            this.SideNavButtonContainer.PerformLayout();
            this.DragPanel.ResumeLayout(false);
            this.TopHeader.ResumeLayout(false);
            this.TopHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel SideNav;
        private Siticone.Desktop.UI.WinForms.SiticonePanel DragPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel TopHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnDoctorTeam;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnTreatment;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnClinic;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ReportsBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel SideNavButtonContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton DashboardBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SettingBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SalesBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneRatingStar siticoneRatingStar1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private System.Windows.Forms.Timer timer1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnArticle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnInfo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnStore;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnMyDoctor;
        internal Siticone.Desktop.UI.WinForms.SiticonePanel PanelSlider;
        private Siticone.Desktop.UI.WinForms.SiticoneButton LogonBtn;
        internal System.Windows.Forms.Label lbRole;
        internal System.Windows.Forms.Label lbMemberID;
    }
}

