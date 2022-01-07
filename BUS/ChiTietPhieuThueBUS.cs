using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EnteriesQLBangDia;

namespace BUS
{
    public class ChiTietPhieuThueBUS
    {
        ChiTietPhieuThueDAL ctptDAL;
        public ChiTietPhieuThueBUS()
        {
            ctptDAL = new ChiTietPhieuThueDAL();
        }
        public int newChiTietPhieuThue(eChiTietPhieuThue ctptMoi)
        {
            return ctptDAL.newChiTietPhieuThue(ctptMoi);
        }
        public List<eChiTietPhieuThue> LayHetChiTietPhieuThueTheoMaThe(string maPhieuThue)
        {
            return ctptDAL.LayHetChiTietPhieuThueTheoMaThe(maPhieuThue);
        }
        public void CapNhat(eChiTietPhieuThue ctptUpdate)
        {
            ctptDAL.CapNhat(ctptUpdate);
        }
        //Lấy chi tiết phiếu theo mã phiếu và mã băng đĩa
        public eChiTietPhieuThue LayCTPTTheoMaPhieuMaDia(string maPhieu, string maThe)
        {
            return ctptDAL.LayCTPTTheoMaPhieuMaDia(maPhieu, maThe);
        }
        public bool KiemTraCoBangDiaTreHan(string maThe)
        {
            return ctptDAL.KiemTraCoBangDiaTreHan(maThe);
        }
        //Kiểm tra phiếu thuê này có băng đĩa chưa trả không
        public bool KiemTraBangDiaChuaTra(string maPhieu)
        {
            return ctptDAL.KiemTraBangDiaChuaTra(maPhieu);
        }
        //Xóa toàn bộ chi tiết phiếu thuê theo mã phiếu thuê
        public bool XoaChiTietPhieuThue(string maPhieuThue)
        {
            return ctptDAL.XoaChiTietPhieuThue(maPhieuThue);
        }
        //Xóa 1 chi tiết phiếu thuê
        public bool Xoa1ChiTietPhieuThue(string maPhieuThue, string maBangDia)
        {
            return ctptDAL.Xoa1ChiTietPhieuThue(maPhieuThue, maBangDia);
        }
        
    }
}
