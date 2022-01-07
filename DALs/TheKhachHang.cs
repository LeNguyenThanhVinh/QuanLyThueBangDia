using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALs
{
    public class TheKhachHang : ITheKhachHang
    {
        //QuanLyBangDia2Entities db = new QuanLyBangDia2Entities();
        public void delete(tblTheThanhVien obj)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                db.tblTheThanhViens.Attach(obj);
                db.tblTheThanhViens.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<tblTheThanhVien> getAll()
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                return db.tblTheThanhViens.ToList();
            }
        }

        public List<tblTheThanhVien> getByMathe(string id)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                var q = db.tblTheThanhViens.Where(n => n.maThe.Contains(id));
                return q.ToList();
            }
        }

        public List<tblTheThanhVien> getByMaKH(string id)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                var q = db.tblTheThanhViens.Where(n => n.maKH.Contains(id));
                return q.ToList();
            }
        }

        public tblTheThanhVien insert(tblTheThanhVien obj)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            { 
                    db.tblTheThanhViens.Add(obj);
                    db.SaveChanges();
                    return obj;
            }
        }

        public void update(tblTheThanhVien obj)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                db.tblTheThanhViens.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            //{
            //    tblTheThanhVien membercard = new tblTheThanhVien();
            //    membercard.ngayCap = ngaycap;
            //    membercard.ngayHetHan = ngaycap.AddYears(3);
            //    db.SaveChanges();
            //}       
        }

        public string getIDCardAuto()
        {
            //List<tblTheThanhVien> listCard = new List<tblTheThanhVien>();
            //listCard = this.getAll();
            //int result = 0;
            //foreach (var item in listCard)
            //{
            //    if (Convert.ToInt32(item.maThe.Substring(2).Trim()) > result)
            //        result = Convert.ToInt32(item.maThe.Substring(2).Trim());
            //}
            //string tmp = "";
            //if (result.ToString().Length == 1)
            //{
            //    tmp = "000";
            //}
            //else if (result.ToString().Length == 2)
            //    tmp = "00";
            //else if (result.ToString().Length == 3)
            //    tmp = "0";
            //return "KH"+tmp+(result + 1).ToString();
            List<tblTheThanhVien> listCard = new List<tblTheThanhVien>();
            listCard = this.getAll();
            int result = 0;
            foreach (var item in listCard)
            {
                if (Convert.ToInt32(item.maThe.Trim()) > result)
                    result = Convert.ToInt32(item.maThe.Trim());
            }

            return (result + 1).ToString();

        }
    }
}
