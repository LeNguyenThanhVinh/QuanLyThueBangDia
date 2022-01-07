using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALs
{
    public interface INhanVien
    {
        List<tblNhanVien> getAll();
        List<tblNhanVien> getByID(string id);
        List<tblNhanVien> getByName(string name);
        tblNhanVien insert(tblNhanVien obj);
        void update(tblNhanVien obj);
        void delete(tblNhanVien obj);
        bool isExistNV(string cmnd);
        bool isActiveStaff(string tk, string mk);
        string getIDNVAuto();
    }
}
