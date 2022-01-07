using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueBangDia
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap frm = new QuanLyThueBangDia.frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string taiKhoan = frm.txtUser.Text;
                string matKhau = frm.txtPass.Text;
                Application.Run(new frmTrangChu(taiKhoan, matKhau));
            }
            
        }
    }
}
