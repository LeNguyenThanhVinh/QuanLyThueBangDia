using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALs
{
    public class NhanVien : INhanVien
    {
        public void delete(tblNhanVien obj)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                db.tblNhanViens.Attach(obj);
                db.tblNhanViens.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<tblNhanVien> getAll()
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                return db.tblNhanViens.ToList();
            }
        }

        public List<tblNhanVien> getByID(string id)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                var q = db.tblNhanViens.Where(n => n.maNhanVien.Contains(id));
                return q.ToList();
            }
        }

        public List<tblNhanVien> getByName(string name)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                var q = db.tblNhanViens.Where(n => n.tenNhanVien.Contains(name));
                return q.ToList();
            }
        }

        public tblNhanVien insert(tblNhanVien obj)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                db.tblNhanViens.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void update(tblNhanVien obj)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                db.tblNhanViens.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public string getIDNVAuto()
        {
            List<tblNhanVien> listNV = new List<tblNhanVien>();
            listNV = this.getAll();
            int result = 0;
            foreach (var item in listNV)
            {
                if (Convert.ToInt32(item.maNhanVien.Substring(2).Trim()) > result)
                    result = Convert.ToInt32(item.maNhanVien.Substring(2).Trim());
            }
            string tmp = "";
            if (result.ToString().Length == 1)
            {
                tmp = "00";
            }
            if (result.ToString().Length == 2)
                tmp = "0";
            return "NV"+tmp + (result + 1).ToString();
        }

        public bool isActiveStaff(string tk, string mk)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                tblNhanVien staff = db.tblNhanViens.Where(x => x.taiKhoan == tk).FirstOrDefault();
                if (staff.trangThai == true)
                    return true;
                else
                    return false;
            }
        }

        public bool isExistNV(string cmnd)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                tblNhanVien staff = db.tblNhanViens.Where(x => x.soCMND == cmnd).FirstOrDefault();
                return staff != null ? true : false;
            }
        }
    }
}
