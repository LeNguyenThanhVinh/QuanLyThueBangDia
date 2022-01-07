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
using System.Threading;

namespace QuanLyThueBangDia
{
    public partial class frmDangNhap : Form
    {
        NhanVienBUS nvBUS;
        public frmDangNhap()
        {
            InitializeComponent();
            nvBUS = new NhanVienBUS();
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        void dangNhap()
        {
            if (txtUser.Text.Length == 0 && txtPass.Text.Length == 0)
                MetroFramework.MetroMessageBox.Show(this, "Bạn chưa nhập UserID và Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            else if (txtUser.Text.Length == 0)
                MetroFramework.MetroMessageBox.Show(this, "Bạn chưa đăng nhập UserID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            else if (txtPass.Text.Length == 0)
                MetroFramework.MetroMessageBox.Show(this, "Bạn chưa đăng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            else if(nvBUS.CheckIfExistTKNV(txtUser.Text, txtPass.Text))
            {
                if (NhanVienServices.isActiveStaff(txtUser.Text, txtPass.Text))
                {
                    Perfect_UI.Form2 fMain = new Perfect_UI.Form2(txtUser.Text.Trim(), txtPass.Text.Trim());
                    this.Hide();
                    fMain.ShowDialog();
                    this.Show(); 
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Nhân viên đã nghỉ việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);               
            }               
            else
                MetroFramework.MetroMessageBox.Show(this, "Sai tài khoản hoặc mật khẩu", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //Hide();
            //bool done = false;
            //ThreadPool.QueueUserWorkItem((x) =>
            //{
            //    using (var splashForm = new Perfect_UI.frmSplashSrceen())
            //    {
            //        splashForm.Show();
            //        while (!done)
            //            Application.DoEvents();
            //        splashForm.Close();
            //    }
            //});

            //Thread.Sleep(7500);
            //done = true;
            //Show();

            txtUser.Focus();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if (dangNhap() == false)
            //    this.Hide();
            //this.Close();
            dangNhap();
        }

        private void Switch1_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;

            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            if (Switch1.Checked)
            {
                Switch1.Checked = false;
            }
            else
                Switch1.Checked = true;
        }
    }
}
