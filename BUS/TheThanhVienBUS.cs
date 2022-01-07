using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EnteriesQLBangDia;

namespace BUS
{
    public class TheThanhVienBUS
    {
        TheThanhVienDAL ttvDAL;
        public TheThanhVienBUS()
        {
            ttvDAL = new TheThanhVienDAL();
        }
        public bool CheckIfExist(string maThe)
        {
            return ttvDAL.CheckIfExist(maThe);
        }
        public string LayMaKhachHang(string maThe)
        {
            return ttvDAL.LayMaKhachHang(maThe);
        }
        //Lấy thẻ từ mã khách hàng
        public List<eTheThanhVien> LayTheThanhVienTheoMaKH(string maKH)
        {
            return ttvDAL.LayTheThanhVienTheoMaKH(maKH);
        }

        //Tạo thẻ mới
        public int TaoThe(eTheThanhVien newTheTV)
        {
            return ttvDAL.TaoThe(newTheTV);
        }

        //Xóa thẻ
        public bool XoaThe(string maThe)
        {
            return ttvDAL.XoaThe(maThe);
        }

        //Lấy hết thẻ
        public List<eTheThanhVien> getAllThe()
        {
            return ttvDAL.getAllThe();
        }

    }
}
