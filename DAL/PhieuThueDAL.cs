using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnteriesQLBangDia;
namespace DAL
{
    public class PhieuThueDAL
    {
        DataQuanLyBangDiaDataContext db;
        public PhieuThueDAL()
        {
            db = new DataQuanLyBangDiaDataContext();
        }
        //Tạo mới 1 phiếu thuê
        public int newPhieuThue(ePhieuThue ptMoi)
        {
            tblPhieuThue pttemp = new tblPhieuThue();
            pttemp.maNhanVien = ptMoi.MaNhanVien;
            pttemp.maPhieuThue = ptMoi.MaPhieuThue;
            pttemp.maThe = ptMoi.MaThe;
            pttemp.ngayLap = Convert.ToDateTime(ptMoi.NgayLap);
            pttemp.thanhTien = ptMoi.ThanhTien;
            db.tblPhieuThues.InsertOnSubmit(pttemp);
            db.SubmitChanges();
            return 1;
        }
        //Lấy hết phiếu thuê
        public List<ePhieuThue> LayHetPhieuThue()
        {
            IEnumerable<tblPhieuThue> phieuthuelist = db.tblPhieuThues;
            List<ePhieuThue> ls = new List<ePhieuThue>();
            foreach (tblPhieuThue pt in phieuthuelist)
            {
                ePhieuThue p = new ePhieuThue();
                p.MaThe = pt.maThe;
                p.MaNhanVien = pt.maNhanVien;
                p.MaPhieuThue = pt.maPhieuThue;
                p.NgayLap = pt.ngayLap.ToString();
                p.ThanhTien =Convert.ToInt32(pt.thanhTien);          
                ls.Add(p);
            }
            return ls;
        }
        //Lấy phiếu thuê có mã lớn nhất
        public string  LayMaPhieuThueCoMaLonNhat()
        {
            string mapt = "";
            List<ePhieuThue> ls = new List<ePhieuThue>();
            ls = LayHetPhieuThue();
            int a = 0;
            foreach(ePhieuThue pttemp in ls)
            {
                if (a <= Convert.ToInt32(pttemp.MaPhieuThue.ToString().Substring(2).Trim())){
                    a = Convert.ToInt32(pttemp.MaPhieuThue.ToString().Substring(2).Trim());
                }
            }
            mapt = a.ToString();
            return mapt;
        }
        //Lấy phiếu thuê theo mã thẻ khách hàng
        public List<ePhieuThue> LayHetPhieuThueTheoMaThe(string maThe)
        {
            List<ePhieuThue> ls = new List<ePhieuThue>();
            var dsPhieuThue = (from x in db.tblPhieuThues
                             where maThe == x.maThe.Trim()
                             select x).ToList();
            foreach (tblPhieuThue pt in dsPhieuThue)
            {
                ePhieuThue p = new ePhieuThue();
                p.MaThe = pt.maThe;
                p.MaNhanVien = pt.maNhanVien;
                p.MaPhieuThue = pt.maPhieuThue;
                p.NgayLap = pt.ngayLap.ToString();
                p.ThanhTien = Convert.ToInt32(pt.thanhTien);
                ls.Add(p);
            }
            return ls;
        }
        //xóa phiếu thuê
        public bool XoaPhieuThue(string maPhieuThue)
        {
            tblPhieuThue pttemp = db.tblPhieuThues.Where(x => x.maPhieuThue == maPhieuThue).FirstOrDefault();
            if (pttemp != null)
            {
                db.tblPhieuThues.DeleteOnSubmit(pttemp);
                db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }
            return false;
        }
        //Cập nhật số tiền trong phiếu thuê
        public void SuaPhieuThue(ePhieuThue ptUpdate, int soTien)
        {
            IQueryable<tblPhieuThue> pt = from x in db.tblPhieuThues
                                        where x.maPhieuThue.Equals(ptUpdate.MaPhieuThue)
                                        select x;
            // cập nhật dữ liệu
            pt.First().maPhieuThue = ptUpdate.MaPhieuThue;
            pt.First().maNhanVien = ptUpdate.MaNhanVien;
            pt.First().maThe = ptUpdate.MaThe;
            pt.First().ngayLap =Convert.ToDateTime(ptUpdate.NgayLap);
            pt.First().thanhTien = soTien;
            db.SubmitChanges();
        }
        //Lấy phiếu thuê theo mã
        public ePhieuThue LayPhieuThueTheoMa(string maPhieuThue)
        {
            ePhieuThue phieuThue = new ePhieuThue();
            var dsPhieuThue = (from x in db.tblPhieuThues
                             where maPhieuThue == x.maPhieuThue.Trim()
                             select x).ToList();
            foreach (tblPhieuThue pttemp in dsPhieuThue)
            {
                phieuThue.MaPhieuThue = pttemp.maPhieuThue;
                phieuThue.MaNhanVien = pttemp.maNhanVien;
                phieuThue.MaThe = pttemp.maThe;
                phieuThue.NgayLap = pttemp.ngayLap.ToString();
                phieuThue.ThanhTien = Convert.ToInt32(pttemp.thanhTien);
            }
            return phieuThue;
        }
        //Lấy phiếu thuê đã trả đủ theo mã thẻ khách hàng
        public List<ePhieuThue> LayPhieuThueDaTra(string maThe)
        {
            List<ePhieuThue> ls = new List<ePhieuThue>();
            var dsPhieuThue = (from x in db.tblPhieuThues
                               where maThe == x.maThe.Trim()
                               select x).ToList();
            foreach (tblPhieuThue pt in dsPhieuThue)
            {
                List<eChiTietPhieuThue> lsctpt = new List<eChiTietPhieuThue>();
                var dsCTPhieuThue = (from x in db.tblChiTietPhieuThues
                                     where pt.maPhieuThue == x.maPhieuThue.Trim()
                                     select x).ToList();
                int i = dsCTPhieuThue.Count();
                foreach (tblChiTietPhieuThue ctpt in dsCTPhieuThue)
                {
                    if (ctpt.soLuongThue == ctpt.soLuongDaTra)
                    {
                        i--;
                    }
                    else
                    {
                        i = 1000;
                        break;
                    }
                }
                if (i == 0)
                {
                    ePhieuThue p = new ePhieuThue();
                    p.MaThe = pt.maThe;
                    p.MaNhanVien = pt.maNhanVien;
                    p.MaPhieuThue = pt.maPhieuThue;
                    p.NgayLap = pt.ngayLap.ToString();
                    p.ThanhTien = Convert.ToInt32(pt.thanhTien);
                    ls.Add(p);
                }

            }
            return ls;
        }
        //Lấy phiếu thuê quá hạn theo mã thẻ khách hàng
        public List<ePhieuThue> LayPhieuThueQuaHan(string maThe)
        {
            List<ePhieuThue> ls = new List<ePhieuThue>();
            var dsPhieuThue = (from x in db.tblPhieuThues
                               where maThe == x.maThe.Trim()
                               select x).ToList();
            foreach (tblPhieuThue pt in dsPhieuThue)
            {
                List<eChiTietPhieuThue> lsctpt = new List<eChiTietPhieuThue>();
                var dsCTPhieuThue = (from x in db.tblChiTietPhieuThues
                                     where pt.maPhieuThue == x.maPhieuThue.Trim()
                                     select x).ToList();
                int i = dsCTPhieuThue.Count();
                foreach (tblChiTietPhieuThue ctpt in dsCTPhieuThue)
                {
                    DateTime newday = new DateTime();
                    newday = Convert.ToDateTime(pt.ngayLap).AddDays(Convert.ToInt32(ctpt.soNgayThue));
                    int result = newday.CompareTo(DateTime.Now);
                    if (result == -1 && ctpt.soLuongDaTra != ctpt.soLuongThue)
                    {
                        ePhieuThue p = new ePhieuThue();
                        p.MaThe = pt.maThe;
                        p.MaNhanVien = pt.maNhanVien;
                        p.MaPhieuThue = pt.maPhieuThue;
                        p.NgayLap = pt.ngayLap.ToString();
                        p.ThanhTien = Convert.ToInt32(pt.thanhTien);
                        ls.Add(p);
                    }
                }


            }
            return ls;
        }
        //Lấy phiếu thuê đang thuê theo mã thẻ khách hàng
        public List<ePhieuThue> LayPhieuThueDangThue(string maThe)
        {
            List<ePhieuThue> ls = new List<ePhieuThue>();
            var dsPhieuThue = (from x in db.tblPhieuThues
                               where maThe == x.maThe.Trim()
                               select x).ToList();
            foreach (tblPhieuThue pt in dsPhieuThue)
            {
                List<eChiTietPhieuThue> lsctpt = new List<eChiTietPhieuThue>();
                var dsCTPhieuThue = (from x in db.tblChiTietPhieuThues
                                     where pt.maPhieuThue == x.maPhieuThue.Trim()
                                     select x).ToList();
                int i = dsCTPhieuThue.Count();
                foreach (tblChiTietPhieuThue ctpt in dsCTPhieuThue)
                {
                    DateTime newday = new DateTime();
                    newday = Convert.ToDateTime(pt.ngayLap).AddDays(Convert.ToInt32(ctpt.soNgayThue));
                    int result = newday.CompareTo(DateTime.Now);
                    if (ctpt.soLuongDaTra != ctpt.soLuongThue)
                    {
                        ePhieuThue p = new ePhieuThue();
                        p.MaThe = pt.maThe;
                        p.MaNhanVien = pt.maNhanVien;
                        p.MaPhieuThue = pt.maPhieuThue;
                        p.NgayLap = pt.ngayLap.ToString();
                        p.ThanhTien = Convert.ToInt32(pt.thanhTien);
                        ls.Add(p);
                    }
                }


            }
            return ls;
        }

