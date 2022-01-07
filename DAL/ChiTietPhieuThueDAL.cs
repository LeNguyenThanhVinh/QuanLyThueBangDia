using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnteriesQLBangDia;
namespace DAL
{
    public class ChiTietPhieuThueDAL
    {
        DataQuanLyBangDiaDataContext db;
        public ChiTietPhieuThueDAL()
        {
            db = new DataQuanLyBangDiaDataContext();
        }
        //Tạo mới 1 chi tiết phiếu thuê
        public int newChiTietPhieuThue(eChiTietPhieuThue ctptMoi)
        {
            tblChiTietPhieuThue ctpttemp = new tblChiTietPhieuThue();
            ctpttemp.maPhieuThue = ctptMoi.MaPhieuThue;
            ctpttemp.maBangDia = ctptMoi.MaBangDia;
            ctpttemp.soLuongThue = ctptMoi.SoLuongThue;
            ctpttemp.soNgayThue = ctptMoi.SoNgayThue;
            ctpttemp.soLuongDaTra = ctptMoi.SoLuongDaTra;
            db.tblChiTietPhieuThues.InsertOnSubmit(ctpttemp);
            db.SubmitChanges();
            return 1;
        }
        //Lấy chi tiết phiếu thuê theo mã phiếu thuê
        public List<eChiTietPhieuThue> LayHetChiTietPhieuThueTheoMaThe(string maPhieuThue)
        {
            List<eChiTietPhieuThue> ls = new List<eChiTietPhieuThue>();
            var dsChiTietPhieuThue = (from x in db.tblChiTietPhieuThues
                                       where maPhieuThue == x.maPhieuThue.Trim()
                                       select x).ToList();
            foreach (tblChiTietPhieuThue ctpt in dsChiTietPhieuThue)
            {
                eChiTietPhieuThue p = new eChiTietPhieuThue();
                p.MaPhieuThue = ctpt.maPhieuThue;
                p.MaBangDia = ctpt.maBangDia;
                p.SoLuongThue = Convert.ToInt32(ctpt.soLuongThue);
                p.SoNgayThue = Convert.ToInt32(ctpt.soNgayThue);
                p.SoLuongDaTra =Convert.ToInt32(ctpt.soLuongDaTra);
                ls.Add(p);
            }
            return ls;
        }
        //Cập nhật chi tiết phiếu thuê
        public void CapNhat(eChiTietPhieuThue ctptUpdate)
        {
            IQueryable<tblChiTietPhieuThue> bd = from x in db.tblChiTietPhieuThues
                                                    where x.maBangDia==ctptUpdate.MaBangDia && x.maPhieuThue==ctptUpdate.MaPhieuThue
                                                    select x;
            // cập nhật dữ liệu
            bd.First().maPhieuThue = ctptUpdate.MaPhieuThue;
            bd.First().maBangDia = ctptUpdate.MaBangDia;
            bd.First().soLuongDaTra = Convert.ToInt32(ctptUpdate.SoLuongDaTra);
            bd.First().soLuongThue =Convert.ToInt32(ctptUpdate.SoLuongThue);
            bd.First().soNgayThue =Convert.ToInt32(ctptUpdate.SoNgayThue);
            db.SubmitChanges();
        }
        // lấy chi tiết phiếu thuê theo mã băng đĩa
        public eChiTietPhieuThue LayCTPTTheoMaPhieuMaDia(string maPhieu, string maBangDia)
        {
            eChiTietPhieuThue ctpt = new eChiTietPhieuThue();
            var dsctpt = (from x in db.tblChiTietPhieuThues
                             where maBangDia == x.maBangDia.Trim() && maPhieu==x.maPhieuThue.Trim()
                             select x).ToList();
            foreach (tblChiTietPhieuThue ctpttmp in dsctpt)
            {
                ctpt.MaBangDia = ctpttmp.maBangDia;
                ctpt.MaPhieuThue = ctpttmp.maPhieuThue;
                ctpt.SoLuongDaTra =Convert.ToInt32(ctpttmp.soLuongDaTra);
                ctpt.SoLuongThue = Convert.ToInt32(ctpttmp.soLuongThue);
                ctpt.SoNgayThue =Convert.ToInt32(ctpttmp.soNgayThue);
            }
            return ctpt;
        }
        
        // Kiểm tra băng đĩa bị trễ hạn theo mã phiếu thuê theo mã thẻ, nếu thẻ đó có băng đĩa trễ hạn sẽ không cho tạo phiếu mới
        public bool KiemTraCoBangDiaTreHan(string maThe)
        {
            List<ePhieuThue> ls = new List<ePhieuThue>();
            PhieuThueDAL ptDAL = new PhieuThueDAL();
            ls = ptDAL.LayHetPhieuThueTheoMaThe(maThe);

            foreach(ePhieuThue pttmp in ls)
            {
                var dsChiTietPhieuThue = (from x in db.tblChiTietPhieuThues
                                          where pttmp.MaPhieuThue == x.maPhieuThue.Trim()
                                          select x).ToList();
                foreach (tblChiTietPhieuThue ctpt in dsChiTietPhieuThue)
                {
                    DateTime newday = new DateTime();
                    newday = Convert.ToDateTime(pttmp.NgayLap).AddDays(Convert.ToInt32(ctpt.soNgayThue));
                    int result = newday.CompareTo(DateTime.Now);

                    if (ctpt.soLuongDaTra!=ctpt.soLuongThue && result == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //Kiểm tra phiếu thuê này có băng đĩa chưa trả không
        public bool KiemTraBangDiaChuaTra(string maPhieu)
        {
            eChiTietPhieuThue ctpttemp = new eChiTietPhieuThue();
            var dsChiTietPhieuThue = (from x in db.tblChiTietPhieuThues
                                      where x.maPhieuThue.Trim() == maPhieu.Trim()
                                      select x).ToList();
            foreach(tblChiTietPhieuThue ctpt in dsChiTietPhieuThue)
            {
                if (ctpt.soLuongThue > ctpt.soLuongDaTra)
                {
                    return false;
                }
            }
            return true;
        }
        //Xóa toàn bộ chi tiết phiếu thuê theo mã phiếu thuê
        public bool XoaChiTietPhieuThue(string maPhieuThue)
        {
            var dsChiTietPhieuThue = (from x in db.tblChiTietPhieuThues
                                      where maPhieuThue == x.maPhieuThue.Trim()
                                      select x).ToList();
            int count = 0;
            foreach (tblChiTietPhieuThue ctpt in dsChiTietPhieuThue)
            {
                if (ctpt != null)
                {
                    db.tblChiTietPhieuThues.DeleteOnSubmit(ctpt);
                    db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                    count++;
                    
                }
            }
            if (count == dsChiTietPhieuThue.Count)
                return true; //xóa thành công
            else
                return false;
        }

        //Xóa 1 chi tiết phiếu thuê
        public bool Xoa1ChiTietPhieuThue(string maPhieuThue, string maBangDia)
        {
            tblChiTietPhieuThue ctpttemp = db.tblChiTietPhieuThues.Where(x => x.maPhieuThue== maPhieuThue && x.maBangDia==maBangDia).FirstOrDefault();
            if (ctpttemp != null)
            {
                db.tblChiTietPhieuThues.DeleteOnSubmit(ctpttemp);
                db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }
            return false;
        }
        
    }
}
