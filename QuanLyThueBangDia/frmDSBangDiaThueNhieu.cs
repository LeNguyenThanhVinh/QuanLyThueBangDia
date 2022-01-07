using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace QuanLyThueBangDia
{
    public partial class frmDSBangDiaThueNhieu : Form
    {
        public frmDSBangDiaThueNhieu()
        {
            InitializeComponent();
        }

        private void frmDSBangDiaThueNhieu_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ResetPageSettings();
            cbxTop.StartIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e) 
        {
            if (dtToDate.Value.Date.CompareTo(dtFromDate.Value.Date) < 0)
            {
                MessageBox.Show("Ngày kết thúc không được trước ngày bắt đầu, vui lòng chọn lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (ThongKeServices.getTop5YeuThich(dtFromDate.Value.Date, dtToDate.Value.Date, int.Parse(cbxTop.Text)).Count == 0)
            {
                MessageBox.Show("Không có băng đĩa được bán từ "+ dtFromDate.Value.ToShortDateString() + " đến " + dtToDate.Value.ToShortDateString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            getTop5BangDiaYeuThich_ResultBindingSource.DataSource = ThongKeServices.getTop5YeuThich(dtFromDate.Value.Date, dtToDate.Value.Date, int.Parse(cbxTop.Text));
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("fromDate", dtFromDate.Value.ToShortDateString()),
                new  Microsoft.Reporting.WinForms.ReportParameter("toDate", dtToDate.Value.ToShortDateString()),
                new  Microsoft.Reporting.WinForms.ReportParameter("top", int.Parse(cbxTop.Text).ToString()),
            };
            reportViewer1.LocalReport.SetParameters(rParams);
            reportViewer1.RefreshReport();
        }
    }
}
