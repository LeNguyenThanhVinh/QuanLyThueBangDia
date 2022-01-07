using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteriesQLBangDia
{
    public class ePhieuThue
    {
        private string maPhieuThue, maThe, ngayLap, maNhanVien;
        private long thanhTien;
        //public string MaPhieuThue { get => maPhieuThue; set => maPhieuThue = value; }
        //public string MaThe { get => maThe; set => maThe = value; }
        //public string NgayLap { get => ngayLap; set => ngayLap = value; }
        //public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        //public long ThanhTien { get => thanhTien; set => thanhTien = value; }

       

        public string MaPhieuThue
        {
            get
            {
                return maPhieuThue;
            }

            set
            {
                maPhieuThue = value;
            }
        }

        public string MaThe
        {
            get
            {
                return maThe;
            }

            set
            {
                maThe = value;
            }
        }

        public string NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public long ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }
    }
}
