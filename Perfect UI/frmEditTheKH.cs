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
using DALs;
using BUS;
using QuanLyThueBangDia;
using EnteriesQLBangDia;

namespace Perfect_UI
{
    public partial class frmEditTheKH : MetroFramework.Forms.MetroForm
    {
        KhachHangBUS khBus = new KhachHangBUS() ;
        TheThanhVienBUS ttvBUS = new TheThanhVienBUS();
        PhieuThueBUS ptBUS = new PhieuThueBUS();
        Model.tblTheThanhVien membercard;
        bool isNew;
        int loai = 0;
        string maKH = "";
        public frmEditTheKH(Model.tblTheThanhVien obj, string IDfromFrmKH, int k)
        {
            InitializeComponent();
            maKH = IDfromFrmKH;
            if (obj == null)
            {
                //tblTheThanhVienBindingSource.DataSource = new tblTheThanhVien();     
                
                txtID.Enabled = false;

                if (!String.IsNullOrEmpty(IDfromFrmKH))
                {
                    txtID.Text = IDfromFrmKH;
                    txtTen.Text = khBus.LayTenKhachHang(txtID.Text);
                }
                    //if (k != 1)                   
                //        txtID.Enabled = false;                  
                //}
                //else 
                //{
                //    loadValidation();
                //}

                //txtMaThe.Enabled = true;
                txtMaThe.Text = BLL.TheKhachHangServices.getIDCardAuto();
                metroDateTime1.Value = DateTime.Now.Date;
                metroDateTime2.Value = metroDateTime1.Value.AddYears(3);              
                isNew = true;

                loai = k;
            }
            else
            {
                //this.tblTheThanhVienBindingSource.DataSource = obj;
                txtID.Text = obj.maKH;
                txtMaThe.Text = obj.maThe;
                txtTen.Text = khBus.LayTenKhachHang(txtID.Text);
                metroDateTime1.Value = obj.ngayCap.Value;
                metroDateTime1.Enabled = true;
                metroDateTime2.Value = obj.ngayHetHan.Value;
                isNew = false;

                loai = k;
            }
        }

