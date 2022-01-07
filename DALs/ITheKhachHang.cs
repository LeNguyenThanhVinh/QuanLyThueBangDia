using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALs
{
    public interface ITheKhachHang
    {
        List<tblTheThanhVien> getAll();
        List<tblTheThanhVien> getByMathe(string id);
        List<tblTheThanhVien> getByMaKH(string id);
        tblTheThanhVien insert(tblTheThanhVien obj);
        void update(tblTheThanhVien obj);

        //void update(string id, DateTime ngayCap);

        void delete(tblTheThanhVien obj);

        string getIDCardAuto(); 
    }
}
