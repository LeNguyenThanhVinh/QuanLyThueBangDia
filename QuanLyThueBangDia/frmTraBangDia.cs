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
    public partial class frmTraBangDia : Form
    {
        List<ePhieuThue> listPT;
        List<eChiTietPhieuThue> listCTPT;
        PhieuThueBUS ptBUS;
        BangDiaBUS bdBUS;
        ChiTietPhieuThueBUS ctptBUS;
        TheThanhVienBUS ttvBUS;
        public int[] trangThai = new int[100]; //Dùng để lưu cố định , nếu số lượng đã trả = số lượng thuê thì trạng thái = 1, ngược lại nếu < hơn thì = 0
        int[] soLuongTra = new int[100]; // Dùng để lưu cố định các số lượng đã trả của phiếu thuê được lấy ra từ cơ sở dữ liệu
        public frmTraBangDia()
        {
            InitializeComponent();
            bdBUS = new BangDiaBUS();
            ptBUS = new PhieuThueBUS();
            ctptBUS = new ChiTietPhieuThueBUS();
            ttvBUS = new TheThanhVienBUS();
            dgvDanhSachBangDia.ClearSelection();
            editingBox = default(TextBox);
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
        //khởi tạo các trạng thái vào cột checkbox
        void TaoTrangThai(string  maPhieuThue, DataGridView dgv)
        {
            listCTPT = new List<eChiTietPhieuThue>();
            listCTPT = ctptBUS.LayHetChiTietPhieuThueTheoMaThe(LayMaPhieuThue(dgvPhieuThue).ToString());
            int count = 0;
            foreach(eChiTietPhieuThue ctpttmp in listCTPT)
            {
                if (ctpttmp.SoLuongDaTra == ctpttmp.SoLuongThue)
                {
                    ((DataGridViewCheckBoxCell)dgv.Rows[count].Cells[0]).Value = true;

                }
                else
                {
                    ((DataGridViewCheckBoxCell)dgv.Rows[count].Cells[0]).Value = false;
                }    
                    
                count++;
            }    

        }
        //thay đổi số lượng khi click vào checkbox
        void ThayDoiSoLuong(DataGridView dgv)
        {
            int index = dgv.CurrentCell.ColumnIndex;
            int index2 = dgv.CurrentCell.RowIndex;
            
            if(index==0)
            {
                if (((DataGridViewCheckBoxCell)dgvDanhSachBangDia.Rows[index2].Cells[0]).Value.ToString() == "False"&&trangThai[index2]==0)
                {
                    dgv[5, index2].Value = dgv[3, index2].Value;
                    ((DataGridViewCheckBoxCell)dgv.Rows[index2].Cells[0]).Value = true;
                }
                else if(((DataGridViewCheckBoxCell)dgvDanhSachBangDia.Rows[index2].Cells[0]).Value.ToString() == "True"&&trangThai[index2]==0)
                {
                    dgv[5, index2].Value = 0;
                    ((DataGridViewCheckBoxCell)dgv.Rows[index2].Cells[0]).Value = false;
                }
                    
            }

        }
        //Lấy mã phiếu thuê khi click vào cột
        string LayMaPhieuThue(DataGridView dgv)
        {
            string maPhieu = "";
            int index = dgv.CurrentCell.RowIndex;
            maPhieu = dgv.Rows[index].Cells[0].Value.ToString();
            return maPhieu;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (ttvBUS.CheckIfExist(txtMaKhachHang.Text))
            {
                listPT = new List<ePhieuThue>();
                listPT = ptBUS.LayHetPhieuThueTheoMaThe(txtMaKhachHang.Text);

                dgvPhieuThue.DataSource = listPT.ToList();
                CreateColumnDGVPhieuThue(dgvPhieuThue);
            }
            else
                MessageBox.Show("Không tìm thấy mã thẻ: " + txtMaKhachHang.Text, "Thông báo");
            
        }

        private void frmTraBangDia_Load(object sender, EventArgs e)
        {
            cboPhieuThueLoc.SelectedIndex = 3;
            this.AcceptButton = btnTimKiem;
            foreach (DataGridViewColumn cl in dgvDanhSachBangDia.Columns)
            {
                cl.Visible = false;
            }

            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            txtMaKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<eTheThanhVien> lstttv = new List<eTheThanhVien>();
            lstttv = ttvBUS.getAllThe();
            foreach (eTheThanhVien t in lstttv)
            {
                auto1.Add(t.MaThe);
            }
            txtMaKhachHang.AutoCompleteCustomSource = auto1;

            
        }

        private void dgvPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewColumn cl in dgvDanhSachBangDia.Columns)
            {
                cl.Visible = true;
            }
            for(int k = 0; k < soLuongTra.Length; k++)
            {
                soLuongTra[k] = 0;
            }
            listCTPT = new List<eChiTietPhieuThue>();
            listCTPT = ctptBUS.LayHetChiTietPhieuThueTheoMaThe(LayMaPhieuThue(dgvPhieuThue).ToString());
            dgvDanhSachBangDia.DataSource = listCTPT.ToList();
            CreateColumnDGVBangDia(dgvDanhSachBangDia);
            TaoTrangThai(LayMaPhieuThue(dgvPhieuThue).ToString(), dgvDanhSachBangDia);
            int i = 0;
            foreach(eChiTietPhieuThue ctp in listCTPT)
            {
                if (ctp.SoLuongThue == ctp.SoLuongDaTra)
                {
                    trangThai[i] = 1;
                    dgvDanhSachBangDia.Rows[i].ReadOnly = true;
                }
                else
                    trangThai[i] = 0;

                soLuongTra[i] = ctp.SoLuongDaTra;
                i++;
            }
            dgvDanhSachBangDia.ClearSelection();
        }

        private void dgvDanhSachBangDia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ThayDoiSoLuong(dgvDanhSachBangDia);
        }

        private void dgvDanhSachBangDia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ThayDoiSoLuong(dgvDanhSachBangDia);
        }
        int TraVeSoLuongTruoc(DataGridView dgv, int index)//Dùng để trả về giá trị được chọn trước đó nếu số lượng được chọn tiếp theo lớn hơn số lượng trong kho
        {
            int k = 0;
            if(Convert.ToInt32(dgv[5, index].Value)>Convert.ToInt32(dgv[3, index].Value))
            {
                dgv[5, index].Value = soLuongTra[index];
                k = 1;
                return k;
            }    
            else if(Convert.ToInt32(dgv[5,index].Value)<soLuongTra[index])
            {
                dgv[5, index].Value = soLuongTra[index];
                k = 2;
                return k;
            }
            
            return k;
        }
        private void dgvDanhSachBangDia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachBangDia.SelectedCells.Count > 0)
            {
                int index = dgvDanhSachBangDia.CurrentCell.RowIndex;
                int k = Convert.ToInt32(TraVeSoLuongTruoc(dgvDanhSachBangDia, index)) ;//Tại sao phải dùng biến k ???? sao không dùng trực tiếp ???
                                                                                       // Dùng trực tiếp sẽ bị 1 đống lỗi khó hiểu và tốn mất 2h đồng hồ :)) 
                if (k == 2)
                    MessageBox.Show("Số lượng trả hiện tại không được nhỏ hơn số lượng đã trả","Thông báo");
                else if (k == 1)
                    MessageBox.Show("Số lượng trả không được lớn hơn số lượng thuê", "Thông báo");
                
            }
            dgvDanhSachBangDia.ClearSelection();
        }

        //Thêm số lượng vào kho khi trả băng đĩa
        void TraBangDia(DataGridView dgv)
        {
            int soLuongDuocThem = 0;
            eBangDia bdtmp;
            eChiTietPhieuThue ctpttmp;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bdtmp = new eBangDia();
                ctpttmp = new eChiTietPhieuThue();
                bdtmp = bdBUS.getBangDiaTheoMaChuan(dgv[2, i].Value.ToString());
                ctpttmp = ctptBUS.LayCTPTTheoMaPhieuMaDia(dgv[1, i].Value.ToString(), dgv[2, i].Value.ToString());

                soLuongDuocThem = Convert.ToInt32(dgv[5, i].Value) - soLuongTra[i];

                bdtmp.SoLuongTon += soLuongDuocThem;
                ctpttmp.SoLuongDaTra = Convert.ToInt32(dgv[5, i].Value);
                bdBUS.truSoLuong(bdtmp);
                ctptBUS.CapNhat(ctpttmp);
            }
            MessageBox.Show("Lưu thành công", "Thông báo");
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            TraBangDia(dgvDanhSachBangDia);
            for(int i =0; i<dgvDanhSachBangDia.Rows.Count;i++)
            {
                soLuongTra[i] = Convert.ToInt32(dgvDanhSachBangDia[5, i].Value);
            }    
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listPT = new List<ePhieuThue>();
            listPT = ptBUS.LayHetPhieuThueTheoMaThe(txtMaKhachHang.Text);
            dgvDanhSachBangDia.DataSource = null;
            dgvPhieuThue.DataSource = listPT.ToList();
            CreateColumnDGVPhieuThue(dgvPhieuThue);
            foreach (DataGridViewColumn cl in dgvDanhSachBangDia.Columns)
            {
                cl.Visible = false;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thẻ khách hàng");
            }
            else
            {
                if (ttvBUS.CheckIfExist(txtMaKhachHang.Text))
                {
                    listPT = new List<ePhieuThue>();
                    //
                    if (cboPhieuThueLoc.SelectedIndex == 0)
                    {
                        listPT = ptBUS.LayPhieuThueDaTra(txtMaKhachHang.Text);
                    }
                    else if (cboPhieuThueLoc.SelectedIndex == 1)
                    {
                        listPT = ptBUS.LayPhieuThueQuaHan(txtMaKhachHang.Text);
                    }
                    else if (cboPhieuThueLoc.SelectedIndex == 2)
                    {
                        listPT = ptBUS.LayPhieuThueDangThue(txtMaKhachHang.Text);
                    }
                    else if (cboPhieuThueLoc.SelectedIndex == 3)
                    {
                        listPT = ptBUS.LayHetPhieuThueTheoMaThe(txtMaKhachHang.Text);
                    }

                    dgvPhieuThue.DataSource = listPT.ToList();
                    CreateColumnDGVPhieuThue(dgvPhieuThue);
                }
                else
                    MessageBox.Show("Không tìm thấy mã thẻ: " + txtMaKhachHang.Text, "Thông báo");

            }
        }
        private TextBox editingBox;
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
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

        private void dgvDanhSachBangDia_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDanhSachBangDia.CurrentCell.ColumnIndex < 0) //i dont know if it ever fires with -1, so to be safe
                return;
            if (dgvDanhSachBangDia.CurrentCell.ColumnIndex != 5) //not our numeric column
                return;

            TextBox tb = (dgvDanhSachBangDia.EditingControl as TextBox);
            if (tb == null)
            {
                System.Diagnostics.Debugger.Break(); //you changed it to a non TextBox control. Add more support
                return;
            }
            editingBox = tb;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            tb.TextChanged += new EventHandler(tb_TextChanged);
        }

        private void btnToanBoPhieu_Click(object sender, EventArgs e)
        {
            listPT = ptBUS.LayHetPhieuThue();
            dgvPhieuThue.DataSource = null;
            dgvPhieuThue.DataSource = listPT.ToList();
            CreateColumnDGVPhieuThue(dgvPhieuThue);
        }
    }
}
