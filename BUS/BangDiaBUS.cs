using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EnteriesQLBangDia;

namespace BUS
{
    public class BangDiaBUS
    {
        BangDiaDAL bdDAL;
        public BangDiaBUS()
        {
            bdDAL = new BangDiaDAL();

        }
        public List<eBangDia> getAllBangDia()
        {
            return bdDAL.getAllBangDia();
        }

        public eBangDia getBangDiaTheoMa(string maBangDia, int soLuong)
        {
            return bdDAL.getBangDiaTheoMa(maBangDia, soLuong);
        }
        public void truSoLuong(eBangDia bdUpdate)
        {
            bdDAL.truSoLuong(bdUpdate);
        }
        public int getSoLuongBangDia(string maBangDia)
        {
            return bdDAL.getSoLuongBangDia(maBangDia);
        }
        public eBangDia getBangDiaTheoMaChuan(string maBangDia)
        {
            return bdDAL.GetBangDiaTheoMaChuan(maBangDia);
        }
        //Tìm kiếm
        public List<eBangDia> TimKiemBangDiaTheoMa(string maBD)
        {
            return bdDAL.TimKiemBangDiaTheoMa(maBD);
        }
        public List<eBangDia> TimKiemBangDiaTheoTen(string tenBD)
        {
            return bdDAL.TimKiemBangDiaTheoTen(tenBD);
        }
        public List<eBangDia> TimKiemBangDiaTheoMaVaTen(string maBD, string tenBD)
        {
            return bdDAL.TimKiemBangDiaTheoMaVaTen(maBD, tenBD);
        }
        //Lấy các thể loại của băng đĩa
        public List<string> LayTheLoaiBangDia()
        {
            return bdDAL.LayTheLoaiBangDia();
        }
        //Thêm băng đĩa
        public int ThemBangDia(eBangDia newBangDia)
        {
            return bdDAL.ThemBangDia(newBangDia);
        }
        //sửa băng đĩa
        public void SuaBangDia(eBangDia bangDiaSua)
        {
            bdDAL.SuaBangDia(bangDiaSua);
        }
        //xóa băng đĩa
        public bool XoaBangDia(string maBangDia)
        {
            return bdDAL.XoaBangDia(maBangDia);
        }
        //Lấy mã băng đĩa có mã lớn nhất
        public string LayMaBangDiaCoMaLonNhat()
        {
            return bdDAL.LayMaBangDiaCoMaLonNhat();
        }
        //Kiểm tra có tồn tại băng đĩa không
        public bool CheckIfExistBD(string tenBangDia, string theLoai)
        {
            return bdDAL.CheckIfExistBD(tenBangDia, theLoai);
        }

        public List<eBangDia> getBangDiaTrangThai()
        {
            return bdDAL.getBangDiaTrangThai();
        }
    }
}
