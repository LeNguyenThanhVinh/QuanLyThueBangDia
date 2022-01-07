using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnteriesQLBangDia;
namespace DAL
{
    public class NhanVienDAL
    {
        DataQuanLyBangDiaDataContext db;
        public NhanVienDAL()
        {
            db = new DataQuanLyBangDiaDataContext();
        }
        //Kiểm tra có tồn tại tài khoản nhân viên không
        public bool CheckIfExistTKNV(string tk, string mk)
        {
            //tblNhanVien nvtemp = db.tblNhanViens.Where(x => x.taiKhoan == tk && x.matKhau == tk).FirstOrDefault();
            tblNhanVien nvtemp = db.tblNhanViens.Where(x => x.taiKhoan == tk).FirstOrDefault();
            if (nvtemp != null && nvtemp.matKhau.Equals(mk))
                return true;
            return false;
        }

        //Lấy nhân viên theo tài khoản 
        public eNhanVien GetNhanVienTheoTaiKhoan(string taiKhoan)
        {
            eNhanVien nhanVien = new eNhanVien();
            var dsNhanVien = (from x in db.tblNhanViens
                             where taiKhoan == x.taiKhoan.Trim()
                             select x).ToList();
            foreach (tblNhanVien nvtemp in dsNhanVien)
            {
                nhanVien.DiaChi = nvtemp.diaChi;
                nhanVien.GioiTinh = nvtemp.gioiTinh;
                nhanVien.HoTen = nvtemp.tenNhanVien;
                nhanVien.MaNhanVien = nvtemp.maNhanVien;
                nhanVien.NgaySinh = nvtemp.ngaySinh.ToString();
                nhanVien.SoDienThoai = nvtemp.soDienThoai;
                nhanVien.TaiKhoan = nvtemp.taiKhoan;
                nhanVien.MatKhau = nvtemp.matKhau;
                nhanVien.Avatar = nvtemp.avatar;
                nhanVien.TrangThai = (bool)nvtemp.trangThai;
            }
            return nhanVien;
        }


        //Thêm mới 1 nhân viên
        public int newNhanVien(eNhanVien nvMoi)        {            tblNhanVien nvtemp = new tblNhanVien();            nvtemp.diaChi = nvMoi.DiaChi;            nvtemp.gioiTinh = nvMoi.GioiTinh;            nvtemp.maNhanVien = nvMoi.MaNhanVien;            nvtemp.matKhau = nvMoi.MatKhau;            nvtemp.ngaySinh = Convert.ToDateTime(nvMoi.NgaySinh);            nvtemp.soCMND = nvMoi.SoCMND;            nvtemp.soDienThoai = nvMoi.SoDienThoai;            nvtemp.taiKhoan = nvMoi.TaiKhoan;            nvtemp.tenNhanVien = nvMoi.HoTen;
            nvtemp.trangThai = nvMoi.TrangThai;
            nvtemp.avatar = nvMoi.Avatar;
            db.tblNhanViens.InsertOnSubmit(nvtemp);            db.SubmitChanges();            return 1;        }

        //Xóa nhân viên
        public bool XoaNV(string maNV)        {            tblNhanVien nvtemp = db.tblNhanViens.Where(x => x.maNhanVien == maNV).FirstOrDefault();            if (nvtemp != null)            {                db.tblNhanViens.DeleteOnSubmit(nvtemp);                db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }            return false;        }


    }
}
