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

namespace Perfect_UI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

            //chart1.Series["tblBangDia"].XValueMember = "tenBangDia";
            //chart1.Series["tblBangDia"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //chart1.Series["tblBangDia"].YValueMembers = "soLuongTon";
            //chart1.Series["tblBangDia"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            //getReportTongDoanhThu_ResultBindingSource.DataSource = ThongKeServices.getListThongKeDoanhSo(dtFromDate.Value.Date, dtToDate.Value.Date);

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
