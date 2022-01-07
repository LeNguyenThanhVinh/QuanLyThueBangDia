using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteriesQLBangDia
{
    public class eTheThanhVien
    {
        private string maThe, maKhachHang, ngayHetHan, ngayCap;

        //public string MaThe { get => maThe; set => maThe = value; }
        //public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        //public string NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        //public string NgayCap { get => ngayCap; set => ngayCap = value; }

      

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
        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        

        public string NgayHetHan
        {
            get
            {
                return ngayHetHan;
            }

            set
            {
                ngayHetHan = value;
            }
        }

        public string NgayCap
        {
            get
            {
                return ngayCap;
            }

            set
            {
                ngayCap = value;
            }
        }
    }
}
