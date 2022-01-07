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
using MetroFramework;

namespace QuanLyThueBangDia
{
    public partial class frmPhieuThue : MetroFramework.Forms.MetroForm
    {
        List<eBangDia> listBD;
        PhieuThueBUS ptBUS;
        ChiTietPhieuThueBUS ctptBUS;
        BangDiaBUS bdBUS;
        TheThanhVienBUS ttvBUS;
        KhachHangBUS khBUS;
        private readonly frmTaoPhieuThue frm1;
        public frmPhieuThue()
        {
            InitializeComponent();
        }
        eNhanVien nv = new eNhanVien();
        public frmPhieuThue(List<eBangDia> listtmp, frmTaoPhieuThue frm , eNhanVien nhanVien)
        {
            InitializeComponent();
            listBD = new List<eBangDia>();
            listBD = listtmp;
            ptBUS = new PhieuThueBUS();
            ctptBUS = new ChiTietPhieuThueBUS();
            bdBUS = new BangDiaBUS();
            ttvBUS = new TheThanhVienBUS();
            khBUS = new KhachHangBUS();
            nv = nhanVien;
            frm1 = frm;
            editingBox = default(TextBox);
        }
        void TaoCotChoDataGridView(DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "Mã băng đĩa";
            dgv.Columns[0].Width = 100;
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].Name = "Tên băng đĩa";
            dgv.Columns[1].Width = 100;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].Name = "Số lượng";
            dgv.Columns[2].Width = 100;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns[3].Name = "Đơn giá/1 băng đĩa/1 ngày";
            dgv.Columns[3].Width = 250;
            dgv.Columns[3].ReadOnly = true;
            dgv.Columns[4].Name = "Số ngày thuê/1 băng";
            dgv.Columns[4].Width = 100;
            dgv.Columns[4].ReadOnly = false;
        }
        //Nhận dữ liệu từ form TaoPhieuThue
        void NhanDuLieu(List<eBangDia> listtmp,DataGridView dgv)
        {
            int i = 0;                   
            foreach (eBangDia bdtmp in listtmp)
            {
                dgv.Rows.Add(1);
                dgv[0, i].Value = (string)bdtmp.MaBangDia;
                dgv[1, i].Value = bdtmp.TenBangDia;
                dgv[2, i].Value = bdtmp.SoLuongTon;
                dgv[3, i].Value = bdtmp.DonGia;
                dgv[4, i].Value = 1;
                i++;               
            }
        }
        //Cập nhật số lượng băng đĩa
        void CapNhatSoLuongBangDia(List<eBangDia> listtmp, DataGridView dgv)
        {
            eBangDia bdtmp;
            int i = 0;
            foreach(eBangDia bd in listtmp)
            {
                bdtmp = new eBangDia();
                bdtmp.MaBangDia = bd.MaBangDia;
                bdtmp.TenBangDia = bd.TenBangDia;
                bdtmp.TheLoai = bd.TheLoai;
                bdtmp.NhaSanXuat = bd.NhaSanXuat;
                bdtmp.TinhTrang = bd.TinhTrang;
                bdtmp.DonGia = Convert.ToInt32(bd.DonGia);
                bdtmp.SoLuongTon = bdBUS.getSoLuongBangDia(bd.MaBangDia) - Convert.ToInt32(dgv[2, i].Value);
                bdBUS.truSoLuong(bdtmp);
                i++;
            }    
        }
        //Tính tổng tiền
        string TongTien(DataGridView dgv)
        {
            long sum = 0;
            for(int i = 0; i<dgv.Rows.Count;i++)
            {
                sum += Convert.ToInt32(dgv[2, i].Value)*Convert.ToInt32(dgv[3,i].Value) * Convert.ToInt32(dgv[4, i].Value);
            }
            return sum.ToString();
        }
        private void frmPhieuThue_Load(object sender, EventArgs e)
        {
            TaoCotChoDataGridView(dgvBangDiaThue);
            NhanDuLieu(listBD, dgvBangDiaThue);
            txtTongTien.Text =  TongTien(dgvBangDiaThue);
            DateTime now = DateTime.Now;
            txtNgayThue.Text = now.ToString();
            txtMaPhieu.Text = TaoMaPhieuTuDong();
        }
        //Tạo mã phiếu tự động
        string TaoMaPhieuTuDong()
        {
            int matd = Convert.ToInt32(ptBUS.LayMaPhieuThueCoMaLonNhat());
            matd += 1;
            string t = "";//Tạo số 0 sau chữ PT
            for (int i = 0; i < 6 - matd.ToString().Length; i++)
            {
                t += "0";
            }
            return "PT" + t + matd.ToString();
        }
        //tạo băng đĩa trong chi tiết phiếu thuê
        void TaoChiTietPhieuThue(DataGridView dgv)
        {
            eChiTietPhieuThue ctpt;
            int k=0;
            for(int i = 0; i < dgv.Rows.Count; i++)
            {
                ctpt = new eChiTietPhieuThue();
                ctpt.MaBangDia = dgv[0, i].Value.ToString();
                ctpt.MaPhieuThue =txtMaPhieu.Text;
                ctpt.SoLuongThue =Convert.ToInt32(dgv[2, i].Value);
                ctpt.SoNgayThue = Convert.ToInt32(dgv[4, i].Value);
                ctpt.SoLuongDaTra = 0;
                k = ctptBUS.newChiTietPhieuThue(ctpt);
            }    
        }
        //Kiểm tra có tồn tại mã thẻ không, sau đó tạo phiếu thuê và chi tiết phiếu thuê
        void TaoPhieuThue()
        {
            try
            {
                if (ttvBUS.CheckIfExist(txtMaThe.Text))
                {
                    int i = 0;
                    ePhieuThue newpt = new ePhieuThue();
                    newpt.MaNhanVien = nv.MaNhanVien.ToString();
                    newpt.MaPhieuThue = TaoMaPhieuTuDong();
                    newpt.MaThe = txtMaThe.Text;
                    newpt.NgayLap = txtNgayThue.Text;
                    newpt.ThanhTien = Convert.ToInt32(txtTongTien.Text);
                    CapNhatSoLuongBangDia(listBD, dgvBangDiaThue);
                    i = ptBUS.newPhieuThue(newpt);
                    TaoChiTietPhieuThue(dgvBangDiaThue);

                    MessageBox.Show("Thêm thành công", "Thông báo");

                    //Chuyển qua in
                    btnTaoPhieu.Visible = false;
                    btnInPhieuThue.Location = new Point(144, 24);
                    btnInPhieuThue.Visible = true;

                    frm1.LoadDataGridView();
                    frm1.LamMoiDGVChon();
                    //this.Close();
                }
                else
                    MessageBox.Show("Không tồn tại mã thẻ");
        }
            catch (Exception ex)
            {
                MessageBox.Show("Sai mã thẻ", "Thông báo");
            }
}
        // Kiểm tra mã thẻ của khách hàng có băng đĩa nào bị trễ hạn, nếu có thì không cho tạo phiếu thuê
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            if (ctptBUS.KiemTraCoBangDiaTreHan(txtMaThe.Text))
            {
                int k = 0;
                int i=0;
                for (i = 0;i<dgvBangDiaThue.Rows.Count;i++)
                {
                    if (dgvBangDiaThue[4, i].Value == null)
                    {
                        k = 2; break;
                    }    
                    else if (!dgvBangDiaThue[4, i].Value.ToString().CheckIsNumber()||Convert.ToInt32( dgvBangDiaThue[4, i].Value.ToString())<1)
                    {
                        k = 1;break;
                    }    
                }
                if (k == 0)
                    TaoPhieuThue();
                else if (k == 1)
                {
                    dgvBangDiaThue.ClearSelection();
                    dgvBangDiaThue.Rows[i].Cells[4].Selected = true;
                    MessageBox.Show("Lỗi, hãy nhập số ngày thuê là số > 1 , không có ký tự đặc biệt");
                }    
                else if (k == 2)
                {
                    dgvBangDiaThue.ClearSelection();
                    dgvBangDiaThue.Rows[i].Cells[4].Selected = true;
                    MessageBox.Show("Lỗi, không được để trống số ngày thuê");
                }
            }
            else
                MessageBox.Show("Khách hàng này đang có băng đĩa trễ hạn, không thể tạo phiếu thuê mới !", "Thông báo");
        }

        private void dgvBangDiaThue_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int viTri = dgvBangDiaThue.CurrentCell.RowIndex;
                if (dgvBangDiaThue[4, dgvBangDiaThue.CurrentCell.RowIndex].Value!=null)
                {
                    if (!dgvBangDiaThue[4, dgvBangDiaThue.CurrentCell.RowIndex].Value.ToString().CheckIsNumber()||Convert.ToInt32(dgvBangDiaThue[4, dgvBangDiaThue.CurrentCell.RowIndex].Value.ToString())<1)
                    {
                        MessageBox.Show("Hãy nhập số >0");
                        dgvBangDiaThue.CurrentCell = dgvBangDiaThue.Rows[viTri].Cells[4];
                        dgvBangDiaThue.ClearSelection();
                        dgvBangDiaThue.Rows[viTri].Cells[4].Selected = true;
                    }

                    else
                    {
                        if (Convert.ToInt32(dgvBangDiaThue[4, dgvBangDiaThue.CurrentCell.RowIndex].Value.ToString()) >9999)
                        {
                            dgvBangDiaThue.CurrentCell = dgvBangDiaThue.Rows[viTri].Cells[4];
                            MessageBox.Show("số ngày thuê quá lớn");
                            dgvBangDiaThue.ClearSelection();
                            dgvBangDiaThue.Rows[viTri].Cells[4].Selected = true;
                        }    
                           
                        else
                            txtTongTien.Text = TongTien(dgvBangDiaThue);
                    }
                }
                else
                {

                    dgvBangDiaThue.CurrentCell = dgvBangDiaThue.Rows[viTri].Cells[4];
                    dgvBangDiaThue.BeginEdit(true);
                    MessageBox.Show("Không được để trống");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhieuThue_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void txtMaThe_TextChanged(object sender, EventArgs e)
        {
            string maKH = ttvBUS.LayMaKhachHang(txtMaThe.Text);
            string tenKH = khBUS.LayTenKhachHang(maKH);
            txtHoTen.Text = tenKH;
        }
        private TextBox editingBox;
        private void dgvBangDiaThue_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvBangDiaThue.CurrentCell.ColumnIndex < 0) //i dont know if it ever fires with -1, so to be safe
                return;
            if (dgvBangDiaThue.CurrentCell.ColumnIndex != dgvBangDiaThue.Columns["Số ngày thuê/1 băng"].Index) //not our numeric column
                return;

            TextBox tb = (dgvBangDiaThue.EditingControl as TextBox);
            if (tb == null)
            {
                System.Diagnostics.Debugger.Break(); //you changed it to a non TextBox control. Add more support
                return;
            }
            editingBox = tb;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            tb.TextChanged += new EventHandler(tb_TextChanged);
        }
       
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&e.KeyChar!=8)
                e.Handled = true;
        }
        void tb_TextChanged(object sender, EventArgs e)
        {
            //This handles if they paste crap in the textbox since that doesn't fire the KeyDown event
            TextBox tb = (sender as TextBox);
            int i;
            if (!string.IsNullOrEmpty(tb.Text) && !int.TryParse(tb.Text, out i))
            {
                StringBuilder sb = new StringBuilder();
                for (int i1 = 0; i1 < tb.Text.Length; i1++)
                {
                    if (char.IsNumber(tb.Text[i1]))
                        sb.Append(tb.Text[i1]);
                }
                tb.Text = sb.ToString();
            }
        }

        private void btnInPhieuThue_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrintPhieuThue frm = new frmPrintPhieuThue(txtMaThe.Text, txtHoTen.Text, txtMaPhieu.Text, nv.HoTen, txtTongTien.Text, dgvBangDiaThue);        
            frm.ShowDialog();
            Show();
        }
    }
}