        ////Chuyển phiếu thuê sang nhân viên khác
        //public void ChuyenPhieuThueSangNhanVienKhac(string maNVCu, string maNVMoi)
        //{

        //    List<ePhieuThue> ls = new List<ePhieuThue>();
        //    ls = LayHetPhieuThueTheoMaNV(maNVCu);
        //    // cập nhật dữ liệu
        //    foreach (ePhieuThue pttemp in ls)
        //    {
        //        IQueryable<tblPhieuThue> pt = from x in db.tblPhieuThues
        //                                      where x.maPhieuThue.Equals(pttemp.MaPhieuThue)
        //                                      select x;
        //        pt.First().maNhanVien = maNVMoi;
        //        pt.First().maPhieuThue = pttemp.MaPhieuThue;
        //        pt.First().maThe = pttemp.MaThe;
        //        pt.First().ngayLap = Convert.ToDateTime(pttemp.NgayLap);
        //        pt.First().thanhTien = pttemp.ThanhTien;
        //        db.SubmitChanges();
        //    }
        //    db.SubmitChanges();
        //}

        //Lấy phiếu thuê theo mã nhân viên
        public List<ePhieuThue> LayHetPhieuThueTheoMaNV(string maNV)
        {
            List<ePhieuThue> ls = new List<ePhieuThue>();
            var dsPhieuThue = (from x in db.tblPhieuThues
                               where maNV == x.maNhanVien.Trim()
                               select x).ToList();
            foreach (tblPhieuThue pt in dsPhieuThue)
            {
                ePhieuThue p = new ePhieuThue();
                p.MaThe = pt.maThe;
                p.MaNhanVien = pt.maNhanVien;
                p.MaPhieuThue = pt.maPhieuThue;
                p.NgayLap = pt.ngayLap.ToString();
                p.ThanhTien = Convert.ToInt32(pt.thanhTien);
                ls.Add(p);
            }
            return ls;
        }

