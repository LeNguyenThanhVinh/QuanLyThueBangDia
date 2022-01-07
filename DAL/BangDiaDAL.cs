using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EnteriesQLBangDia;
namespace DAL
{
    public class BangDiaDAL
    {
        DataQuanLyBangDiaDataContext db;
        public BangDiaDAL()
        {
            db = new DataQuanLyBangDiaDataContext();

        }
        public List<eBangDia> getAllBangDia()
        {
            IEnumerable<tblBangDia> bangdialist = db.tblBangDias;
            List<eBangDia> ls = new List<eBangDia>();
            foreach (tblBangDia bd in bangdialist)
            {
                eBangDia b = new eBangDia();
                b.MaBangDia = bd.maBangDia;
                b.TenBangDia = bd.tenBangDia;
                b.DonGia = Convert.ToInt32(bd.donGia);
                b.NhaSanXuat = bd.nhaSanXuat;
                b.SoLuongTon = Convert.ToInt32(bd.soLuongTon);
                b.TheLoai = bd.theLoai;
                b.TinhTrang = bd.tinhTrang;
                ls.Add(b);
            }
            return ls;
        }
        //Lấy số lượng băng đĩa theo mã 
        public int getSoLuongBangDia(string maBangDia)
        {
            eBangDia bangDia = new eBangDia();
            var dsbangDia = (from x in db.tblBangDias
                             where maBangDia == x.maBangDia.Trim()
                             select x).ToList();
            int soLuong = 0;
            foreach (tblBangDia bdtemp in dsbangDia)
            {
                soLuong = Convert.ToInt32(bdtemp.soLuongTon);
            }
            return soLuong;
        }
        //Lấy băng đĩa theo mã có sửa số lượng để truyền vào datagridview
        public eBangDia getBangDiaTheoMa(string maBangDia, int soLuong)
        {
            eBangDia bangDia = new eBangDia();
            var dsbangDia = (from x in db.tblBangDias
                          where maBangDia == x.maBangDia.Trim()
                          select x).ToList();
            foreach(tblBangDia bdtemp in dsbangDia)
            {
                bangDia.MaBangDia = bdtemp.maBangDia;
                bangDia.DonGia =Convert.ToInt32(bdtemp.donGia);
                bangDia.NhaSanXuat = bdtemp.nhaSanXuat;
                bangDia.SoLuongTon =soLuong;
                bangDia.TenBangDia = bdtemp.tenBangDia;
                bangDia.TheLoai = bdtemp.theLoai;
                bangDia.TinhTrang = bdtemp.tinhTrang;
            }    
            return bangDia;
        }
        //Lấy băng đĩa theo mã không sửa số lượng
        public eBangDia GetBangDiaTheoMaChuan(string maBangDia)
        {
            eBangDia bangDia = new eBangDia();
            var dsbangDia = (from x in db.tblBangDias
                             where maBangDia == x.maBangDia.Trim()
                             select x).ToList();
            foreach (tblBangDia bdtemp in dsbangDia)
            {
                bangDia.MaBangDia = bdtemp.maBangDia;
                bangDia.DonGia = Convert.ToInt32(bdtemp.donGia);
                bangDia.NhaSanXuat = bdtemp.nhaSanXuat;
                bangDia.SoLuongTon = Convert.ToInt32(bdtemp.soLuongTon);
                bangDia.TenBangDia = bdtemp.tenBangDia;
                bangDia.TheLoai = bdtemp.theLoai;
                bangDia.TinhTrang = bdtemp.tinhTrang;
            }
            return bangDia;
        }
        //trừ số lượng băng đĩa khi tạo phiếu
        public void truSoLuong(eBangDia bdUpdate)
        {
            IQueryable<tblBangDia> bd = from x in db.tblBangDias
                                         where x.maBangDia.Equals(bdUpdate.MaBangDia)
                                         select x;
            // cập nhật dữ liệu
            bd.First().maBangDia = bdUpdate.MaBangDia;
            bd.First().nhaSanXuat = bdUpdate.NhaSanXuat;
            bd.First().soLuongTon =Convert.ToInt32(bdUpdate.SoLuongTon);
            bd.First().donGia = bdUpdate.DonGia;
            bd.First().tenBangDia = bdUpdate.TenBangDia;
            bd.First().theLoai = bdUpdate.TheLoai;
            bd.First().tinhTrang = bdUpdate.TinhTrang;         
            db.SubmitChanges();
        }
        //Tìm kiếm
        public List<eBangDia> TimKiemBangDiaTheoMa(string maBD)
        {
            IEnumerable<tblBangDia> q = from bd in db.tblBangDias
                                        where bd.maBangDia.Contains(maBD)
                                        orderby bd.maBangDia
                                        select bd;
            List<eBangDia> ls = new List<eBangDia>();
            foreach(tblBangDia bd in q)
            {
                eBangDia b = new eBangDia();
                b.MaBangDia = bd.maBangDia;
                b.TenBangDia = bd.tenBangDia;
                b.DonGia = Convert.ToInt32(bd.donGia);
                b.NhaSanXuat = bd.nhaSanXuat;
                b.SoLuongTon = Convert.ToInt32(bd.soLuongTon);
                b.TheLoai = bd.theLoai;
                b.TinhTrang = bd.tinhTrang;
                ls.Add(b);
            }
            return ls;
        }
        
