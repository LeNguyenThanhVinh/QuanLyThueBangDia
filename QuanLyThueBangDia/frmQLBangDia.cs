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

namespace QuanLyThueBangDia
{
    public partial class frmQLBangDia : Form
    {
        BangDiaBUS bdBUS;
        List<eBangDia> listBD;
        public frmQLBangDia()
        {
            InitializeComponent();
        }

        void DuaDanhSachBangDiaVaoDGV()
        {
            bdBUS = new BangDiaBUS();
            listBD = new List<eBangDia>();
            listBD = bdBUS.getAllBangDia();
            dgvDanhSachBangDia.DataSource = listBD.ToList();
        }
        //Đưa dữ liệu vào datagridview (băng đĩa trong kho)
        void CreateColumnDGV(DataGridView dgv)
        {
            try
            {
                dgv.Columns["maBangDia"].HeaderText = "Mã băng đĩa";
                dgv.Columns["maBangDia"].Width = 150;
                dgv.Columns["tenBangDia"].HeaderText = "Tên băng đĩa";
                dgv.Columns["tenBangDia"].Width = 150;
                dgv.Columns["theLoai"].HeaderText = "Thể loại";
                dgv.Columns["theLoai"].Width = 150;
                dgv.Columns["soLuongTon"].HeaderText = "Số lượng tồn";
                dgv.Columns["soLuongTon"].Width = 150;
                dgv.Columns["donGia"].HeaderText = "Đơn giá";
                dgv.Columns["donGia"].Width = 150;
                dgv.Columns["tinhTrang"].HeaderText = "Tình trạng";
                dgv.Columns["tinhTrang"].Width = 150;
                dgv.Columns["nhaSanXuat"].HeaderText = "Nhà sản xuất";
                dgv.Columns["nhaSanXuat"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        //Đưa dữ liệu vào các textbox khi chọn băng đĩa trong datagridview
        void DuaDuLieuVaoTextBox(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int index = dgv.CurrentCell.RowIndex;
                txtMaBangDia.Text = dgv[0, index].Value.ToString().Trim();
                txtTenBangDia.Text = dgv[1, index].Value.ToString().Trim();
                cboTheLoai.Text = dgv[2, index].Value.ToString().Trim();
                txtSoLuong.Text = dgv[3, index].Value.ToString().Trim();
                txtDonGia.Text = dgv[4, index].Value.ToString().Trim();
                //txtTinhTrang.Text = dgv[5, index].Value.ToString().Trim();
                if (dgv[5, index].Value.ToString().Trim().Equals("Tốt"))
                    rdoTot.Checked = true;
                else
                    rdoXau.Checked = true;
                txtNhaSanXuat.Text = dgv[6, index].Value.ToString().Trim();
            }

        }
        //đưa thể loại vào combobox
        void DuaTheLoaiVaoComBoBox(ComboBox cbo)
        {
            foreach (string loai in bdBUS.LayTheLoaiBangDia())
            {
                if(loai!= null)
                {
                    cbo.Items.Add(loai);
                }
            }
        }
        //Tạo mã băng đĩa tự động
        string TaoMaBangDiaTuDong()
        {
            int matd = Convert.ToInt32(bdBUS.LayMaBangDiaCoMaLonNhat());
            matd += 1;
            string t = "";//Tạo số 0 sau chữ BD
            for (int i = 0; i < 4 - matd.ToString().Length; i++)
            {
                t += "0";
            }
            return "BD" + t + matd.ToString();
        }
        //Tạo băng đĩa mới từ các textbox
        void TaoBangDia()
        {
            try
            {
                if (!bdBUS.CheckIfExistBD(txtTenBangDia.Text, cboTheLoai.Text))
                {
                    if (txtMaBangDia.Text != "" && txtTenBangDia.Text != "" && txtDonGia.Text != "" && txtNhaSanXuat.Text != "" && txtSoLuong.Text != "" && txtTinhTrang.Text != "" && cboTheLoai.Text != "")
                    {
                        eBangDia newbd = new eBangDia();
                        newbd.MaBangDia = txtMaBangDia.Text;
                        newbd.TenBangDia = txtTenBangDia.Text;
                        newbd.NhaSanXuat = txtNhaSanXuat.Text;
                        //newbd.TinhTrang = txtTinhTrang.Text;
                        if (rdoTot.Checked)
                            newbd.TinhTrang = "Tốt";
                        else
                            newbd.TinhTrang = "Xấu";

                        newbd.SoLuongTon = Convert.ToInt32(txtSoLuong.Text);
                        newbd.DonGia = Convert.ToInt32(txtDonGia.Text);
                        newbd.TheLoai = cboTheLoai.Text;
                        bdBUS.ThemBangDia(newbd);

                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show("Không được để trống !");
                }
                else
                    MessageBox.Show("Đã tồn tại băng đĩa này");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "Thông báo");
            }
        }
        //Sửa băng đĩa
        void SuaBangDia()
        {
            try
            {
                int index = dgvDanhSachBangDia.CurrentCell.RowIndex;
                if ((txtTenBangDia.Text == dgvDanhSachBangDia[1, index].Value.ToString() && txtNhaSanXuat.Text == dgvDanhSachBangDia[2, index].Value.ToString()) || !bdBUS.CheckIfExistBD(txtTenBD.Text, cboTheLoai.Text))
                {
                    eBangDia newbd = new eBangDia();
                    newbd.MaBangDia = dgvDanhSachBangDia[0, index].Value.ToString();
                    newbd.TenBangDia = txtTenBangDia.Text;
                    newbd.NhaSanXuat = txtNhaSanXuat.Text;
                    //newbd.TinhTrang = txtTinhTrang.Text;
                    if (rdoTot.Checked)
                        newbd.TinhTrang = "Tốt";
                    else
                        newbd.TinhTrang = "Xấu";

                    newbd.SoLuongTon = Convert.ToInt32(txtSoLuong.Text);
                    newbd.DonGia = Convert.ToInt32(txtDonGia.Text);
                    newbd.TheLoai = cboTheLoai.Text;
                    bdBUS.SuaBangDia(newbd);
                    MessageBox.Show("sửa thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Băng đĩa này đã tồn tại ! không thể sửa !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex, "Thông báo");
            }
        }
        //Load lại dgv
        void LoadLaiDGV()
        {

            dgvDanhSachBangDia.DataSource = null;
            DuaDanhSachBangDiaVaoDGV();
            CreateColumnDGV(dgvDanhSachBangDia);
        }


        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaBangDia.Text = TaoMaBangDiaTuDong();
            txtDonGia.Text = null;
            txtNhaSanXuat.Text = null;
            txtSoLuong.Text = null;
            txtTenBangDia.Text = null;
            txtTinhTrang.Text = null;
            cboTheLoai.Text = null;
            btnThemBangDia.Enabled = true;
            btnSua.Enabled = false;
            txtTenBangDia.Focus();
        }

        private void frmQLBangDia_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnTimKiem;
            DuaDanhSachBangDiaVaoDGV();
            CreateColumnDGV(dgvDanhSachBangDia);
            DuaTheLoaiVaoComBoBox(cboTheLoai);
        }

        private void dgvDanhSachBangDia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DuaDuLieuVaoTextBox(dgvDanhSachBangDia);
            btnSua.Enabled = true;
            btnThemBangDia.Enabled = false;
        }
        
        private void btnThemBangDia_Click(object sender, EventArgs e)
        {
            TaoBangDia();
            LoadLaiDGV();
        }
        private void btnXoaBangDia_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBangDia.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa băng đĩa " + txtTenBangDia.Text, "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bdBUS.XoaBangDia(txtMaBangDia.Text);
                    LoadLaiDGV();
                    MessageBox.Show("Xóa thành công");

                }
            }
            else
                MessageBox.Show("Bạn chưa chọn băng đĩa", "Thông báo");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBangDia.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa băng đĩa " + txtTenBangDia.Text, "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SuaBangDia();
                    LoadLaiDGV();

                }
            }
            else
                MessageBox.Show("Bạn chưa chọn băng đĩa", "Thông báo");
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.TimKiemBangDiaTheoMa(txtMaBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.TimKiemBangDiaTheoTen(txtTenBD.Text).ToList();
            }
            else if (!string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.TimKiemBangDiaTheoMaVaTen(txtMaBD.Text, txtTenBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.getAllBangDia().ToList();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMaBD_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.TimKiemBangDiaTheoMa(txtMaBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.TimKiemBangDiaTheoTen(txtTenBD.Text).ToList();
            }
            else if (!string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.TimKiemBangDiaTheoMaVaTen(txtMaBD.Text, txtTenBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvDanhSachBangDia.DataSource = bdBUS.getAllBangDia().ToList();
            }
        }
    }
}
