
namespace Medical.UserControls
{
    partial class MyDoctor_DoctorWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.BtnNext = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.gvPatinet = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneContextMenuStrip1 = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.已報到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.過號候補ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatinet)).BeginInit();
            this.siticoneContextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.BtnNext);
            this.siticonePanel1.Controls.Add(this.gvPatinet);
            this.siticonePanel1.Controls.Add(this.panel1);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(933, 454);
            this.siticonePanel1.TabIndex = 2;
            // 
            // BtnNext
            // 
            this.BtnNext.AutoRoundedCorners = true;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.BorderRadius = 22;
            this.BtnNext.CheckedState.Parent = this.BtnNext;
            this.BtnNext.CustomImages.Parent = this.BtnNext;
            this.BtnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNext.DisabledState.Parent = this.BtnNext;
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.HoverState.Parent = this.BtnNext;
            this.BtnNext.Location = new System.Drawing.Point(45, 347);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.ShadowDecoration.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(236, 46);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "叫號";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // gvPatinet
            // 
            this.gvPatinet.AllowUserToAddRows = false;
            this.gvPatinet.AllowUserToDeleteRows = false;
            this.gvPatinet.AllowUserToResizeColumns = false;
            this.gvPatinet.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.gvPatinet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvPatinet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPatinet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvPatinet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPatinet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPatinet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPatinet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvPatinet.ColumnHeadersHeight = 40;
            this.gvPatinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvPatinet.ContextMenuStrip = this.siticoneContextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPatinet.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvPatinet.EnableHeadersVisualStyles = false;
            this.gvPatinet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvPatinet.Location = new System.Drawing.Point(45, 36);
            this.gvPatinet.Name = "gvPatinet";
            this.gvPatinet.ReadOnly = true;
            this.gvPatinet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvPatinet.RowHeadersVisible = false;
            this.gvPatinet.RowHeadersWidth = 51;
            this.gvPatinet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvPatinet.RowTemplate.Height = 24;
            this.gvPatinet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPatinet.Size = new System.Drawing.Size(231, 293);
            this.gvPatinet.TabIndex = 3;
            this.gvPatinet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPatinet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvPatinet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvPatinet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvPatinet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvPatinet.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvPatinet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gvPatinet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvPatinet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvPatinet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gvPatinet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvPatinet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvPatinet.ThemeStyle.HeaderStyle.Height = 40;
            this.gvPatinet.ThemeStyle.ReadOnly = true;
            this.gvPatinet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPatinet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPatinet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gvPatinet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gvPatinet.ThemeStyle.RowsStyle.Height = 24;
            this.gvPatinet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPatinet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPatinet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPatinet_CellContentClick);
            this.gvPatinet.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvPatinet_CellMouseDown);
            // 
            // siticoneContextMenuStrip1
            // 
            this.siticoneContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.siticoneContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.已報到ToolStripMenuItem,
            this.過號候補ToolStripMenuItem});
            this.siticoneContextMenuStrip1.Name = "siticoneContextMenuStrip1";
            this.siticoneContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.ColorTable = null;
            this.siticoneContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneContextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 已報到ToolStripMenuItem
            // 
            this.已報到ToolStripMenuItem.Name = "已報到ToolStripMenuItem";
            this.已報到ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.已報到ToolStripMenuItem.Text = "已報到";
            this.已報到ToolStripMenuItem.Click += new System.EventHandler(this.已報到ToolStripMenuItem_Click);
            // 
            // 過號候補ToolStripMenuItem
            // 
            this.過號候補ToolStripMenuItem.Name = "過號候補ToolStripMenuItem";
            this.過號候補ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.過號候補ToolStripMenuItem.Text = "過號候補";
            this.過號候補ToolStripMenuItem.Click += new System.EventHandler(this.過號候補ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(307, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 362);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "看診紀錄";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "患者病歷紀錄";
            // 
            // MyDoctor_DoctorWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.siticonePanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyDoctor_DoctorWork";
            this.Size = new System.Drawing.Size(933, 454);
            this.Load += new System.EventHandler(this.DoctorWork_Load);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPatinet)).EndInit();
            this.siticoneContextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView gvPatinet;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 過號候補ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已報到ToolStripMenuItem;
    }
}