        public List<eBangDia> TimKiemBangDiaTheoTen(string tenBD)
        {
            IEnumerable<tblBangDia> q = from bd in db.tblBangDias
                                        where bd.tenBangDia.Contains(tenBD)
                                        orderby bd.maBangDia
                                        select bd;
            List<eBangDia> ls = new List<eBangDia>();
            foreach (tblBangDia bd in q)
            {
                eBangDia b = new eBangDia();
                b.MaBangDia = bd.maBangDia;
                b.TenBangDia = bd.tenBangDia;
                b.DonGia = Convert.ToInt32(bd.donGia);
                b.NhaSanXuat = bd.nhaSanXuat;
                b.SoLuongTon = Convert.ToInt32(bd.soLuongTon);
                b.TheLoai = bd.theLoai;
                b.TinhTrang = bd.tinhTrang;
                ls.Add(b);
            }
            return ls;
        }

        public List<eBangDia> TimKiemBangDiaTheoMaVaTen(string maBD, string tenBD)
        {
            IEnumerable<tblBangDia> q = from bd in db.tblBangDias
                                        where bd.maBangDia.Contains(maBD)
                                            && bd.tenBangDia.Contains(tenBD)
                                        orderby bd.maBangDia
                                        select bd;
            List<eBangDia> ls = new List<eBangDia>();
            foreach (tblBangDia bd in q)
            {
                eBangDia b = new eBangDia();
                b.MaBangDia = bd.maBangDia;
                b.TenBangDia = bd.tenBangDia;
                b.DonGia = Convert.ToInt32(bd.donGia);
                b.NhaSanXuat = bd.nhaSanXuat;
                b.SoLuongTon = Convert.ToInt32(bd.soLuongTon);
                b.TheLoai = bd.theLoai;
                b.TinhTrang = bd.tinhTrang;
                ls.Add(b);
            }
            return ls;
        }
        //Lấy các thể loại của băng đĩa
        public List<string> LayTheLoaiBangDia()
        {
            var results = (from bd in db.tblBangDias
                          group bd by bd.theLoai into newGroup
                          orderby newGroup.Key
                          select newGroup).ToList();
            string [] listLoai = new string[100];
            int i = 0;
            foreach (var bd in results)
            {
                listLoai[i] = bd.Key;
                i++;
            }
            return listLoai.ToList();

        }
        //Kiểm tra có tồn tại băng đĩa không
        public bool CheckIfExistBD(string tenBangDia, string theLoai)
        {
            tblBangDia bdtemp = db.tblBangDias.Where(x => x.tenBangDia == tenBangDia &&x.theLoai==theLoai).FirstOrDefault();
            if (bdtemp != null)
                return true;
            return false;
        }
        //Thêm băng đĩa
        public int ThemBangDia(eBangDia newBangDia)
        {
            // if (CheckIfExist(mtmoi.MaMay)==true)
            if (CheckIfExistBD(newBangDia.TenBangDia, newBangDia.TheLoai))
                return 0;

            tblBangDia bdtemp = new tblBangDia();
            bdtemp.maBangDia = newBangDia.MaBangDia;
            bdtemp.tenBangDia = newBangDia.TenBangDia;
            bdtemp.theLoai = newBangDia.TheLoai;
            bdtemp.nhaSanXuat = newBangDia.NhaSanXuat;
            bdtemp.soLuongTon = Convert.ToInt32(newBangDia.SoLuongTon);
            bdtemp.tinhTrang = newBangDia.TinhTrang;
            bdtemp.donGia = Convert.ToInt32(newBangDia.DonGia);

            db.tblBangDias.InsertOnSubmit(bdtemp);
            db.SubmitChanges();
            return 1;
        }
        //sửa băng đĩa
        public void SuaBangDia(eBangDia bangDiaSua)
        {
            IQueryable<tblBangDia> bd = from x in db.tblBangDias
                                        where x.maBangDia.Equals(bangDiaSua.MaBangDia)
                                        select x;
            // cập nhật dữ liệu
            bd.First().maBangDia = bangDiaSua.MaBangDia;
            bd.First().nhaSanXuat = bangDiaSua.NhaSanXuat;
            bd.First().soLuongTon = Convert.ToInt32(bangDiaSua.SoLuongTon);
            bd.First().donGia = bangDiaSua.DonGia;
            bd.First().tenBangDia = bangDiaSua.TenBangDia;
            bd.First().theLoai = bangDiaSua.TheLoai;
            bd.First().tinhTrang = bangDiaSua.TinhTrang;
            db.SubmitChanges();
        }
        //xóa băng đĩa
        public bool XoaBangDia(string maBangDia)
        {
            tblBangDia bdtemp = db.tblBangDias.Where(x => x.maBangDia == maBangDia).FirstOrDefault();
            if (bdtemp != null)
            {
                db.tblBangDias.DeleteOnSubmit(bdtemp);
                db.SubmitChanges(); //cập nhật việc xóa vào CSDL
                return true; //xóa thành công
            }
            return false;
        }
        //Lấy mã băng đĩa có mã lớn nhất
        public string LayMaBangDiaCoMaLonNhat()
        {
            string mabd = "";
            List<eBangDia> ls = new List<eBangDia>();
            ls = getAllBangDia();
            int a = 0;
            foreach (eBangDia bdtemp in ls)
            {
                if (a <= Convert.ToInt32(bdtemp.MaBangDia.ToString().Substring(2).Trim()))
                {
                    a = Convert.ToInt32(bdtemp.MaBangDia.ToString().Substring(2).Trim());
                }
            }
            mabd = a.ToString();
            return mabd;
        }



        public List<eBangDia> getBangDiaTrangThai()
        {

            var bangdialist = (from x in db.tblBangDias
                               where x.tinhTrang.Equals("Tốt")
                               select x).ToList();
            List<eBangDia> ls = new List<eBangDia>();
            foreach (tblBangDia bd in bangdialist)
            {
                eBangDia b = new eBangDia();
                b.MaBangDia = bd.maBangDia;
                b.TenBangDia = bd.tenBangDia;
                b.DonGia = Convert.ToInt32(bd.donGia);
                b.NhaSanXuat = bd.nhaSanXuat;
                b.SoLuongTon = Convert.ToInt32(bd.soLuongTon);
                b.TheLoai = bd.theLoai;
                b.TinhTrang = bd.tinhTrang;
                ls.Add(b);
            }
            return ls;
        }


    }
}
