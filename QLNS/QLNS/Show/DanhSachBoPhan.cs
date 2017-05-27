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
using QLNS.Common;

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
            getData();
            DataGridViewImageButtonSaveColumn columnSave = new DataGridViewImageButtonSaveColumn();
            dataGridView1.Columns.Add(columnSave);
            DataGridViewImageButtonDeleteColumn columnDelete = new DataGridViewImageButtonDeleteColumn();
            dataGridView1.Columns.Add(columnDelete);
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns[3];
            c.DefaultCellStyle.ForeColor = Color.Navy;
            c.DefaultCellStyle.BackColor = Color.Green;
            DataGridViewButtonColumn c2 = (DataGridViewButtonColumn)dataGridView1.Columns[4];
            c2.DefaultCellStyle.ForeColor = Color.Navy;
            c2.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns[3].HeaderText = "Sửa";
            dataGridView1.Columns[4].HeaderText = "Xóa";

        }
        public void getData()
        {
            List<TblBoPhan> data = new BoPhanController().getAllBoPhan();
            dataGridView1.DataSource = data;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[3] is DataGridViewImageButtonSaveColumn && e.RowIndex >= 0 && senderGrid.Columns[4] is DataGridViewImageButtonDeleteColumn)
            {
                switch(e.ColumnIndex)
                {
                    case 3:
                        TblBoPhan data = new TblBoPhan();
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        data.MaBophan = row.Cells[0].Value.ToString();
                        data.TenBoPhan = row.Cells[1].Value.ToString();
                        data.GhiChu = row.Cells[2].Value.ToString();
                        Add.AddBoPhan uc = new Add.AddBoPhan(data, "Cập nhật bộ phận",this);
                        uc.ShowDialog();
                        break;
                    case 4:
                        TblBoPhan data2 = new TblBoPhan();
                        DataGridViewRow row2 = dataGridView1.Rows[e.RowIndex];
                        data2.MaBophan = row2.Cells[0].Value.ToString();
                        data2.TenBoPhan = row2.Cells[1].Value.ToString();
                        data2.GhiChu = row2.Cells[2].Value.ToString();
                        Delete.DeleteBoPhan uc2 = new Delete.DeleteBoPhan("Bộ phận này", data2, this);
                        uc2.ShowDialog();
                        break;
                }
            }
        }
    }
}
