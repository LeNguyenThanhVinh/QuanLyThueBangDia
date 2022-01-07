using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BLL;
using Model;

namespace Perfect_UI
{
    public partial class frmNhanVien : Form
    {
        string textNV;
        PictureBox picAvatar;
        public frmNhanVien(string textNV, PictureBox picAvatar)
        {
            InitializeComponent();
            this.textNV = textNV;
            this.picAvatar = picAvatar;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmEditNV frm = new frmEditNV(null, this.textNV, this.picAvatar))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            refresh_GridView();       
            //rdoNam.Checked = true;

            //tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            //DuaDuLieuVaoTextBox(gridNV);

            //DataGridViewButtonColumn buttonColumn =
            //new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "";
            //buttonColumn.Name = "btnSua";
            //buttonColumn.Text = "Sửa";
            //buttonColumn.FlatStyle = FlatStyle.Flat;
            //buttonColumn.UseColumnTextForButtonValue = true;
            //gridNV.Columns.Add(buttonColumn);

            //buttonColumn = new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "";
            //buttonColumn.Name = "btnXoa";
            //buttonColumn.Text = "Xóa";
            //buttonColumn.DefaultCellStyle.ForeColor = Color.Red;
            //buttonColumn.FlatStyle = FlatStyle.Flat;
            //buttonColumn.UseColumnTextForButtonValue = true;
            //gridNV.Columns.Add(buttonColumn);
        }

        private void gridNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;
            //if (e.RowIndex < 0 || senderGrid.Columns[e.ColumnIndex].Name != "btnSua"
            //    && senderGrid.Columns[e.ColumnIndex].Name != "btnXoa") return ;

            //if (senderGrid.Columns[e.ColumnIndex].Name == "btnSua")
            //{
            //    if (tblNhanVienBindingSource.Current == null)
            //        return;
            //    using (frmEditNV frm = new frmEditNV(tblNhanVienBindingSource.Current as tblNhanVien))
            //    {
            //        if (frm.ShowDialog() == DialogResult.OK)
            //            tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            //    }
            //}

            //if (senderGrid.Columns[e.ColumnIndex].Name == "btnXoa")
            //{
            //    if (tblNhanVienBindingSource.Current == null)
            //        return;
            //    if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        NhanVienServices.delete(tblNhanVienBindingSource.Current as tblNhanVien);
            //        tblNhanVienBindingSource.RemoveCurrent();
            //    }
            //}
            DuaDuLieuVaoTextBox(gridNV);

        }

        void DuaDuLieuVaoTextBox(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int index = dgv.CurrentCell.RowIndex;
                txtMaNV.Text = dgv[0, index].Value.ToString().Trim();
                txtHoTenNV.Text = dgv[1, index].Value.ToString().Trim();
                txtSoCMND.Text = dgv[3, index].Value.ToString().Trim();
                txtDiaChi.Text = dgv[4, index].Value.ToString().Trim();
                if (dgv[2, index].Value.ToString().Trim() == "Nam")
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                txtSoDienThoai.Text = dgv[6, index].Value.ToString();
                txtTaiKhoan.Text = dgv[7, index].Value.ToString().Trim();
                txtPass.Text = dgv[8, index].Value.ToString().Trim();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //System.Threading.Thread.Sleep(1000);
            txtSearch.ResetText();
            txtSearchByName.ResetText();
            refresh_GridView();
            Cursor.Current = Cursors.Default;
        }

      

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                tblNhanVienBindingSource.DataSource = NhanVienServices.getByID(txtSearch.Text);
            }
            else if (string.IsNullOrEmpty(txtSearch.Text))
            {
                tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            }
        }

        /*private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (tblNhanVienBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVienServices.delete(tblNhanVienBindingSource.Current as tblNhanVien);
                tblNhanVienBindingSource.RemoveCurrent();
            }
            tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            DuaDuLieuVaoTextBox(gridNV);
        }*/

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (tblNhanVienBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (frmEditNV frm = new frmEditNV(tblNhanVienBindingSource.Current as tblNhanVien, this.textNV, this.picAvatar))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    refresh_GridView();
            }
        }

        private void refresh_GridView()
        {
            tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            DuaDuLieuVaoTextBox(gridNV);
        }

        private void gridNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.Columns[e.ColumnIndex].Name == "trangThai")
            {
                e.Value = (bool)e.Value ? "Đang làm việc" : "Nghỉ việc";
                e.FormattingApplied = true;
            }
        }

        private void txtSearchByName_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchByName.Text))
            {
                tblNhanVienBindingSource.DataSource = NhanVienServices.getByName(txtSearchByName.Text);
            }
            else if (string.IsNullOrEmpty(txtSearchByName.Text))
            {
                tblNhanVienBindingSource.DataSource = NhanVienServices.getAll();
            }
        }

        private void gridNV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSuaNV_Click(btnSuaNV, null);
        }
    }
}