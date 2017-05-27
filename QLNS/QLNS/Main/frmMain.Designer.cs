namespace QLNS.Main
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DSPhongBanToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemPBToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SuaPBToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPBToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchBộPhậnTool = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBoPhanToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaBoPhanToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaBoPhanToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new QLNS.HelperClass.SupperTabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýNhânSựToolStripMenuItem,
            this.quảnLýPhòngBanToolStripMenuItem,
            this.quảnLýBộPhậnToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýNhânSựToolStripMenuItem
            // 
            this.quảnLýNhânSựToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.danhSáchNhânViênToolStripMenuItem});
            this.quảnLýNhânSựToolStripMenuItem.Name = "quảnLýNhânSựToolStripMenuItem";
            this.quảnLýNhânSựToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.quảnLýNhânSựToolStripMenuItem.Text = "Quản lý nhân sự";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DSPhongBanToolStrip,
            this.ThemPBToolStrip,
            this.SuaPBToolStrip,
            this.xóaPBToolStrip});
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.quảnLýPhòngBanToolStripMenuItem.Text = "Quản lý phòng ban";
            // 
            // DSPhongBanToolStrip
            // 
            this.DSPhongBanToolStrip.Name = "DSPhongBanToolStrip";
            this.DSPhongBanToolStrip.Size = new System.Drawing.Size(190, 22);
            this.DSPhongBanToolStrip.Text = "Danh sách phòng ban";
            // 
            // ThemPBToolStrip
            // 
            this.ThemPBToolStrip.Name = "ThemPBToolStrip";
            this.ThemPBToolStrip.Size = new System.Drawing.Size(190, 22);
            this.ThemPBToolStrip.Text = "Thêm";
            // 
            // SuaPBToolStrip
            // 
            this.SuaPBToolStrip.Name = "SuaPBToolStrip";
            this.SuaPBToolStrip.Size = new System.Drawing.Size(190, 22);
            this.SuaPBToolStrip.Text = "Sửa";
            // 
            // xóaPBToolStrip
            // 
            this.xóaPBToolStrip.Name = "xóaPBToolStrip";
            this.xóaPBToolStrip.Size = new System.Drawing.Size(190, 22);
            this.xóaPBToolStrip.Text = "Xóa";
            // 
            // quảnLýBộPhậnToolStripMenuItem
            // 
            this.quảnLýBộPhậnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchBộPhậnTool,
            this.thêmBoPhanToolStrip,
            this.sửaBoPhanToolStrip,
            this.xóaBoPhanToolStrip});
            this.quảnLýBộPhậnToolStripMenuItem.Name = "quảnLýBộPhậnToolStripMenuItem";
            this.quảnLýBộPhậnToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.quảnLýBộPhậnToolStripMenuItem.Text = "Quản lý bộ phận";
            // 
            // danhSáchBộPhậnTool
            // 
            this.danhSáchBộPhậnTool.Name = "danhSáchBộPhậnTool";
            this.danhSáchBộPhậnTool.Size = new System.Drawing.Size(176, 22);
            this.danhSáchBộPhậnTool.Text = "Danh sách bộ phận";
            this.danhSáchBộPhậnTool.Click += new System.EventHandler(this.danhSáchBộPhậnTool_Click);
            // 
            // thêmBoPhanToolStrip
            // 
            this.thêmBoPhanToolStrip.Name = "thêmBoPhanToolStrip";
            this.thêmBoPhanToolStrip.Size = new System.Drawing.Size(176, 22);
            this.thêmBoPhanToolStrip.Text = "Thêm";
            // 
            // sửaBoPhanToolStrip
            // 
            this.sửaBoPhanToolStrip.Name = "sửaBoPhanToolStrip";
            this.sửaBoPhanToolStrip.Size = new System.Drawing.Size(176, 22);
            this.sửaBoPhanToolStrip.Text = "Sửa";
            // 
            // xóaBoPhanToolStrip
            // 
            this.xóaBoPhanToolStrip.Name = "xóaBoPhanToolStrip";
            this.xóaBoPhanToolStrip.Size = new System.Drawing.Size(176, 22);
            this.xóaBoPhanToolStrip.Text = "Xóa";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(664, 397);
            this.tabControl.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 424);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private HelperClass.SupperTabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSPhongBanToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ThemPBToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SuaPBToolStrip;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPBToolStrip;
        private System.Windows.Forms.ToolStripMenuItem danhSáchBộPhậnTool;
        private System.Windows.Forms.ToolStripMenuItem thêmBoPhanToolStrip;
        private System.Windows.Forms.ToolStripMenuItem sửaBoPhanToolStrip;
        private System.Windows.Forms.ToolStripMenuItem xóaBoPhanToolStrip;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    }
}