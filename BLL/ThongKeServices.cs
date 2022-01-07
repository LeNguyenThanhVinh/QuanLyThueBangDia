using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DALs;

namespace BLL
{
    public static class ThongKeServices
    {
        static IThongKe thongKeBLL;
        static ThongKeServices()
        {
            thongKeBLL = new ThongKe();
        }

        public static List<tblBangDia> getAllBangDia()
        {
            return thongKeBLL.getAllBangDia();
        }

        public static List<getReportTongDoanhThu_Result> getListThongKeDoanhSo(DateTime fromDate, DateTime toDate)
        {
            return thongKeBLL.getListThongKeDoanhSo(fromDate, toDate);
        }

        public static List<getBlackList_Result> getDSQuaHan()
        {
            return thongKeBLL.getDSQuaHan();
        }

        public static List<getTop5BangDiaYeuThich_Result> getTop5YeuThich(DateTime fromDate, DateTime toDate, int top)
        {
            return thongKeBLL.getTop5YeuThich(fromDate, toDate, top);
        }
    }
}
