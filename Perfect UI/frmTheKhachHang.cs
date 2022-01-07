using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
using BUS;

namespace Perfect_UI
{
    public partial class frmTheKhachHang : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        TheThanhVienBUS ttvBUS = new TheThanhVienBUS();
        public frmTheKhachHang()
        {
            InitializeComponent();

        }

        private void frmTheKhachHang_Load(object sender, EventArgs e)
        {
            refresh_GridView();
            
            //DataGridViewButtonColumn buttonColumn =
            //new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "";
            //buttonColumn.Name = "btnSua";
            //buttonColumn.Text = "Xem/Sửa";
            //buttonColumn.FlatStyle = FlatStyle.Flat;
            //buttonColumn.UseColumnTextForButtonValue = true;
            //gridKH.Columns.Add(buttonColumn);

            //buttonColumn = new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "";
            //buttonColumn.Name = "btnXoa";
            //buttonColumn.Text = "Xóa";
            //buttonColumn.DefaultCellStyle.ForeColor = Color.Red;
            //buttonColumn.FlatStyle = FlatStyle.Flat;
            //buttonColumn.UseColumnTextForButtonValue = true;
            //gridKH.Columns.Add(buttonColumn);
        }
        void DuaDuLieuVaoTextBox(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int index = dgv.CurrentCell.RowIndex;
                txtMaKH.Text = dgv[0, index].Value.ToString().Trim();
                txtMaThe.Text = dgv[1, index].Value.ToString().Trim();
                dtNgayCap.Text = dgv[2, index].Value.ToString().Trim();
                dtNgayHetHan.Text = dgv[3, index].Value.ToString().Trim();
                txtTenKH.Text = khBUS.LayTenKhachHang(txtMaKH.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (frmEditTheKH frm = new frmEditTheKH(null, null, 0))
            //{
            //    if (frm.ShowDialog() == DialogResult.OK)
            //        //tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
            //        refresh_GridView();
            //}
        }

        private void gridKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;
            //if (e.RowIndex < 0 || senderGrid.Columns[e.ColumnIndex].Name != "btnSua"
            //    && senderGrid.Columns[e.ColumnIndex].Name != "btnXoa") return;

            //if (senderGrid.Columns[e.ColumnIndex].Name == "btnSua")
            //{
            //    if (tblTheThanhVienBindingSource.Current == null)
            //        return;
            //    using (frmEditTheKH frm = new frmEditTheKH(tblTheThanhVienBindingSource.Current as tblTheThanhVien, null))
            //    {
            //        if (frm.ShowDialog() == DialogResult.OK)
            //            tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
            //    }
            //}

            //if (senderGrid.Columns[e.ColumnIndex].Name == "btnXoa")
            //{
            //    if (tblTheThanhVienBindingSource.Current == null)
            //        return;
            //    if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        TheKhachHangServices.delete(tblTheThanhVienBindingSource.Current as tblTheThanhVien);
            //        tblTheThanhVienBindingSource.RemoveCurrent();
            //    }
            //}
            DuaDuLieuVaoTextBox(gridKH);
         }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(1000);
            txtSearch.ResetText();
            txtSearchMaKH.ResetText();
            Cursor.Current = Cursors.Default;
            refresh_GridView();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getByMathe(txtSearch.Text);
            }
            else if (string.IsNullOrEmpty(txtSearch.Text))
            {
                tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
            }
        }

        private void txtSearchMaKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchMaKH.Text))
            {
                tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getByMaKH(txtSearchMaKH.Text);
            }
            else if (string.IsNullOrEmpty(txtSearchMaKH.Text))
            {
                tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
            }
        }
        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            if (tblTheThanhVienBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn thẻ trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TheKhachHangServices.delete(tblTheThanhVienBindingSource.Current as tblTheThanhVien);
                tblTheThanhVienBindingSource.RemoveCurrent();
            }
            refresh_GridView();
        }

        private void btnSuaThe_Click(object sender, EventArgs e)
        {
            if (tblTheThanhVienBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn thẻ trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (frmEditTheKH frm = new frmEditTheKH(tblTheThanhVienBindingSource.Current as tblTheThanhVien, null, 1))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    refresh_GridView();
            }

        }
        public void refresh_GridView()
        {
            tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
            DuaDuLieuVaoTextBox(gridKH);
        }

        private void gridKH_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSuaThe_Click(btnSuaThe, null);
        }
    }
}
