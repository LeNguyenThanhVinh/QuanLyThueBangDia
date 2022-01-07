using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DALs;

namespace BLL
{
    public static class TheKhachHangServices
    {
        static ITheKhachHang theKHBLL;

        static TheKhachHangServices()
        {
            theKHBLL = new TheKhachHang();
        }

        public static List<tblTheThanhVien> getAll()
        {
            return theKHBLL.getAll();
        }

        public static List<tblTheThanhVien> getByMathe(string id)
        {
            return theKHBLL.getByMathe(id);
        }

        public static List<tblTheThanhVien> getByMaKH(string id)
        {
            return theKHBLL.getByMaKH(id);
        }

        public static tblTheThanhVien insert(tblTheThanhVien obj)
        {
            return theKHBLL.insert(obj);
        }

        //public static void update(string id, DateTime ngaycap)
        //{
        //    theKHBLL.update(id, ngaycap);
        //}

        public static void update(tblTheThanhVien obj)
        {
            theKHBLL.update(obj);
        }

        public static void delete(tblTheThanhVien obj)
        {
            theKHBLL.delete(obj);
        }

        public static string getIDCardAuto()
        {
            return theKHBLL.getIDCardAuto();
        }
    }
}
