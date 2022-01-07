using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
using System.Drawing.Printing;

namespace QuanLyThueBangDia
{
    public partial class frmTKDoanhThu : Form
    {
        public frmTKDoanhThu()
        {
            InitializeComponent();
            //System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            //pg.Margins.Top = 0;
            //pg.Margins.Bottom = 3;
            ////pg.Margins.Left = 3;
            ////pg.Margins.Right = 3;
            //System.Drawing.Printing.PaperSize size = new PaperSize();
            //size.RawKind = (int)PaperKind.A4;
            //pg.PaperSize = size;
            //pg.Landscape = true;
            //reportViewer1.SetPageSettings(pg);
        }

        private void frmTKDoanhThu_Load(object sender, EventArgs e)
        {           
            //this.reportViewer1.RefreshReport();
           this.reportViewer1.ResetPageSettings();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dtToDate.Value.Date.CompareTo(dtFromDate.Value.Date) < 0)
            {
                MessageBox.Show("Ngày kết thúc không được trước ngày bắt đầu, vui lòng chọn lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }                         

            if (ThongKeServices.getListThongKeDoanhSo(dtFromDate.Value.Date, dtToDate.Value.Date).Count == 0)
            {
                MessageBox.Show("Không có băng đĩa được bán từ " + dtFromDate.Value.ToShortDateString() + " đến " + dtToDate.Value.ToShortDateString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            getReportTongDoanhThu_ResultBindingSource.DataSource = ThongKeServices.getListThongKeDoanhSo(dtFromDate.Value.Date, dtToDate.Value.Date);
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("fromDate", dtFromDate.Value.ToShortDateString()),
                new  Microsoft.Reporting.WinForms.ReportParameter("toDate", dtToDate.Value.ToShortDateString())
            };
            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.RefreshReport();
        }
    }
}
