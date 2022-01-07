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
    public partial class frmXoaSuaPhieuThue : Form
    {
        TheThanhVienBUS ttvBUS;
        List<ePhieuThue> listPT;
        PhieuThueBUS ptBUS;
        List<eChiTietPhieuThue> listCTPT;
        ChiTietPhieuThueBUS ctptBUS;
        BangDiaBUS bdBUS;
        public int[] soLuongTra = new int[100];
        public frmXoaSuaPhieuThue()
        {
            ttvBUS = new TheThanhVienBUS();
            ptBUS = new PhieuThueBUS();
            ctptBUS = new ChiTietPhieuThueBUS();
            bdBUS = new BangDiaBUS();
            InitializeComponent();
        }
        //Đưa dữ liệu vào datagridview (danh sách phiếu thuê)
        void CreateColumnDGVPhieuThue(DataGridView dgv)
        {

            try
            {
                dgv.Columns["maThe"].HeaderText = "Mã thẻ";
                dgv.Columns["maThe"].Width = 150;
                dgv.Columns["maPhieuThue"].HeaderText = "Mã phiếu thuê";
                dgv.Columns["maPhieuThue"].Width = 150;
                dgv.Columns["maNhanVien"].HeaderText = "Mã nhân viên";
                dgv.Columns["maNhanVien"].Width = 150;
                dgv.Columns["ngayLap"].HeaderText = "Ngày lập";
                dgv.Columns["ngayLap"].Width = 150;
                dgv.Columns["thanhTien"].HeaderText = "Thành tiền";
                dgv.Columns["thanhTien"].Width = 150;
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
                txtMaBangDia.Text = dgv[1, index].Value.ToString().Trim();
                txtSoLuongThue.Text = dgv[2, index].Value.ToString().Trim();
                txtSoNgayThue.Text = dgv[3, index].Value.ToString().Trim();
                txtSoLuongDaTra.Text = dgv[4, index].Value.ToString().Trim();
            }

        }
        //Lấy mã phiếu thuê
        string LayMaPhieuThue(DataGridView dgv)
        {
            string maPhieu = "";
            int index = dgv.CurrentCell.RowIndex;
            maPhieu = dgv.Rows[index].Cells[0].Value.ToString();
            return maPhieu;
        }
        //Đưa dữ liệu vào datagridview (danh sách chi tiết phiếu thuê theo phiếu )
        void CreateColumnDGVBangDia(DataGridView dgv)
        {
            try
            {
                dgv.Columns["maPhieuThue"].HeaderText = "Mã phiếu thuê";
                dgv.Columns["maPhieuThue"].Width = 200;
                dgv.Columns["maBangDia"].HeaderText = "Mã băng đĩa";
                dgv.Columns["maBangDia"].Width = 200;
                dgv.Columns["soLuongThue"].HeaderText = "Số lượng thuê";
                dgv.Columns["soLuongThue"].Width = 200;
                dgv.Columns["soNgayThue"].HeaderText = "Số ngày thuê";
                dgv.Columns["soNgayThue"].Width = 200;
                dgv.Columns["soLuongDaTra"].HeaderText = "Số lượng đã trả";
                dgv.Columns["soLuongDaTra"].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        //xóa phiếu thuê
        void XoaPhieuThue(DataGridView dgv)
        {
            try
            {
                int index = dgv.CurrentCell.RowIndex;
                if (!ctptBUS.KiemTraBangDiaChuaTra(dgv[0, index].Value.ToString()))
                {
                    DialogResult dr = MessageBox.Show("Phiếu thuê này chưa trả hết băng đĩa, bạn có chắc sẽ xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        ctptBUS.XoaChiTietPhieuThue(dgv[0, index].Value.ToString());
                        ThemSoLuongBDKhiXoaPhieu(dgvDSBangDia);
                        ptBUS.XoaPhieuThue(dgv[0, index].Value.ToString());
                        LoadLaiDGVPhieuThue();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc sẽ xóa phiếu thuê này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        ctptBUS.XoaChiTietPhieuThue(dgv[0, index].Value.ToString());
                        ThemSoLuongBDKhiXoaPhieu(dgvDSBangDia);
                        ptBUS.XoaPhieuThue(dgv[0, index].Value.ToString());
                        LoadLaiDGVPhieuThue();
                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa");
            }
        }
        //Thêm số lượng vào kho khi xóa phiếu thuê
        void ThemSoLuongBDKhiXoaPhieu(DataGridView dgv)
        {
            int soLuongDuocThem = 0;
            eBangDia bdtmp;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bdtmp = new eBangDia();
                bdtmp = bdBUS.getBangDiaTheoMaChuan(dgv[1, i].Value.ToString());

                soLuongDuocThem = Convert.ToInt32(dgv[2, i].Value) - Convert.ToInt32(dgv[4, i].Value);

                bdtmp.SoLuongTon += soLuongDuocThem;
                bdBUS.truSoLuong(bdtmp);
            }
        }
        //Thêm số lượng vào kho khi xóa chi tiết phiếu
        void ThemSoLuongBDKhiXoaCTPT(DataGridView dgv, int index)
        {
            int soLuongDuocThem = 0;
            eBangDia bdtmp;
            bdtmp = new eBangDia();
            bdtmp = bdBUS.getBangDiaTheoMaChuan(dgv[1, index].Value.ToString());
            soLuongDuocThem = Convert.ToInt32(dgv[2, index].Value) - Convert.ToInt32(dgv[4, index].Value);
            bdtmp.SoLuongTon += soLuongDuocThem;
            bdBUS.truSoLuong(bdtmp);

        }
        //lấy lại mã phiếu khi xóa chi tiết phiếu
        private string maPhieuXoa = "";
        //Xóa băng đĩa(chi tiết phiếu thuê) trong phiếu thuê
        void XoaChiTietPhieuThue(DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;
            DialogResult dr = MessageBox.Show("Bạn có chắc sẽ xóa băng đĩa thuê này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ThemSoLuongBDKhiXoaCTPT(dgvDSBangDia, index);
                maPhieuXoa = dgvDanhSachPhieuThue[0, dgvDanhSachPhieuThue.CurrentCell.RowIndex].Value.ToString();
                ctptBUS.Xoa1ChiTietPhieuThue(dgv[0, index].Value.ToString(), dgv[1, index].Value.ToString());
                LoadLaiDGVCTPT();
                CapNhatSoTienPhieuThue(dgv);
                LoadLaiDGVPhieuThue();
                MessageBox.Show("Xóa thành công");
            }
        }
        //Sửa thông tin thuê (chi tiết phiếu thuê) trong phiếu thuê
        void SuaChiTietPhieuThue(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int index = dgv.CurrentCell.RowIndex;
                eBangDia bdtmp;
                eChiTietPhieuThue ctpttmp;
                bdtmp = new eBangDia();
                ctpttmp = new eChiTietPhieuThue();
                bdtmp = bdBUS.getBangDiaTheoMaChuan(dgv[1, index].Value.ToString());
                if (Convert.ToInt32(txtSoLuongThue.Text) < Convert.ToInt32(txtSoLuongDaTra.Text))
                {
                    MessageBox.Show("Số lượng thuê không được < số lượng đã trả");
                }
                else if (Convert.ToInt32(txtSoNgayThue.Text) <= 0)
                {
                    MessageBox.Show("Số ngày thuê phải >=1");
                }
                else if (Convert.ToInt32(txtSoLuongThue.Text) <= 0)
                {
                    MessageBox.Show("Số lượng thuê phải >=1");
                }
                else if (Convert.ToInt32(txtSoLuongDaTra.Text) < 0)
                {
                    MessageBox.Show("Số lượng đã trả phải >=0");
                }
                /*điều kiện số lượng thuê trong textbox:
                số lượng thuê trong textbox phải <= số lượng trong kho
                                                    + số lượng thuê trong dgv
                                                    -số lượng đã trả trong dgv*/
                else if (Convert.ToInt32(txtSoLuongThue.Text) > Convert.ToInt32(bdtmp.SoLuongTon) + Convert.ToInt32(dgv[2, index].Value) - Convert.ToInt32(dgv[4, index].Value))
                {
                    MessageBox.Show("Số lượng trong kho không đủ");
                }
                else
                {
                    
                    bdtmp.SoLuongTon += Convert.ToInt32(dgv[2, index].Value) - Convert.ToInt32(txtSoLuongThue.Text) + Convert.ToInt32(txtSoLuongDaTra.Text) - Convert.ToInt32(dgv[4, index].Value);
                    bdBUS.truSoLuong(bdtmp);
                    ctpttmp = ctptBUS.LayCTPTTheoMaPhieuMaDia(dgv[0, index].Value.ToString().Trim(), dgv[1, index].Value.ToString().Trim());
                    ctpttmp.SoLuongDaTra =Convert.ToInt32(txtSoLuongDaTra.Text);
                    ctpttmp.SoLuongThue = Convert.ToInt32(txtSoLuongThue.Text);
                    ctpttmp.SoNgayThue = Convert.ToInt32(txtSoNgayThue.Text);
                    ctptBUS.CapNhat(ctpttmp);
                    LoadLaiDGVCTPT();
                    CapNhatSoTienPhieuThue(dgvDSBangDia);
                    LoadLaiDGVPhieuThue();
                    MessageBox.Show("sửa thành công");
                }
            }
            else
                MessageBox.Show("Chưa chọn băng đĩa");
        }
        
        //Load lại dgv phiếu thuê
        void LoadLaiDGVPhieuThue()
        {
            dgvDanhSachPhieuThue.DataSource = null;
            dgvDSBangDia.DataSource = null;
            if (ttvBUS.CheckIfExist(txtTheKH.Text))
            {
                listPT = new List<ePhieuThue>();
                listPT = ptBUS.LayHetPhieuThueTheoMaThe(txtTheKH.Text);
                dgvDanhSachPhieuThue.DataSource = listPT.ToList();
                CreateColumnDGVPhieuThue(dgvDanhSachPhieuThue);
            }
            else
            {
                listPT = new List<ePhieuThue>();
                listPT = ptBUS.LayHetPhieuThue();
                dgvDanhSachPhieuThue.DataSource = listPT.ToList();
                CreateColumnDGVPhieuThue(dgvDanhSachPhieuThue);
            }    
        }
        //Load lại dgv danh sách băng đĩa(chi tiết phiếu thuê)
        void LoadLaiDGVCTPT()
        {
            dgvDSBangDia.DataSource = null;
            listCTPT = new List<eChiTietPhieuThue>();
            maPhieuXoa = dgvDanhSachPhieuThue[0, dgvDanhSachPhieuThue.CurrentCell.RowIndex].Value.ToString();
            listCTPT = ctptBUS.LayHetChiTietPhieuThueTheoMaThe(maPhieuXoa);
            dgvDSBangDia.DataSource = listCTPT.ToList();
            CreateColumnDGVBangDia(dgvDSBangDia);
            dgvDSBangDia.ClearSelection();
        }
        //Tính lại tổng tiền
        string TongTien(DataGridView dgv)
        {
            long sum = 0;
            int value1=0, value2=0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                eBangDia bdtmp;
                bdtmp = new eBangDia();
                bdtmp = bdBUS.getBangDiaTheoMaChuan(dgv[1, i].Value.ToString());
                value1 = Convert.ToInt32(dgv[2, i].Value);
                value2 = Convert.ToInt32(dgv[3, i].Value);
                sum += value1*value2*bdtmp.DonGia;
            }
            return sum.ToString();
        }
        //Cập nhật lại số tiền trong phiếu thuê
        void CapNhatSoTienPhieuThue(DataGridView dgv)
        {
            int index = dgvDanhSachPhieuThue.CurrentCell.RowIndex;
            ePhieuThue pt = new ePhieuThue();
            pt = ptBUS.LayPhieuThueTheoMa(dgvDanhSachPhieuThue[0, index].Value.ToString());
            ptBUS.SuaPhieuThue(pt, Convert.ToInt32(TongTien(dgv)));
        }



        private void btnTimTheKH_Click(object sender, EventArgs e)
        {
            if (ttvBUS.CheckIfExist(txtTheKH.Text))
            {
                listPT = new List<ePhieuThue>();
                listPT = ptBUS.LayHetPhieuThueTheoMaThe(txtTheKH.Text);

                dgvDanhSachPhieuThue.DataSource = listPT.ToList();
                CreateColumnDGVPhieuThue(dgvDanhSachPhieuThue);
            }
            else
                MessageBox.Show("Không tìm thấy mã thẻ: " + txtTheKH.Text, "Thông báo");
        }
        
        private void dgvDanhSachPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn cl in dgvDSBangDia.Columns)
            {
                cl.Visible = true;
            }
            for (int k = 0; k < soLuongTra.Length; k++)
            {
                soLuongTra[k] = 0;
            }
            listCTPT = new List<eChiTietPhieuThue>();
            listCTPT = ctptBUS.LayHetChiTietPhieuThueTheoMaThe(LayMaPhieuThue(dgvDanhSachPhieuThue).ToString());
            dgvDSBangDia.DataSource = listCTPT.ToList();
            CreateColumnDGVBangDia(dgvDSBangDia);
            dgvDSBangDia.ClearSelection();
        }

        private void dgvDSBangDia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DuaDuLieuVaoTextBox(dgvDSBangDia);
        }

        private void frmXoaSuaPhieuThue_Load(object sender, EventArgs e)
        {
            listPT = new List<ePhieuThue>();
            listPT = ptBUS.LayHetPhieuThue();

            dgvDanhSachPhieuThue.DataSource = listPT.ToList();
            CreateColumnDGVPhieuThue(dgvDanhSachPhieuThue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listPT = new List<ePhieuThue>();
            listPT = ptBUS.LayHetPhieuThue();

            dgvDanhSachPhieuThue.DataSource = listPT.ToList();
            CreateColumnDGVPhieuThue(dgvDanhSachPhieuThue);
        }

        private void btnXoaPhieuThue_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuThue.SelectedRows.Count > 0)
            {
                XoaPhieuThue(dgvDanhSachPhieuThue);
            }
            else
                MessageBox.Show("Bạn chưa chọn phiếu thuê cần xóa", "Thông báo");
        }

        private void btnXoaBangDia_Click(object sender, EventArgs e)
        {
            if (dgvDSBangDia.SelectedRows.Count > 0)
            {
                XoaChiTietPhieuThue(dgvDSBangDia);
                LoadLaiDGVCTPT();
            }
            else
                MessageBox.Show("Bạn chưa chọn băng đĩa trong phiếu thuê", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa ?","Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SuaChiTietPhieuThue(dgvDSBangDia);
            }
        }
    }
}
