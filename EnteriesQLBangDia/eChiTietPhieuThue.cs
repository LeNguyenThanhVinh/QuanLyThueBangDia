using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteriesQLBangDia
{
    public class eChiTietPhieuThue
    {
        private string maPhieuThue, maBangDia;
        private int soLuongThue, soNgayThue, soLuongDaTra;

        //public string MaPhieuThue { get => maPhieuThue; set => maPhieuThue = value; }
        //public string MaBangDia { get => maBangDia; set => maBangDia = value; }
        //public int SoLuongThue { get => soLuongThue; set => soLuongThue = value; }
        //public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        //public int SoLuongDaTra { get => soLuongDaTra; set => soLuongDaTra = value; }

        

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
        public string MaBangDia
        {
            get
            {
                return maBangDia;
            }

            set
            {
                maBangDia = value;
            }
        }

        public int SoLuongThue
        {
            get
            {
                return soLuongThue;
            }

            set
            {
                soLuongThue = value;
            }
        }

        public int SoNgayThue
        {
            get
            {
                return soNgayThue;
            }

            set
            {
                soNgayThue = value;
            }
        }
        public int SoLuongDaTra
        {
            get
            {
                return soLuongDaTra;
            }

            set
            {
                soLuongDaTra = value;
            }
        }

       

        

    }
}
