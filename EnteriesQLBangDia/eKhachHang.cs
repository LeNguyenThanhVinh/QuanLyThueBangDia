using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteriesQLBangDia
{
    public class eKhachHang
    {
        private string maKhachHang, hoTen, soCMND, diaChi, gioiTinh, soDienThoai;

        //public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public string SoCMND { get => soCMND; set => soCMND = value; }
        //public string DiaChi { get => diaChi; set => diaChi = value; }
        //public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        //public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        

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

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }
        public string SoCMND
        {
            get
            {
                return soCMND;
            }

            set
            {
                soCMND = value;
            }
        }

       
        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }
        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

    }
}
