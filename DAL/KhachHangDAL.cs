using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnteriesQLBangDia;
namespace DAL
{
    public class KhachHangDAL
    {
        DataQuanLyBangDiaDataContext db;
        public KhachHangDAL()
        {
            db = new DataQuanLyBangDiaDataContext();
        }
        //Lấy tên khách hàng từ mã khách hàng
        public string LayTenKhachHang(string maKH)
        {
            string tenKH = "";
            eKhachHang kh = new eKhachHang();
            var ds = (from x in db.tblKhachHangs
                      where maKH == x.maKH.Trim()
                      select x).ToList();
            foreach (tblKhachHang khtmp in ds)
            {
                tenKH = khtmp.tenKH.ToString();
            }
            return tenKH;
        }
        //Lấy mã khách hàng có mã lớn nhất
        public string LayMaKHCoMaLonNhat()
        {
            string mapt = "";
            List<eKhachHang> ls = new List<eKhachHang>();
            ls = getAllKhachHang();
            int a = 0;
            foreach (eKhachHang khtemp in ls)
            {
                if (a <= Convert.ToInt32(khtemp.MaKhachHang.ToString().Substring(2).Trim()))
                {
                    a = Convert.ToInt32(khtemp.MaKhachHang.ToString().Substring(2).Trim());
                }
            }
            mapt = a.ToString();
            return mapt;
        }
        //Lấy hết danh sách khách hàng
        public List<eKhachHang> getAllKhachHang()
        {
            IEnumerable<tblKhachHang> khlist = db.tblKhachHangs;
            List<eKhachHang> ls = new List<eKhachHang>();
            foreach (tblKhachHang kh in khlist)
            {
                eKhachHang k = new eKhachHang();
                if (kh.maKH != null)
                {
                    k.MaKhachHang = kh.maKH;
                    k.HoTen = kh.tenKH;
                    k.DiaChi = kh.diaChi;
                    k.GioiTinh = kh.gioiTinh;
                    k.SoCMND = kh.soCMND;
                    k.SoDienThoai = kh.soDienThoai;
                    ls.Add(k);
                }
            }
            return ls;
        }
        //Kiểm tra có tồn tại khách hàng không
        public bool CheckIfExistKH(string soCMND)
        {
            tblKhachHang khtemp = db.tblKhachHangs.Where(x =>  x.soCMND == soCMND).FirstOrDefault();
            if (khtemp != null)
                return true;
            return false;
        }
        //Thêm khách hàng
        public int ThemKhachHang(eKhachHang newKhachHang)
        {
            if (CheckIfExistKH(newKhachHang.SoCMND))
                return 0;

            tblKhachHang khtemp = new tblKhachHang();
            khtemp.maKH = newKhachHang.MaKhachHang;
            khtemp.tenKH = newKhachHang.HoTen;
            khtemp.diaChi = newKhachHang.DiaChi;
            khtemp.soCMND = newKhachHang.SoCMND;
            khtemp.soDienThoai = newKhachHang.SoDienThoai;
            khtemp.gioiTinh = newKhachHang.GioiTinh;

            db.tblKhachHangs.InsertOnSubmit(khtemp);
            db.SubmitChanges();
            return 1;
        }
        //xóa khách hàng
        public bool XoaKhachHang(string maKhachHang)
        {
            tblKhachHang khtemp = db.tblKhachHangs.Where(x => x.maKH == maKhachHang).FirstOrDefault();
            if (khtemp != null)
            {
                db.tblKhachHangs.DeleteOnSubmit(khtemp);
                db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }
            return false;
        }
        //sửa khách hàng
        public void SuaKhachHang(eKhachHang khSua)
        {
            IQueryable<tblKhachHang> kh = from x in db.tblKhachHangs
                                        where x.maKH.Equals(khSua.MaKhachHang)
                                        select x;
            // cập nhật dữ liệu
            kh.First().maKH= khSua.MaKhachHang;
            kh.First().tenKH = khSua.HoTen;
            kh.First().soCMND = khSua.SoCMND;
            kh.First().soDienThoai = khSua.SoDienThoai;
            kh.First().diaChi= khSua.DiaChi;
            kh.First().gioiTinh= khSua.GioiTinh;
            db.SubmitChanges();
        }





        public List<eKhachHang> TimKiemKhachHangTheoMa(string maKH)
        {
            IEnumerable<tblKhachHang> q = from kh in db.tblKhachHangs
                                          where kh.maKH.Contains(maKH)
                                          orderby kh.maKH
                                          select kh;
            List<eKhachHang> ls = new List<eKhachHang>();
            foreach (tblKhachHang kh in q)
            {
                eKhachHang b = new eKhachHang();
                b.MaKhachHang = kh.maKH;
                b.HoTen = kh.tenKH;
                b.GioiTinh = kh.gioiTinh;
                b.SoCMND = kh.soCMND;
                b.SoDienThoai = kh.soDienThoai;
                b.DiaChi = kh.diaChi;
                ls.Add(b);
            }
            return ls;
        }

        public List<eKhachHang> TimKiemKhachHangTheoTen(string tenKH)
        {
            IEnumerable<tblKhachHang> q = from kh in db.tblKhachHangs
                                          where kh.tenKH.Contains(tenKH)
                                          orderby kh.maKH
                                          select kh;
            List<eKhachHang> ls = new List<eKhachHang>();
            foreach (tblKhachHang kh in q)
            {
                eKhachHang b = new eKhachHang();
                b.MaKhachHang = kh.maKH;
                b.HoTen = kh.tenKH;
                b.GioiTinh = kh.gioiTinh;
                b.SoCMND = kh.soCMND;
                b.SoDienThoai = kh.soDienThoai;
                b.DiaChi = kh.diaChi;
                ls.Add(b);
            }
            return ls;
        }

        public List<eKhachHang> TimKiemKhachHangTheoMaVaTen(string maKH, string tenKH)
        {
            IEnumerable<tblKhachHang> q = from kh in db.tblKhachHangs
                                        where kh.maKH.Contains(maKH)
                                            && kh.tenKH.Contains(tenKH)
                                        orderby kh.maKH
                                        select kh;
            List<eKhachHang> ls = new List<eKhachHang>();
            foreach (tblKhachHang kh in q)
            {
                eKhachHang b = new eKhachHang();
                b.MaKhachHang = kh.maKH;
                b.HoTen = kh.tenKH;
                b.GioiTinh = kh.gioiTinh;
                b.SoCMND = kh.soCMND;
                b.SoDienThoai = kh.soDienThoai;
                b.DiaChi = kh.diaChi;
                ls.Add(b);
            }
            return ls;
        }
    }
}
