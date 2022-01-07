using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DALs
{
    public interface IThongKe
    {
        List<tblBangDia> getAllBangDia();

        List<getReportTongDoanhThu_Result> getListThongKeDoanhSo(DateTime fromDate, DateTime toDate);
        List<getBlackList_Result> getDSQuaHan();

        List<getTop5BangDiaYeuThich_Result> getTop5YeuThich(DateTime fromDate, DateTime toDate, int top);
    }
}
