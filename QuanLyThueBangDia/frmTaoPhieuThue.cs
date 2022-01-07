using BUS;
using EnteriesQLBangDia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueBangDia
{
    public partial class frmTaoPhieuThue : Form
    {
        public frmTaoPhieuThue()
        {
            InitializeComponent();
        }
        eNhanVien nv = new eNhanVien();
        public frmTaoPhieuThue(eNhanVien nhanVien)
        {
            InitializeComponent();
            nv = nhanVien;
        }
        List<eBangDia> listBD;
        BangDiaBUS bdBUS;
        int[] soLuongChon = new int[100];

        private void btnChoThue_Click(object sender, EventArgs e)
        {
            if (dgvBangDiaDuocChon.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn băng đĩa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                List<eBangDia> listBDtmp = new List<eBangDia>();
                listBDtmp = TruyenDuLieuSangFormKhac(dgvBangDiaDuocChon);
                frmPhieuThue frm = new frmPhieuThue(listBDtmp, this, nv);
                frm.ShowDialog();

            }
        }

        //Đưa những băng đĩa được chọn trong bảng băng đĩa được chọn vào list
        List<eBangDia> TruyenDuLieuSangFormKhac(DataGridView dgv)
        {
            List<eBangDia> listBDtmp = new List<eBangDia>();
            string a = "";
            for (int i = 0; i < dgv.Rows.Count; i++)
            {

                a = (string)dgv[0, i].Value;
                listBDtmp.Add(bdBUS.getBangDiaTheoMa(a, Convert.ToInt32(dgv[2, i].Value)));
            }
            return listBDtmp;
        }
        //Đưa dữ liệu vào datagridview (băng đĩa trong kho)
        void CreateColumnDGV(DataGridView dgv)
        {
            try
            {
                dgv.Columns["maBangDia"].HeaderText = "Mã băng đĩa";
                dgv.Columns["tenBangDia"].HeaderText = "Tên băng đĩa";
                dgv.Columns["theLoai"].HeaderText = "Thể loại";
                dgv.Columns["soLuongTon"].HeaderText = "Số lượng tồn";
                dgv.Columns["donGia"].HeaderText = "Đơn giá";
                dgv.Columns["tinhTrang"].Visible = false;
                dgv.Columns["nhaSanXuat"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        //Tạo cột datagridview (Băng đĩa được chọn)
        void CreateColumnBangDiaChon(DataGridView dgv)
        {
            try
            {

                dgv.ColumnCount = 3;
                dgv.Columns[0].Name = "Mã băng đĩa";
                dgv.Columns[0].Width = 100;
                dgv.Columns[0].ReadOnly = true;
                dgv.Columns[1].Name = "Tên băng đĩa";
                dgv.Columns[1].Width = 100;
                dgv.Columns[1].ReadOnly = true;
                dgv.Columns[2].Name = "Số lượng";
                dgv.Columns[2].Width = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá tải: " + ex.Message, "Thông báo");
            }
        }
        public void LoadDataGridView()
        {
            bdBUS = new BangDiaBUS();
            listBD = new List<eBangDia>();
            listBD = bdBUS.getBangDiaTrangThai();
            dgvBangDiaKho.DataSource = listBD.ToList();
        }
        private void frmTaoPhieuThue_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            CreateColumnDGV(dgvBangDiaKho);
            CreateColumnBangDiaChon(dgvBangDiaDuocChon);
        }

        //Chuyển dữ liệu được chọn từ dgvBangDiaKho sang dgvBangDiaChon
        void ChuyenDuLieu(DataGridView dgv1, DataGridView dgv2)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                int index = dgv1.CurrentCell.RowIndex;
                int indexRow = dgv2.Rows.Count;
                int countRow = dgv2.Rows.Count;
                //Kiểm tra băng đĩa đã có ở datagridview2 chưa
                int i;
                for (i = 0; i < countRow; i++)
                {
                    if (dgv2[0, i].Value == dgv1.Rows[index].Cells[0].Value)
                    {
                        int tmp = Convert.ToInt32(dgv2[2, i].Value) + 1;
                        if (KiemTraSoLuong(tmp, Convert.ToInt32(dgv1[3, index].Value)))
                        {
                            MessageBox.Show("Không đủ số lượng", "Thông báo", MessageBoxButtons.OK);
                            break;
                        }
                        else
                        {
                            dgv2[2, i].Value = tmp;
                            soLuongChon[i] = tmp;
                            dgv2.ClearSelection();
                            dgv2.Rows[i].Selected = true;
                            break;
                        }

                    }
                }
                if (i == countRow)
                {
                    dgv2.Rows.Add(1);
                    dgv2[0, indexRow].Value = dgv1.Rows[index].Cells[0].Value.ToString();
                    dgv2[1, indexRow].Value = dgv1.Rows[index].Cells[1].Value.ToString();
                    dgv2[2, indexRow].Value = 1;
                    soLuongChon[i] = 1;
                    dgv2.ClearSelection();
                    dgv2.Rows[indexRow].Selected = true;
                }
            }
            else if (dgv2.SelectedRows.Count > 0)
            {
                int index = dgv2.CurrentCell.RowIndex;
                for (int i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (dgv1[0, i].Value == dgv2.Rows[index].Cells[0].Value)
                    {
                        int tmp = Convert.ToInt32(dgv2[2, index].Value) + 1;
                        if (KiemTraSoLuong(tmp, Convert.ToInt32(dgv1[3, i].Value)))
                        {
                            MessageBox.Show("Không đủ số lượng", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            dgv2[2, index].Value = tmp;
                            dgv2.ClearSelection();
                            dgv2.Rows[index].Selected = true;
                        }
                    }
                }

            }
        }
        //Sắp xếp lại mảng
        void SapXep(int a)
        {
            for (int i = a; i < soLuongChon.Length - 1; i++)
            {
                soLuongChon[i] = soLuongChon[i + 1];
            }
        }
        //Xóa 1 hàng trong datagridview đã chọn băng đĩa
        void XoaChon(DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;
            dgv.Rows[index].Selected = true;
            if (dgv.SelectedRows.Count > 0)
            {
                dgv.Rows.Remove(dgv.Rows[index]);
                SapXep(index);
            }
        }
        //Dùng để hủy chọn bảng dữ liệu 1 khi nhấn vào bảng dữ liệu 2   
        void HuySelect(DataGridView dgv1, DataGridView dgv2)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                int index = dgv2.CurrentCell.RowIndex;
                dgv2.Rows[index].Selected = true;

                dgv1.ClearSelection();
            }
        }
        //kiểm tra số lượng chọn với số lượng trong kho
        bool KiemTraSoLuong(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChuyenDuLieu(dgvBangDiaKho, dgvBangDiaDuocChon);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangDiaDuocChon.Rows.Count == 0)
            {
                MessageBox.Show("Không có băng đĩa được chọn", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    XoaChon(dgvBangDiaDuocChon);
                }
                catch (Exception exc)
                {
                    exc = new Exception();
                    if (exc is UnhandledExceptionMode)
                    {
                        MessageBox.Show("Chưa chọn băng đĩa cần xóa", "Thông báo");
                    }
                }
            }

        }

        private void dgvBangDiaKho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChuyenDuLieu(dgvBangDiaKho, dgvBangDiaDuocChon);
        }
        //Làm mới datagridview dữ liệu được chọn
        public void LamMoiDGVChon()
        {
            dgvBangDiaDuocChon.Rows.Clear();
            for (int i = 0; i < soLuongChon.Length; i++)
            {
                soLuongChon[i] = 0;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiDGVChon();
        }

        private void dgvBangDiaKho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBangDiaDuocChon.ClearSelection();
        }

        int TraVeSoLuongTruoc(DataGridView dgv1, DataGridView dgv2)//Dùng để trả về giá trị được chọn trước đó nếu số lượng được chọn tiếp theo lớn hơn số lượng trong kho
        {
            int index2 = dgv2.CurrentCell.RowIndex;
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgv1[3, i].Value) < Convert.ToInt32(dgv2[2, index2].Value) && dgv2[0, index2].Value == dgv1[0, i].Value)
                {
                    dgv2[2, index2].Value = soLuongChon[index2];
                    return 0;

                }
            }
            return 1;
        }

        private void dgvBangDiaDuocChon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvBangDiaKho.ClearSelection();
        }

        private void dgvBangDiaDuocChon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvBangDiaDuocChon.CurrentCell.RowIndex;
            if (TraVeSoLuongTruoc(dgvBangDiaKho, dgvBangDiaDuocChon) == 1)
                soLuongChon[index] = Convert.ToInt32(dgvBangDiaDuocChon[2, index].Value);
            else
                MessageBox.Show("Không đủ số lượng");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.TimKiemBangDiaTheoMa(txtMaBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.TimKiemBangDiaTheoTen(txtTenBD.Text).ToList();
            }
            else if (!string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.TimKiemBangDiaTheoMaVaTen(txtMaBD.Text, txtTenBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.getAllBangDia().ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvBangDiaKho.DataSource = null;
            LoadDataGridView();
            CreateColumnDGV(dgvBangDiaKho);
        }

        private void txtMaBD_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.TimKiemBangDiaTheoMa(txtMaBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.TimKiemBangDiaTheoTen(txtTenBD.Text).ToList();
            }
            else if (!string.IsNullOrEmpty(txtMaBD.Text) && !string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.TimKiemBangDiaTheoMaVaTen(txtMaBD.Text, txtTenBD.Text).ToList();
            }
            else if (string.IsNullOrEmpty(txtMaBD.Text) && string.IsNullOrEmpty(txtTenBD.Text))
            {
                dgvBangDiaKho.DataSource = bdBUS.getAllBangDia().ToList();
            }
        }
    }
}
