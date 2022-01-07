using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALs
{
    public class ThongKe : IThongKe
    {
        public List<tblBangDia> getAllBangDia()
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                return db.tblBangDias.ToList();
            }
        }
        public List<getReportTongDoanhThu_Result> getListThongKeDoanhSo(DateTime fromDate, DateTime toDate)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                return db.getReportTongDoanhThu(fromDate, toDate).ToList();
            }
        }

        public List<getBlackList_Result> getDSQuaHan()
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                return db.getBlackList().ToList();
            }
        }

        public List<getTop5BangDiaYeuThich_Result> getTop5YeuThich(DateTime fromDate, DateTime toDate, int top)
        {
            using (QuanLyBangDia2Entities db = new QuanLyBangDia2Entities())
            {
                return db.getTop5BangDiaYeuThich(fromDate, toDate, top).ToList();
            }
        }
    }
}
