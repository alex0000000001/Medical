
namespace Medical.UserControls
{
    partial class MyDoctor
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
            this.Header = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbDoctorID = new System.Windows.Forms.Label();
            this.BtnWork = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnPaitent = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnClinic = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.Header.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Header.Controls.Add(this.lbDoctorID);
            this.Header.Controls.Add(this.BtnWork);
            this.Header.Controls.Add(this.BtnPaitent);
            this.Header.Controls.Add(this.BtnClinic);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.ShadowDecoration.Parent = this.Header;
            this.Header.Size = new System.Drawing.Size(1138, 52);
            this.Header.TabIndex = 1;
            // 
            // lbDoctorID
            // 
            this.lbDoctorID.AutoSize = true;
            this.lbDoctorID.Location = new System.Drawing.Point(1070, 17);
            this.lbDoctorID.Name = "lbDoctorID";
            this.lbDoctorID.Size = new System.Drawing.Size(79, 23);
            this.lbDoctorID.TabIndex = 5;
            this.lbDoctorID.Text = "DoctorID";
            // 
            // BtnWork
            // 
            this.BtnWork.Animated = true;
            this.BtnWork.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnWork.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnWork.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnWork.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnWork.CheckedState.Parent = this.BtnWork;
            this.BtnWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWork.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnWork.CustomImages.Parent = this.BtnWork;
            this.BtnWork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnWork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnWork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnWork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnWork.DisabledState.Parent = this.BtnWork;
            this.BtnWork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnWork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWork.ForeColor = System.Drawing.Color.DimGray;
            this.BtnWork.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnWork.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnWork.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnWork.HoverState.Parent = this.BtnWork;
            this.BtnWork.Location = new System.Drawing.Point(171, 6);
            this.BtnWork.Name = "BtnWork";
            this.BtnWork.PressedColor = System.Drawing.Color.White;
            this.BtnWork.ShadowDecoration.Parent = this.BtnWork;
            this.BtnWork.Size = new System.Drawing.Size(154, 45);
            this.BtnWork.TabIndex = 4;
            this.BtnWork.Text = "醫生工作區";
            this.BtnWork.Click += new System.EventHandler(this.BtnWork_Click);
            // 
            // BtnPaitent
            // 
            this.BtnPaitent.Animated = true;
            this.BtnPaitent.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPaitent.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.BtnPaitent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnPaitent.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnPaitent.CheckedState.Parent = this.BtnPaitent;
            this.BtnPaitent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPaitent.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnPaitent.CustomImages.Parent = this.BtnPaitent;
            this.BtnPaitent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPaitent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPaitent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPaitent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPaitent.DisabledState.Parent = this.BtnPaitent;
            this.BtnPaitent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnPaitent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaitent.ForeColor = System.Drawing.Color.DimGray;
            this.BtnPaitent.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnPaitent.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnPaitent.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnPaitent.HoverState.Parent = this.BtnPaitent;
            this.BtnPaitent.Location = new System.Drawing.Point(332, 3);
            this.BtnPaitent.Name = "BtnPaitent";
            this.BtnPaitent.PressedColor = System.Drawing.Color.White;
            this.BtnPaitent.ShadowDecoration.Parent = this.BtnPaitent;
            this.BtnPaitent.Size = new System.Drawing.Size(154, 45);
            this.BtnPaitent.TabIndex = 3;
            this.BtnPaitent.Text = "我的病患";
            this.BtnPaitent.Visible = false;
            this.BtnPaitent.Click += new System.EventHandler(this.BtnPaitent_Click);
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
            this.BtnClinic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnClinic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClinic.ForeColor = System.Drawing.Color.DimGray;
            this.BtnClinic.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.BtnClinic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.BtnClinic.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnClinic.HoverState.Parent = this.BtnClinic;
            this.BtnClinic.Location = new System.Drawing.Point(12, 2);
            this.BtnClinic.Name = "BtnClinic";
            this.BtnClinic.PressedColor = System.Drawing.Color.White;
            this.BtnClinic.ShadowDecoration.Parent = this.BtnClinic;
            this.BtnClinic.Size = new System.Drawing.Size(154, 45);
            this.BtnClinic.TabIndex = 2;
            this.BtnClinic.Text = "我的門診";
            this.BtnClinic.Click += new System.EventHandler(this.BtnClinic_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.PanelSlider);
            this.siticonePanel1.Controls.Add(this.Header);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1138, 656);
            this.siticonePanel1.TabIndex = 2;
            // 
            // PanelSlider
            // 
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSlider.Location = new System.Drawing.Point(0, 52);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(1138, 604);
            this.PanelSlider.TabIndex = 2;
            // 
            // MyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.siticonePanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyDoctor";
            this.Size = new System.Drawing.Size(1138, 656);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel Header;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelSlider;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnWork;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnPaitent;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnClinic;
        internal System.Windows.Forms.Label lbDoctorID;
    }
}
