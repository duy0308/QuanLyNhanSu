using ConsoleApplication1.Entity;
using QLNS.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Main
{
    public partial class frmMain : Form
    {
        Show.DanhSachBoPhan dsbp;
        Show.DanhSachPhongBan dspb;

        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private void addNewTab(string strTabName, UserControl ucContent)
        {
            foreach (TabPage tabpage in tabControl.TabPages)
            {
                if (tabpage.Text == strTabName)
                {
                    tabControl.SelectedTab = tabpage;
                    return;
                }
            }
            SupperTabControl newTabPanel = new SupperTabControl();
            TabPage newTabPage = new TabPage();
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = strTabName;
            newTabPanel.Size = new System.Drawing.Size(tabControl.Width, tabControl.Height);
            newTabPanel.TabIndex = 2;
            newTabPanel.Tag = newTabPage;

            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22324);
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(ucContent);

            tabControl.TabPages.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;
        }


        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add.AddStaff uc = new Add.AddStaff();
            uc.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them.DanhSachNhanVien uc = new Them.DanhSachNhanVien();
            addNewTab("Danh sách nhân viên", uc);
        }

        private void danhSáchBộPhậnTool_Click(object sender, EventArgs e)
        {
            dsbp = new Show.DanhSachBoPhan();
            addNewTab("Danh sách bộ phận", dsbp);
        }

        private void thêmBoPhanToolStrip_Click(object sender, EventArgs e)
        {
            Add.AddBoPhan uc = new Add.AddBoPhan(null,"Thêm mới bộ phận",this.dsbp);
            uc.ShowDialog();
        }

        private void sửaBoPhanToolStrip_Click(object sender, EventArgs e)
        {
            TblBoPhan data = new TblBoPhan();
            Add.AddBoPhan uc = new Add.AddBoPhan(null, "Cập nhật bộ phận", this.dsbp);
            uc.ShowDialog();
        }

        private void DSPhongBanToolStrip_Click(object sender, EventArgs e)
        {
            dspb = new Show.DanhSachPhongBan();
            addNewTab("Danh sách bộ phận", dspb);
        }

        private void ThemPBToolStrip_Click(object sender, EventArgs e)
        {
            Add.AddPhongBan uc = new Add.AddPhongBan(null, "Thêm mới phòng ban", this.dspb);
            uc.ShowDialog();
        }
    }
}
