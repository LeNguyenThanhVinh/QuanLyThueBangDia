using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteriesQLBangDia
{
    public class eNhanVien
    {
        private string maNhanVien, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai, taiKhoan, matKhau, soCMND, avatar;
        private bool trangThai;

        //public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        //public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        //public string DiaChi { get => diaChi; set => diaChi = value; }
        //public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        //public string TaiKhoan { get => taiKhoan; set => taiKhoan= value; }
        //public string MatKhau { get => matKhau; set => matKhau = value; }

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

       

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
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

        public string TaiKhoan
        {
            get
            {
                return taiKhoan;
            }

            set
            {
                taiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public string Avatar
        {
            get
            {
                return avatar;
            }

            set
            {
                avatar = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }
    }
}
