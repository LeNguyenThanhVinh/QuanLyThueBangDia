using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnteriesQLBangDia;
namespace DAL
{
    public class TheThanhVienDAL
    {
        DataQuanLyBangDiaDataContext db;
        public TheThanhVienDAL()
        {
            db = new DataQuanLyBangDiaDataContext();
        }
        //Kiểm tra có tồn tại mã thẻ
        public bool CheckIfExist(string maThe)
        {
            tblTheThanhVien ttvtemp = db.tblTheThanhViens.Where(x => x.maThe == maThe).FirstOrDefault();
            if (ttvtemp != null)
                return true;
            return false;
        }

        //Lấy mã khách hàng từ mã thẻ
        public string LayMaKhachHang(string maThe)
        {
            string maKH = "";
            eTheThanhVien theTV = new eTheThanhVien();
            var ds = (from x in db.tblTheThanhViens
                             where maThe == x.maThe.Trim()
                             select x).ToList();
            foreach (tblTheThanhVien ttvtmp in ds)
            {
                maKH = ttvtmp.maKH.ToString();
            }
            return maKH;
        }
        //Lấy thẻ từ mã khách hàng
        public List<eTheThanhVien> LayTheThanhVienTheoMaKH(string maKH)
        {
            List<eTheThanhVien> ls = new List<eTheThanhVien>();
            var dsTheTV = (from x in db.tblTheThanhViens
                           where maKH == x.maKH.Trim()
                           select x).ToList();
            foreach (tblTheThanhVien ttv in dsTheTV)
            {
                eTheThanhVien t = new eTheThanhVien();
                t.MaKhachHang = ttv.maKH;
                t.MaThe = ttv.maThe;
                t.NgayCap = (ttv.ngayCap.ToString());
                t.NgayHetHan = ttv.ngayHetHan.ToString();
                ls.Add(t);
            }
            return ls;
        }

        //Tạo thẻ mới
        public int TaoThe(eTheThanhVien newTheTV)
        {
            if (CheckIfExistThe(newTheTV.MaThe))
                return 0;

            tblTheThanhVien ttvtemp = new tblTheThanhVien();
            ttvtemp.maKH = newTheTV.MaKhachHang;
            ttvtemp.maThe = newTheTV.MaThe;
            ttvtemp.ngayCap = Convert.ToDateTime(newTheTV.NgayCap);
            ttvtemp.ngayHetHan = Convert.ToDateTime(newTheTV.NgayHetHan);
            db.tblTheThanhViens.InsertOnSubmit(ttvtemp);
            db.SubmitChanges();
            return 1;
        }

        //Kiểm tra có tồn tại thẻ khách hàng không
        public bool CheckIfExistThe(string maThe)
        {
            tblTheThanhVien ttvtemp = db.tblTheThanhViens.Where(x => x.maThe == maThe).FirstOrDefault();
            if (ttvtemp != null)
                return true;
            return false;
        }

        //Xóa thẻ
        public bool XoaThe(string maThe)
        {
            tblTheThanhVien ttvtemp = db.tblTheThanhViens.Where(x => x.maThe == maThe).FirstOrDefault();
            if (ttvtemp != null)
            {
                db.tblTheThanhViens.DeleteOnSubmit(ttvtemp);
                db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }
            return false;
        }


        //Lấy hết thẻ
        public List<eTheThanhVien> getAllThe()
        {
            IEnumerable<tblTheThanhVien> ttvlist = db.tblTheThanhViens;
            List<eTheThanhVien> ls = new List<eTheThanhVien>();
            foreach (tblTheThanhVien ttv in ttvlist)
            {
                eTheThanhVien t = new eTheThanhVien();
                t.MaKhachHang = ttv.maKH;
                t.MaThe = ttv.maThe;
                t.NgayCap = ttv.ngayCap.ToString();
                t.NgayHetHan = ttv.ngayHetHan.ToString();
                ls.Add(t);
            }
            return ls;
        }

    }   
}
