using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteriesQLBangDia
{
    public class eBangDia
    {
        private string maBangDia, tenBangDia, theLoai, nhaSanXuat, tinhTrang;
        private long soLuongTon, donGia;

        public string MaBangDia
        {
            get { return maBangDia; }
            set { maBangDia = value; }
        }
        public string TenBangDia
        {
            get { return tenBangDia; }
            set { tenBangDia = value; }
        }
        public string TheLoai
        {
            get { return theLoai; }
            set { theLoai = value; }
        }
        public long SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
        public long DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public string NhaSanXuat
        {
            get { return nhaSanXuat; }
            set { nhaSanXuat = value; }
        }
    }
}
