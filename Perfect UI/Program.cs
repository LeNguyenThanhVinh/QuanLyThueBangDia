using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueBangDia;

namespace Perfect_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmSplashSrceen frmWaiting = new frmSplashSrceen();
            frmWaiting.ShowDialog();
            
            frmDangNhap frm = new QuanLyThueBangDia.frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string taiKhoan = frm.txtUser.Text;
                string matKhau = frm.txtPass.Text;
                Application.Run(new Form2(taiKhoan, matKhau));
                //Application.Run(new Form2());
            }

            //   Application.Run(new frmLogin());
        }
    }
}
