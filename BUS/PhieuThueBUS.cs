using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EnteriesQLBangDia;

namespace BUS
{
    public class PhieuThueBUS
    {
        PhieuThueDAL ptDAL;
        public PhieuThueBUS()
        {
            ptDAL = new PhieuThueDAL();
        }
        public int newPhieuThue(ePhieuThue ptMoi)
        {
            return ptDAL.newPhieuThue(ptMoi);
        }
        public string LayMaPhieuThueCoMaLonNhat()
        {
            return ptDAL.LayMaPhieuThueCoMaLonNhat();
        }
        public List<ePhieuThue> LayHetPhieuThueTheoMaThe(string maThe)
        {
            return ptDAL.LayHetPhieuThueTheoMaThe(maThe);
        }
        public List<ePhieuThue> LayHetPhieuThue()
        {
            return ptDAL.LayHetPhieuThue();
        }
        //xóa phiếu thuê
        public bool XoaPhieuThue(string maPhieuThue)
        {
            return ptDAL.XoaPhieuThue(maPhieuThue);
        }
        //Cập nhật số tiền trong phiếu thuê
        public void SuaPhieuThue(ePhieuThue ptUpdate, int soTien)
        {
            ptDAL.SuaPhieuThue(ptUpdate, soTien);
        }
        //Lấy phiếu thuê theo mã
        public ePhieuThue LayPhieuThueTheoMa(string maPhieuThue)
        {
            return ptDAL.LayPhieuThueTheoMa(maPhieuThue);
        }
        //Lấy phiếu thuê đã trả đủ theo mã thẻ khách hàng
        public List<ePhieuThue> LayPhieuThueDaTra(string maThe)
        {
            return ptDAL.LayPhieuThueDaTra(maThe);
        }
        //Lấy phiếu thuê quá hạn theo mã thẻ khách hàng
        public List<ePhieuThue> LayPhieuThueQuaHan(string maThe)
        {
            return ptDAL.LayPhieuThueQuaHan(maThe);
        }
        //Lấy phiếu thuê đang thuê theo mã thẻ khách hàng
        public List<ePhieuThue> LayPhieuThueDangThue(string maThe)
        {
            return ptDAL.LayPhieuThueDangThue(maThe);
        }

        //Chuyển phiếu thuê sang thẻ khác
        public void ChuyenPhieuThueSangTheKhac(string maTheCu, string maTheMoi)
        {
            ptDAL.ChuyenPhieuThueSangTheKhac(maTheCu, maTheMoi);
        }

        //Chuyển phiếu thuê sang nhân viên khác
        public void ChuyenPhieuThueSangNhanVienKhac(string maNVCu, string maNVMoi)
        {
            ptDAL.ChuyenPhieuThueSangNhanVienKhac(maNVCu, maNVMoi);
        }
    }
}