        //Chuyển phiếu thuê sang thẻ khác
        public void ChuyenPhieuThueSangTheKhac(string maTheCu, string maTheMoi)
        {
            IQueryable<tblPhieuThue> pt = from x in db.tblPhieuThues
                                          where x.maThe.Equals(maTheCu)
                                          select x;
            // cập nhật dữ liệu
            foreach (tblPhieuThue pttemp in pt)
            {
                pttemp.maThe = maTheMoi;
                db.SubmitChanges();
            }
        }

        //Chuyển phiếu thuê sang nhân viên khác
        public void ChuyenPhieuThueSangNhanVienKhac(string maNVCu, string maNVMoi)        {

            List<ePhieuThue> ls = new List<ePhieuThue>();            ls = LayHetPhieuThueTheoMaNV(maNVCu);
            // cập nhật dữ liệu
            foreach (ePhieuThue pttemp in ls)            {                IQueryable<tblPhieuThue> pt = from x in db.tblPhieuThues                                              where x.maPhieuThue.Equals(pttemp.MaPhieuThue)                                              select x;                pt.First().maNhanVien = maNVMoi;                pt.First().maPhieuThue = pttemp.MaPhieuThue;                pt.First().maThe = pttemp.MaThe;                pt.First().ngayLap = Convert.ToDateTime(pttemp.NgayLap);                pt.First().thanhTien = pttemp.ThanhTien;                db.SubmitChanges();            }            db.SubmitChanges();        }


    }
}
