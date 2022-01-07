using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyThueBangDia
{
    public partial class frmPrintPhieuThue : Form
    {
        string maTheKH, tenKH, maPT, tenNV, tongTien;
        DataGridView grid;

        public frmPrintPhieuThue(string maTheKH, string tenKH, string maPT, string tenNV, string tongTien, DataGridView grid)
        {
            InitializeComponent();
            this.maTheKH = maTheKH;
            this.tenKH = tenKH;
            this.maPT = maPT;
            this.tenNV = tenNV;
            this.tongTien = tongTien;
            this.grid = grid;
            

        }
        private void frmPrintPhieuThue_Load(object sender, EventArgs e)
        {
            ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("maPhieuThue", this.maPT),
                new ReportParameter("maTheKhachHang", this.maTheKH),          
                new ReportParameter("tenKhachHang", this.tenKH),
                new ReportParameter("tenNhanVien", this.tenNV),
                new ReportParameter("tongTien", this.tongTien),
            };
            reportViewer1.LocalReport.SetParameters(rParams);

            DataTable dt = new DataTable();
            dt.Columns.Add("maBangDia");
            dt.Columns.Add("tenBangDia");
            dt.Columns.Add("soLuong");
            dt.Columns.Add("donGia");            
            dt.Columns.Add("soNgayThue");


            foreach (DataGridViewRow row in grid.Rows)
                dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);

            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear(); 
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
           
        }
    }
}
