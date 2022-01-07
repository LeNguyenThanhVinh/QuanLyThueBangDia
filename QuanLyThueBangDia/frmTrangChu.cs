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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        string tk = "";
        string mk = "";
        NhanVienBUS nvBUS;
        public eNhanVien nvTrangChu;
        public frmTrangChu(string taiKhoan, string matKhau)
        {
            InitializeComponent();
            nvBUS = new NhanVienBUS();
            nvTrangChu = new eNhanVien();
            tk = taiKhoan;
            mk = matKhau;
            nvTrangChu = nvBUS.GetNhanVienTheoTaiKhoan(tk);
        }
        //Chuyển form
        private bool CheckExistForm(string nameForm)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == nameForm)
                {
                    check = true;
                    break;
                }
            }    
            return check;
        }

        private void ActiveChildForm(string nameForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == nameForm)
                {
                    frm.Activate();
                    break;
                }
            }
         
        }


        private void openChildForm(Form frmChild)
        {
            if (!CheckExistForm(frmChild.Name))
            {
                this.IsMdiContainer = true;
                frmChild.MdiParent = this;
                frmChild.TopLevel = false;
                frmChild.FormBorderStyle = FormBorderStyle.None;
                frmChild.Dock = DockStyle.Fill;
                frmChild.BringToFront();
                frmChild.Show();
            }
            else
                ActiveChildForm(frmChild.Name);
        }
        

        private void frmThueBangDia_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = nvTrangChu.MaNhanVien.ToString();
            txtTenNV.Text = nvTrangChu.HoTen.ToString();
            timeNow.Start();
        }

        private void btnQLThue_Click(object sender, EventArgs e)
        {
            if (pnlQLThue.Height < 100)
                pnlQLThue.Height = 165;
            else
                pnlQLThue.Height = 50;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width > 100)
                pnlMenu.Width = 1;
            else
                pnlMenu.Width = 223;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (pnlThongKe.Height < 90)
                pnlThongKe.Height = 165;
            else
                pnlThongKe.Height = 50;
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            if (pnlQLKhachHang.Height < 90)
                pnlQLKhachHang.Height = 125;
            else
                pnlQLKhachHang.Height = 49;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void btnTaoPhieuThue_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmTaoPhieuThue(nvTrangChu));
        }

        private void btnTraBangDia_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmTraBangDia());
        }

        private void btnXoaSuaPhieuThue_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmXoaSuaPhieuThue());
        }

        private void btnQLBangDia_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLBangDia());
        }

        private void btnTKDoanhThuTuan_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTKDoanhThu());
        }

        private void btnDSBangDiaThueNhieu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDSBangDiaThueNhieu());
        }

        private void btnDSKMuonQuaHan_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDSKhachQuaHan());
        }

        private void btnTheKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheKhachHang());
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            lblGio.Text = DateTime.Now.ToLongTimeString();
            lblNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