        private void frmEditTheKH_Load(object sender, EventArgs e)
        {
            //if (loai == 0)
            //   btnSave.Enabled = loadValidation() ? true : false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnBrowse_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    // image filters  
        //    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        // display image in picture box  
        //        picAvatar.Image = new Bitmap(open.FileName);
        //        // image file path  
        //    }
        //}

        private void frmEditTheKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (ttvBUS.LayTheThanhVienTheoMaKH(txtID.Text).Count > 0)
            //{
            //   MetroFramework.MetroMessageBox.Show(this, "Khách hàng này đã có thẻ, không thể tạo thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
            //    return;
            //}

            //if (DialogResult == DialogResult.OK)
            //{
            //    membercard = new Model.tblTheThanhVien();
            //    membercard.maKH = txtID.Text;
            //    membercard.maThe = txtMaThe.Text;
            //    membercard.ngayCap = metroDateTime1.Value.Date;
            //    membercard.ngayHetHan = metroDateTime2.Value.Date;

            //    if (isNew)
            //    {
            //        //Model.tblTheThanhVien                   
            //        TheKhachHangServices.insert(membercard);
            //        MessageBox.Show("Thẻ khách hàng: " + membercard.maThe + " đã được tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        // TheKhachHangServices.insert(tblTheThanhVienBindingSource.Current as tblTheThanhVien);
            //    }
            //    else
            //    {
            //        TheKhachHangServices.update(membercard);
            //        MessageBox.Show(" Thông tin thẻ khách hàng: " + txtTen + " cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
                    
            //  }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            metroDateTime2.Value = metroDateTime1.Value.AddYears(3);
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            //txtTen.Text = khBus.LayTenKhachHang(txtID.Text);
            //btnSave.Enabled = loadValidation() ? true : false;                  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            membercard = new Model.tblTheThanhVien();
            membercard.maKH = txtID.Text;
            membercard.maThe = txtMaThe.Text;
            membercard.ngayCap = metroDateTime1.Value.Date;
            membercard.ngayHetHan = metroDateTime2.Value.Date;

            if (isNew)
            {
                //if (String.IsNullOrEmpty(txtTen.Text))
                //    MetroFramework.MetroMessageBox.Show(this, "Khách hàng không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                //if (ttvBUS.LayTheThanhVienTheoMaKH(txtID.Text).Count > 0)
                //{
                //    MetroFramework.MetroMessageBox.Show(this, "Khách hàng này đã có thẻ, không thể tạo thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);    
                //}
                //else
                if (loai == 0)
                {

                    TheKhachHangServices.insert(membercard);
                    MetroFramework.MetroMessageBox.Show(this, "Thẻ khách hàng: " + txtTen.Text + " đã được tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 120);
                    frmTheKhachHang frm = new frmTheKhachHang();
                    frm.refresh_GridView();
                    this.Close();
                    // TheKhachHangServices.insert(tblTheThanhVienBindingSource.Current as tblTheThanhVien);
                }
                else if (loai == 2)
                {
                    eTheThanhVien ttv = new eTheThanhVien();
                    ttv.MaThe = txtMaThe.Text;
                    ttv.MaKhachHang = txtID.Text;
                    ttv.NgayCap = metroDateTime1.Text.ToString();
                    ttv.NgayHetHan = metroDateTime2.Text.ToString();
                    List<eTheThanhVien> lst = new List<eTheThanhVien>();
                    lst = ttvBUS.LayTheThanhVienTheoMaKH(maKH);
                    string maTheCu = "";
                    foreach (eTheThanhVien tt in lst)
                    {
                        maTheCu = tt.MaThe;
                    }
                    ttvBUS.TaoThe(ttv);
                    ptBUS.ChuyenPhieuThueSangTheKhac(maTheCu.Trim(), txtMaThe.Text);
                    ttvBUS.XoaThe(maTheCu);
                    MessageBox.Show("Làm lại thành công: thẻ cũ: " + maTheCu + " Thẻ mới: " + txtMaThe.Text);
                    this.Close();
                }

            }
            else
            {
                TheKhachHangServices.update(membercard);
                MetroFramework.MetroMessageBox.Show(this, "Thông tin thẻ khách hàng: " + txtTen.Text + " cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 120);
                this.Close();
            }
        }

        //#region ID's Validation
        //private bool loadValidation()
        //{
        //    bool isNotError = false;
        //    if (txtID.Text == string.Empty)
        //    {
        //        warningProvider.SetError(txtID, "Vui lòng nhập mã khách hàng!");
        //        errorCardProvider.SetError(txtID, "");
        //        tickProvider.SetError(txtID, "");
        //        onlyNumberProvider.SetError(txtID, "");
        //        notActiveProvider.SetError(txtID, "");
        //        return false;
        //    }
        //    else if (txtID.Text.Length > 2)                 
        //    {
        //        if  (txtID.Text.Substring(0, 2).ToLower().Equals("KH"))
        //            if (RegEx.CheckIsNumber(txtID.Text.Substring(2))  && ttvBUS.LayTheThanhVienTheoMaKH(txtID.Text).Count == 0) //&& txtTen.Text != string.Empty
        //            {
        //                onlyNumberProvider.SetError(txtID, "");
        //                notActiveProvider.SetError(txtID, "");
        //                warningProvider.SetError(txtID, "");
        //                errorCardProvider.SetError(txtID, "");
        //                tickProvider.SetError(txtID, "Hoàn thành");
        //                isNotError = true;
        //            }                
        //    }
        //    else if (txtID.Text.Length < 3 ) //&& !txtID.Text.Substring(0, 2).ToLower().Equals("KH") || !RegEx.CheckIsNumber(txtID.Text.Substring(2)))
        //    {
        //        errorCardProvider.SetError(txtID, "");
        //        notActiveProvider.SetError(txtID, "");
        //        tickProvider.SetError(txtID, "");
        //        warningProvider.SetError(txtID, "");
        //        onlyNumberProvider.SetError(txtID, "Mã gồm chữ số và bắt đầu bằng 'KH'");
        //        return false;

        //        if (!txtID.Text.Substring(0, 2).ToLower().Equals("KH"))
        //            if (!RegEx.CheckIsNumber(txtID.Text.Substring(2)))
        //            {
        //                errorCardProvider.SetError(txtID, "");
        //                notActiveProvider.SetError(txtID, "");
        //                tickProvider.SetError(txtID, "");
        //                warningProvider.SetError(txtID, "");
        //                onlyNumberProvider.SetError(txtID, "Mã gồm chữ số và bắt đầu bằng 'KH'");
        //            }                      
                
        //        return false;
        //    }
        //    else if (txtID.Text != string.Empty && ttvBUS.LayTheThanhVienTheoMaKH(txtID.Text).Count > 0)
        //    {
        //        onlyNumberProvider.SetError(txtID, "");
        //        warningProvider.SetError(txtID, "");
        //        notActiveProvider.SetError(txtID, "");
        //        tickProvider.SetError(txtID, "");
        //        errorCardProvider.SetError(txtID, "Khách hàng đã có thẻ, không thể tạo thêm");
        //        return false;
        //    }
        //    else // (txtTen.Text == string.Empty)
        //    {
        //        tickProvider.SetError(txtID, "");
        //        errorCardProvider.SetError(txtID, "");
        //        onlyNumberProvider.SetError(txtID, "");
        //        warningProvider.SetError(txtID, "");
        //        notActiveProvider.SetError(txtID, "Không tồn tại khách hàng");               
        //        return false;
        //    }

        //    return isNotError;
        //}

        //#endregion
    }
}
