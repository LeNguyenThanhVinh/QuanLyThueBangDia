using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using EnteriesQLBangDia;
using BLL;
using Perfect_UI;

namespace QuanLyThueBangDia
{
    public partial class frmKhachHang : Form
    {
        KhachHangBUS khBUS;
        List<eKhachHang> listKH;
        ChiTietPhieuThueBUS ctptBUS;
        TheThanhVienBUS ttvBUS;
        public frmKhachHang()
        {
            InitializeComponent();
            ctptBUS = new ChiTietPhieuThueBUS();
            ttvBUS = new TheThanhVienBUS();
        }

        string TaoMaKHTuDong()
        {
            //long matd = Convert.ToInt32(khBUS.LayMaKHCoMaLonNhat());
            //matd += 1;
            //return matd.ToString();
            long matd = Convert.ToInt32(khBUS.LayMaKHCoMaLonNhat());
            matd += 1;
            string so = "";
            if (matd.ToString().Length == 1)
                so = "000";
            else if (matd.ToString().Length == 2)
                so = "00";
            else if (matd.ToString().Length == 3)
                so = "0";
            return "KH" + so + matd.ToString();
        }
        void DuaDanhSachKHVaoDGV()
        {
            khBUS = new KhachHangBUS();
            listKH = new List<eKhachHang>();
            listKH = khBUS.getAllKhachHang();
            dgvDanhSachKH.DataSource = listKH.ToList();
        }
        //Đưa dữ liệu vào datagridview (danh sách khách hàng)
        void CreateColumnDGV(DataGridView dgv)
        {
            try
            {
                dgv.Columns["maKhachHang"].HeaderText = "Mã khách hàng";
                dgv.Columns["HoTen"].HeaderText = "Tên khách hàng";
                dgv.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgv.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgv.Columns["SoCMND"].HeaderText = "Số CMND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        //Load lại dgv
        void LoadLaiDGV()
        {
            dgvDanhSachKH.DataSource = null;
            DuaDanhSachKHVaoDGV();
            CreateColumnDGV(dgvDanhSachKH);
        }
        //Đưa dữ liệu vào các textbox khi chọn khách hàng trong datagridview
        void DuaDuLieuVaoTextBox(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int index = dgv.CurrentCell.RowIndex;
                txtMaKH.Text = dgv[0, index].Value.ToString().Trim();
                txtHoTenKH.Text = dgv[1, index].Value.ToString().Trim();
                txtSoCMND.Text = dgv[2, index].Value.ToString().Trim();
                txtDiaChi.Text = dgv[3, index].Value.ToString().Trim();
                //cboGioiTinh.Text = dgv[4, index].Value.ToString().Trim();
                if (dgv[4, index].Value.ToString().Trim() == "Nữ")
                    rdoNu.Checked = true;
                else
                    rdoNam.Checked = true;
                txtSoDienThoai.Text = dgv[5, index].Value.ToString().Trim();
            }

        }
        //Tạo khách hàng mới từ các textbox
        void TaoKhachHang()
        {
            try
            {
                if (!khBUS.CheckIfExistKH(txtSoCMND.Text))
                {
                    if (txtHoTenKH.Text != "" && txtDiaChi.Text != "" && txtSoCMND.Text!= "" && txtSoDienThoai.Text != "")
                    {
                        eKhachHang newkh = new eKhachHang();
                        newkh.MaKhachHang = txtMaKH.Text;
                        newkh.HoTen = txtHoTenKH.Text;
                        newkh.DiaChi = txtDiaChi.Text;
                        newkh.SoCMND = txtSoCMND.Text;
                        newkh.SoDienThoai = txtSoDienThoai.Text;
                        if (rdoNam.Checked == true)
                            newkh.GioiTinh = "Nam";
                        else
                            newkh.GioiTinh = "Nữ";
                        //newkh.GioiTinh = cboGioiTinh.Text;
                        khBUS.ThemKhachHang(newkh);

                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Không được để trống !");
                }
                else
                    MessageBox.Show("Đã tồn tại khách hàng này");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "Thông báo");
            }
        }
        //Sửa khách hàng
        void SuaKhachHang()
        {
            try
            {
                int index = dgvDanhSachKH.CurrentCell.RowIndex;
                if ((txtSoCMND.Text.Trim() == dgvDanhSachKH[2, index].Value.ToString().Trim()) || !khBUS.CheckIfExistKH(txtSoCMND.Text))
                {
                    if (txtHoTenKH.Text != "" && txtDiaChi.Text != "" && txtSoCMND.Text != "" && txtSoDienThoai.Text != "")
                    {
                        eKhachHang newkh = new eKhachHang();
                        newkh.MaKhachHang = dgvDanhSachKH[0, index].Value.ToString();
                        newkh.HoTen = txtHoTenKH.Text;
                        newkh.DiaChi = txtDiaChi.Text;
                        newkh.SoCMND = txtSoCMND.Text;
                        newkh.SoDienThoai = txtSoDienThoai.Text;
                        if (rdoNam.Checked == true)
                            newkh.GioiTinh = "Nam";
                        else
                            newkh.GioiTinh = "Nữ";
                        //newkh.GioiTinh = cboGioiTinh.Text;
                        khBUS.SuaKhachHang(newkh);
                        MessageBox.Show("sửa thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Không được để trống !");
                }
                else
                    MessageBox.Show("khách hàng này đã tồn tại ! không thể sửa !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Thông báo");
            }
        }
        //Tạo mới các textbox
        void TaoMoiTextBox()
        {
            txtMaKH.Text = null;
            txtHoTenKH.Text = null;
            txtDiaChi.Text = null;
            txtSoCMND.Text = null;
            txtSoDienThoai.Text = null;
            txtMaKH.Text = TaoMaKHTuDong();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DuaDanhSachKHVaoDGV();
            CreateColumnDGV(dgvDanhSachKH);
            dgvDanhSachKH.ClearSelection();
            rdoNam.Checked = true;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            TaoMoiTextBox();
            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = false;
            txtHoTenKH.Focus();
        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DuaDuLieuVaoTextBox(dgvDanhSachKH);
            btnThemKH.Enabled = false;
            btnSuaKH.Enabled = true;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            TaoKhachHang();
            LoadLaiDGV();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + txtHoTenKH.Text, "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    khBUS.XoaKhachHang(txtMaKH.Text);
                    LoadLaiDGV();
                    dgvDanhSachKH.ClearSelection();
                    TaoMoiTextBox();
                    txtMaKH.Text = null;
                    MessageBox.Show("Xóa thành công");
                    

                }
            }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo");
        }


        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0 && txtMaKH!=null)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa khách hàng " + txtHoTenKH.Text, "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SuaKhachHang();
                    LoadLaiDGV();

                }
            }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo");
        }


        private void btnTaoThe_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0)
            {
                if (ttvBUS.LayTheThanhVienTheoMaKH(dgvDanhSachKH[0, dgvDanhSachKH.CurrentCell.RowIndex].Value.ToString()).Count > 0)
                {
                    MessageBox.Show("Khách hàng này đã có thẻ, không thể tạo thêm");
                    /*foreach (eTheThanhVien ttv in ttvBUS.LayTheThanhVienTheoMaKH(dgvDanhSachKH[0, dgvDanhSachKH.CurrentCell.RowIndex].Value.ToString()))
                    {
                        if (ctptBUS.KiemTraCoBangDiaTreHan(ttv.MaThe.ToString()))
                        {
                            Perfect_UI.frmEditTheKH frm = new frmEditTheKH(null, txtMaKH.Text);
                            frm.ShowDialog();
                            //tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
                        }
                        else
                            MessageBox.Show("Khách hàng này đang có băng đĩa trễ hạn, không thể tạo phiếu thuê mới !", "Thông báo");
                    }*/

                }

                else
                {
                    Perfect_UI.frmEditTheKH frm = new frmEditTheKH(null, txtMaKH.Text, 0);
                    frm.ShowDialog();
                    //tblTheThanhVienBindingSource.DataSource = TheKhachHangServices.getAll();
                }


            }
            else
                MessageBox.Show("Hãy chọn khách hàng");
            

        }

        private void txtSoCMND_Leave(object sender, EventArgs e)
        {
            if (txtSoCMND.Text != "")
            {
                if (!txtSoCMND.Text.CheckIsNumber())
                {
                    MessageBox.Show("Số CMND phải là số");
                    txtSoCMND.Focus();
                }
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text != "")
            {
                if (!txtSoDienThoai.Text.CheckPhone())
                {
                    MessageBox.Show("Số điện thoại gồm 10 chữ số");
                    txtSoDienThoai.Focus();
                }
            }
        }

        private void txtHoTenKH_Leave(object sender, EventArgs e)
        {
            if (txtHoTenKH.Text != "")
            {
                if (!txtHoTenKH.Text.CheckName())
                {
                    MessageBox.Show("Tên không đúng định dạng");
                    txtHoTenKH.Focus();
                }
            }
        }

        private void btnLamLaiThe_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0)
            {
                if (ttvBUS.LayTheThanhVienTheoMaKH(dgvDanhSachKH[0, dgvDanhSachKH.CurrentCell.RowIndex].Value.ToString()).Count > 0)
                {
                    Perfect_UI.frmEditTheKH frm = new frmEditTheKH(null, txtMaKH.Text, 2);
                    frm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Khách hàng này chưa có thẻ, hãy chọn tạo thẻ !", "Thông báo");
                }
            }
            else
                MessageBox.Show("Hãy chọn khách hàng cần làm lại thẻ!", "Thông báo");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiemKH.Text) && string.IsNullOrEmpty(txtTimKiemKHByTen.Text))
            {
                dgvDanhSachKH.DataSource = khBUS.TimKiemKhachHangTheoMa(txtTimKiemKH.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtTimKiemKH.Text) && !string.IsNullOrEmpty(txtTimKiemKHByTen.Text))
            {
                dgvDanhSachKH.DataSource = khBUS.TimKiemKhachHangTheoTen(txtTimKiemKHByTen.Text).ToList();
            }
            else if (!string.IsNullOrEmpty(txtTimKiemKH.Text) && !string.IsNullOrEmpty(txtTimKiemKHByTen.Text))
            {
                dgvDanhSachKH.DataSource = khBUS.TimKiemKhachHangTheoMaVaTen(txtTimKiemKH.Text, txtTimKiemKHByTen.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtTimKiemKH.Text) && string.IsNullOrEmpty(txtTimKiemKHByTen.Text))
            {
                dgvDanhSachKH.DataSource = khBUS.getAllKhachHang().ToList();
            }
        }
    }
}
