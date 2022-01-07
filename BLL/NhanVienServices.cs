using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using Model;

namespace BLL
{
    public static class NhanVienServices
    {
        static INhanVien nhanVienBLL;
        
        static NhanVienServices()
        {
            nhanVienBLL = new NhanVien();
        }

        public static List<tblNhanVien> getAll()
        {
            return nhanVienBLL.getAll();
        }

        public static List<tblNhanVien> getByID(string id)
        {
            return nhanVienBLL.getByID(id);
        }

        public static List<tblNhanVien> getByName(string name)
        {
            return nhanVienBLL.getByName(name);
        }

        public static tblNhanVien insert(tblNhanVien obj)
        {
            return nhanVienBLL.insert(obj);
        }

        public static void update(tblNhanVien obj)
        {
            nhanVienBLL.update(obj);
        }

        public static void delete(tblNhanVien obj)
        {
            nhanVienBLL.delete(obj);
        }

        public static string getIDNVAuto()
        {
            return nhanVienBLL.getIDNVAuto();
        }

        public static bool isActiveStaff(string tk, string mk)
        {
            return nhanVienBLL.isActiveStaff(tk, mk);
        }

        public static bool isExistNV(string cmnd)
        {
            return nhanVienBLL.isExistNV(cmnd);
        }
    }
}
