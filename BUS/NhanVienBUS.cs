using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EnteriesQLBangDia;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL nvDAL;
        public NhanVienBUS()
        {
            nvDAL = new NhanVienDAL();
        }
        //Kiểm tra có tồn tại tài khoản nhân viên không
        public bool CheckIfExistTKNV(string tk, string mk)
        {
            return nvDAL.CheckIfExistTKNV(tk, mk);
        }

        //Lấy nhân viên theo tài khoản 
        public eNhanVien GetNhanVienTheoTaiKhoan(string taiKhoan)
        {
            return nvDAL.GetNhanVienTheoTaiKhoan(taiKhoan);
        }

        //Xóa nhân viên
        public bool XoaNV(string maNV)        {            return nvDAL.XoaNV(maNV);        }
        //Thêm mới 1 nhân viên
        public int newNhanVien(eNhanVien nvMoi)        {            return nvDAL.newNhanVien(nvMoi);        }

    }
}
