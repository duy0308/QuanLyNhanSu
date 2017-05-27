using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ConsoleApplication1.Entity;
using Controller;

namespace QLNS.Show
{
    public partial class DanhSachBoPhan : UserControl
    {
        public DanhSachBoPhan()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            init();
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
        public void init()
        {
            List<TblBoPhan> data = new BoPhanController().getAllBoPhan();
            DataGridView datagrid = new DataGridView();
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.DataSource = data;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
