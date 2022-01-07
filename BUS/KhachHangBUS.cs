using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EnteriesQLBangDia;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAL khDAL;
        public KhachHangBUS()
        {
            khDAL = new KhachHangDAL();
        }
        public string LayTenKhachHang(string maKH)
        {
            return khDAL.LayTenKhachHang(maKH);
        }
        public string LayMaKHCoMaLonNhat()
        {
            return khDAL.LayMaKHCoMaLonNhat();
        }
        public List<eKhachHang> getAllKhachHang()
        {
            return khDAL.getAllKhachHang();
        }
        public bool CheckIfExistKH(string soCMND)
        {
            return khDAL.CheckIfExistKH( soCMND);
        }
        public int ThemKhachHang(eKhachHang newKhachHang)
        {
            return khDAL.ThemKhachHang(newKhachHang);
        }
        //xóa khách hàng
        public bool XoaKhachHang(string maKhachHang)
        {
            return khDAL.XoaKhachHang(maKhachHang);
        }
        //sửa khách hàng
        public void SuaKhachHang(eKhachHang khSua)
        {
            khDAL.SuaKhachHang(khSua);
        }


        //Tìm kiếm
        public List<eKhachHang> TimKiemKhachHangTheoMa(string maKH)
        {
            return khDAL.TimKiemKhachHangTheoMa(maKH);
        }
        public List<eKhachHang> TimKiemKhachHangTheoTen(string tenKH)
        {
            return khDAL.TimKiemKhachHangTheoTen(tenKH);
        }
        public List<eKhachHang> TimKiemKhachHangTheoMaVaTen(string maKH, string tenKH)
        {
            return khDAL.TimKiemKhachHangTheoMaVaTen(maKH, tenKH);
        }
    }
}
