using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro
{
    public partial class frmStaff_Info : MetroFramework.Forms.MetroForm
    {
        public frmStaff_Info(tblNhanVien obj)
        {
            InitializeComponent();
            bindingSourceStaff.DataSource = obj;
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Nam";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Nữ";
            else
                chkGender.Text = "Click vào ô";
        }
        
        public tblNhanVien NhanVienInfo { get { return bindingSourceStaff.Current as tblNhanVien; } }

        private void Staff_Info_Load(object sender, EventArgs e)
        {
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSourceStaff.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void chkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Nam";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Nữ";
            else
                chkGender.Text = "Click vào ô";
        }

        private void chkGender_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
