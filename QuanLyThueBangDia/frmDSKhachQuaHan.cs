using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace QuanLyThueBangDia
{
    public partial class frmDSKhachQuaHan : Form
    {
        public frmDSKhachQuaHan()
        {
            InitializeComponent();
        }

        private void frmDSKhachQuaHan_Load(object sender, EventArgs e)
        {
            getBlackList_ResultBindingSource.DataSource = ThongKeServices.getDSQuaHan();
            this.reportViewer1.RefreshReport();
        }
    }
}
