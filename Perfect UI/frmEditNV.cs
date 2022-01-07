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
using QuanLyThueBangDia;
using EnteriesQLBangDia;
using BUS;

namespace Perfect_UI
{
    public partial class frmEditNV : MetroFramework.Forms.MetroForm
    {
        bool isNew;
        Model.tblNhanVien staff;
        string textNV;
        PictureBox avatarFrmMain;
        tblNhanVien currentObj;
        NhanVienBUS nvBUS = new NhanVienBUS();
        PhieuThueBUS ptBUS = new PhieuThueBUS();

        public frmEditNV(tblNhanVien obj, string textNV, PictureBox avatarFrmMain )
        {
            InitializeComponent();

            this.textNV = textNV;
            this.avatarFrmMain = avatarFrmMain;
            txtID.Enabled = false;

            currentObj = obj;

            if (obj == null)
            {              
                //bindingSource1.DataSource = new tblNhanVien();
                txtID.Text = BLL.NhanVienServices.getIDNVAuto();
                cbxGender.SelectedIndex = 0;
                this.btnNhaplai_Click(btnNhaplai, null);

                cbxTrangThai.SelectedIndex = 0;
                cbxTrangThai.Enabled = false;

                isNew = true;
            }
            else
            {
                bindingSource1.DataSource = obj;
                tickProvider.SetError(txtCMND, "Hoàn thành");
                try
                {
                    if (!string.IsNullOrEmpty(obj.avatar))
                        picAvatar.Image = Image.FromFile(obj.avatar);
                    else
                        picAvatar.Image = picAvatar.ErrorImage;
                }
                catch
                {
                    picAvatar.Image = picAvatar.ErrorImage;
                }
                
                isNew = false;
                cbxTrangThai.SelectedIndex = (bool)cbxTrangThai.Tag ?  0 : 1;

                //chkQL.Visible = false ;
                //chkQL.Enabled = false;
                chkQL.Checked = txtID.Text.Substring(0, 2).ToLower().Equals("QL") ? true : false;

            }
        }
        string chucVu = "";
        private void frmEditNV_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = loadValidation() ? true : false;
            if (cbxGender.Text == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            if (txtID.Text.Substring(0, 2) == "QL")
                chkQL.Checked = true;
            else
                chkQL.Checked = false;


            Form2 frm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (frm.txtMaNV.Text.Substring(2) == txtID.Text.Substring(2))
            {
                chkQL.Enabled = false;
            }

            chucVu = txtID.Text.Substring(0, 2);


        }

        #region Control's Event
        OpenFileDialog open;       
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picAvatar.Image = new Bitmap(open.FileName);
                // image file path  
                picAvatar.Tag = open.FileName.ToString();
            }
        }
        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtAcc.ResetText(); //this.txtAcc_KeyUp(txtAcc, null); //this.txtAcc_Validating(txtAcc, null);
            txtAddress.ResetText(); //this.txtAddress_KeyUp(txtAddress, null); //this.txtAddress_Validating(txtAddress, null);
            txtCMND.ResetText(); //this.txtCMND_KeyUp(txtCMND, null); //this.txtCMND_Validating(txtCMND, null);
            txtPass.ResetText(); //this.txtPass_KeyUp(txtPass, null); // this.txtPass_Validating(txtPass, null);
            txtName.ResetText();// this.txtName_KeyUp(txtName, null);//this.txtName_Validating(txtName, null);
            txtSDT.ResetText(); //this.txtSDT_KeyUp(txtSDT, null);//this.txtSDT_Validating(txtSDT, null);
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chkQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQL.Checked)
            {
                txtID.Text = "QL" + txtID.Text.Substring(2);
            }
            else
                txtID.Text = "NV" + txtID.Text.Substring(2);
        }
        #endregion
        
        private void frmEditNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //if (string.IsNullOrEmpty(txtID.Text))
                //{
                //    MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtID.Focus();
                //    e.Cancel = true;
                //    return;
                //}

                staff = new Model.tblNhanVien();
                staff.maNhanVien = txtID.Text;
                staff.tenNhanVien = txtName.Text;
                staff.ngaySinh = metroDateTime1.Value.Date;
                staff.soCMND = txtCMND.Text;
                staff.taiKhoan = txtAcc.Text;
                staff.matKhau = txtPass.Text;
                if (rdoNam.Checked)
                    staff.gioiTinh = "Nam";
                else
                    staff.gioiTinh = "Nữ";
                //staff.gioiTinh = cbxGender.Text;
                staff.diaChi = txtAddress.Text;
                staff.soDienThoai = txtSDT.Text;
                if (!String.IsNullOrEmpty(picAvatar.Tag.ToString()))
                    staff.avatar = picAvatar.Tag.ToString();
                staff.trangThai = cbxTrangThai.SelectedIndex == 0 ? true : false;

                if (isNew)
                {
                    NhanVienServices.insert(staff);
                    MetroFramework.MetroMessageBox.Show(this, "Nhân viên: " + staff.tenNhanVien + " đã được tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                }
                //NhanVienServices.insert(bindingSource1.Current as tblNhanVien);
                else
                {

                    //NhanVienServices.update(bindingSource1.Current as tblNhanVien);



                    if (chucVu == txtID.Text.Substring(0, 2))                    {                        NhanVienServices.update(staff);
                        if (staff.maNhanVien.Equals(this.textNV))
                            avatarFrmMain.Image = this.picAvatar.Image;
                                           }                    else                    {                        eNhanVien nvMoi = new eNhanVien();                        nvMoi.DiaChi = txtAddress.Text;                        nvMoi.MaNhanVien = txtID.Text;                        nvMoi.HoTen = txtName.Text;                        nvMoi.NgaySinh = metroDateTime1.Text;                        nvMoi.SoCMND = txtCMND.Text;                        nvMoi.TaiKhoan = txtAcc.Text;                        nvMoi.MatKhau = txtPass.Text;                        nvMoi.SoDienThoai = txtSDT.Text;                        nvMoi.Avatar = picAvatar.Tag.ToString();                        nvMoi.TrangThai = cbxTrangThai.Text.Equals("Đang làm việc") ? true : false ;                        if (rdoNam.Checked)                            nvMoi.GioiTinh = "Nam";                        else                            nvMoi.GioiTinh = "Nữ";                        nvBUS.newNhanVien(nvMoi);                        ptBUS.ChuyenPhieuThueSangNhanVienKhac(chucVu + txtID.Text.Substring(2), txtID.Text);                        nvBUS.XoaNV(chucVu + txtID.Text.Substring(2));


                    }
                    MetroFramework.MetroMessageBox.Show(this, "Thông tin nhân viên: " + staff.tenNhanVien + " cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

                }
               }
        }

        #region User Validation
        private bool loadValidation()
        {
            bool isNotError = false;

            if (txtName.Text == string.Empty)
            {
                warningProvider.SetError(txtName, "Vui lòng nhập tên!");
                errorProvider.SetError(txtName, "");
                tickProvider.SetError(txtName, "");
                return false;
            }
            else if (RegEx.CheckName(txtName.Text))
            {
                warningProvider.SetError(txtName, "");
                errorProvider.SetError(txtName, "");
                tickProvider.SetError(txtName, "Hoàn thành");
                isNotError = true;
            }
            else
            {
                warningProvider.SetError(txtName, "");
                errorProvider.SetError(txtName, "Không bao gồm chữ số và kí tự đặc biệt");
                tickProvider.SetError(txtName, "");
                return false;
            }


            if (txtCMND.Text == string.Empty)
            {
                warningProvider.SetError(txtCMND, "Vui lòng nhập CMND!");
                onlyNumberProvider.SetError(txtCMND, "");
                errorProvider.SetError(txtCMND, "");
                tickProvider.SetError(txtCMND, "");
                errorCardProvider.SetError(txtCMND, "");
                return false;
            }


            else if (NhanVienServices.isExistNV(txtCMND.Text))
            {
                if (currentObj == null)
                {
                    onlyNumberProvider.SetError(txtCMND, "");
                    errorProvider.SetError(txtCMND, "");
                    warningProvider.SetError(txtCMND, "");
                    errorCardProvider.SetError(txtCMND, "Nhân viên đã tồn tại !");
                    tickProvider.SetError(txtCMND, "");
                    return false;
                }
                else if (currentObj.soCMND != txtCMND.Text)
                {
                    onlyNumberProvider.SetError(txtCMND, "");
                    errorProvider.SetError(txtCMND, "");
                    warningProvider.SetError(txtCMND, "");
                    errorCardProvider.SetError(txtCMND, "Nhân viên đã tồn tại !");
                    tickProvider.SetError(txtCMND, "");
                    return false;
                }
            }

            else if (RegEx.CheckIsNumber(txtCMND.Text))
            {
                if (currentObj == null)
                {
                    if (NhanVienServices.isExistNV(txtCMND.Text) == false)
                    {
                        onlyNumberProvider.SetError(txtCMND, "");
                        errorCardProvider.SetError(txtCMND, "");
                        warningProvider.SetError(txtCMND, "");
                        errorProvider.SetError(txtCMND, "");
                        tickProvider.SetError(txtCMND, "Hoàn thành");
                        isNotError = true;
                    }
                }
                else
                {
                    if (currentObj.soCMND == txtCMND.Text)
                    {
                        onlyNumberProvider.SetError(txtCMND, "");
                        errorCardProvider.SetError(txtCMND, "");
                        warningProvider.SetError(txtCMND, "");
                        errorProvider.SetError(txtCMND, "");
                        tickProvider.SetError(txtCMND, "Hoàn thành");
                        isNotError = true;
                    }
                    else if (NhanVienServices.isExistNV(txtCMND.Text) == false)
                    {
                        onlyNumberProvider.SetError(txtCMND, "");
                        errorCardProvider.SetError(txtCMND, "");
                        warningProvider.SetError(txtCMND, "");
                        errorProvider.SetError(txtCMND, "");
                        tickProvider.SetError(txtCMND, "Hoàn thành");
                        isNotError = true;
                    }

                }
            }

            else
            {
                errorCardProvider.SetError(txtCMND, "");
                errorProvider.SetError(txtCMND, "");
                warningProvider.SetError(txtCMND, "");
                onlyNumberProvider.SetError(txtCMND, "Chỉ bao gồm chữ số");
                tickProvider.SetError(txtCMND, "");
                return false;
            }


            if (txtAddress.Text == string.Empty)
            {
                warningProvider.SetError(txtAddress, "Vui lòng nhập địa chỉ!");
                errorProvider.SetError(txtAddress, "");
                tickProvider.SetError(txtAddress, "");
                return false;
            }
            else
            {
                warningProvider.SetError(txtAddress, "");
                errorProvider.SetError(txtAddress, "");
                tickProvider.SetError(txtAddress, "Hoàn thành");
                isNotError = true;
            }


            if (txtSDT.Text == string.Empty)
            {
                warningProvider.SetError(txtSDT, "Vui lòng nhập số điện thoại!");
                onlyNumberProvider.SetError(txtSDT, "");
                errorProvider.SetError(txtSDT, "");
                tickProvider.SetError(txtSDT, "");
                return false;
            }
            else if (RegEx.CheckPhone(txtSDT.Text))
            {
                onlyNumberProvider.SetError(txtSDT, "");
                warningProvider.SetError(txtSDT, "");
                errorProvider.SetError(txtSDT, "");
                tickProvider.SetError(txtSDT, "Hoàn thành");
                isNotError = true;
            }
            else
            {
                errorProvider.SetError(txtSDT, "");
                warningProvider.SetError(txtSDT, "");
                onlyNumberProvider.SetError(txtSDT, "Đủ 10 chữ số và bắt đầu bằng số 0");
                tickProvider.SetError(txtSDT, "");
                return false;
            }


            if (txtAcc.Text == string.Empty)
            {
                warningProvider.SetError(txtAcc, "Vui lòng nhập tên tài khoản!");
                errorProvider.SetError(txtAcc, "");
                tickProvider.SetError(txtAcc, "");
                return false;
            }
            else
            {
                warningProvider.SetError(txtAcc, "");
                errorProvider.SetError(txtAcc, "");
                tickProvider.SetError(txtAcc, "Hoàn thành");
                isNotError = true;
            }


            if (txtPass.Text == string.Empty)
            {
                warningProvider.SetError(txtPass, "Vui lòng nhập mật khẩu!");
                errorProvider.SetError(txtPass, "");
                tickProvider.SetError(txtPass, "");
                return false;
            }
            else
            {
                warningProvider.SetError(txtPass, "");
                errorProvider.SetError(txtPass, "");
                tickProvider.SetError(txtPass, "Hoàn thành");
                isNotError = true;
            }

            return isNotError;
        }

        private void loadNewValidation()
        {
            if (txtName.Text == string.Empty)
            {
                warningProvider.SetError(txtName, "Vui lòng nhập tên!");
                errorProvider.SetError(txtName, "");
                tickProvider.SetError(txtName, "");
        
            }
            else if (RegEx.CheckName(txtName.Text))
            {
                warningProvider.SetError(txtName, "");
                errorProvider.SetError(txtName, "");
                tickProvider.SetError(txtName, "Hoàn thành");
                
            }
            else
            {
                warningProvider.SetError(txtName, "");
                errorProvider.SetError(txtName, "Không bao gồm chữ số và kí tự đặc biệt");
                tickProvider.SetError(txtName, "");

            }


            if (txtCMND.Text == string.Empty)
            {
                warningProvider.SetError(txtCMND, "Vui lòng nhập CMND!");
                onlyNumberProvider.SetError(txtCMND, "");
                errorProvider.SetError(txtCMND, "");
                tickProvider.SetError(txtCMND, "");
                errorCardProvider.SetError(txtCMND, "");
            }
            

            else if (NhanVienServices.isExistNV(txtCMND.Text))
            {
                if (currentObj == null)
                {
                    onlyNumberProvider.SetError(txtCMND, "");
                    errorProvider.SetError(txtCMND, "");
                    warningProvider.SetError(txtCMND, "");
                    errorCardProvider.SetError(txtCMND, "Nhân viên đã tồn tại !");
                    tickProvider.SetError(txtCMND, "");
       
                }
                else if (currentObj.soCMND != txtCMND.Text)
                {
                    onlyNumberProvider.SetError(txtCMND, "");
                    errorProvider.SetError(txtCMND, "");
                    warningProvider.SetError(txtCMND, "");
                    errorCardProvider.SetError(txtCMND, "Nhân viên đã tồn tại !");
                    tickProvider.SetError(txtCMND, "");
                
                }
            }

            else if (RegEx.CheckIsNumber(txtCMND.Text))
            {
                if (currentObj == null)
                {
                    if (NhanVienServices.isExistNV(txtCMND.Text) == false)
                    {
                        onlyNumberProvider.SetError(txtCMND, "");
                        errorCardProvider.SetError(txtCMND, "");
                        warningProvider.SetError(txtCMND, "");
                        errorProvider.SetError(txtCMND, "");
                        tickProvider.SetError(txtCMND, "Hoàn thành");

                    }
                }
                else
                {
                    if (currentObj.soCMND == txtCMND.Text)
                    {
                        onlyNumberProvider.SetError(txtCMND, "");
                        errorCardProvider.SetError(txtCMND, "");
                        warningProvider.SetError(txtCMND, "");
                        errorProvider.SetError(txtCMND, "");
                        tickProvider.SetError(txtCMND, "Hoàn thành");

                    }
                    else if (NhanVienServices.isExistNV(txtCMND.Text) == false)
                    {
                        onlyNumberProvider.SetError(txtCMND, "");
                        errorCardProvider.SetError(txtCMND, "");
                        warningProvider.SetError(txtCMND, "");
                        errorProvider.SetError(txtCMND, "");
                        tickProvider.SetError(txtCMND, "Hoàn thành");

                    }

                }
            }
            else
            {
                errorCardProvider.SetError(txtCMND, "");
                errorProvider.SetError(txtCMND, "");
                warningProvider.SetError(txtCMND, "");
                onlyNumberProvider.SetError(txtCMND, "Chỉ bao gồm chữ số");
                tickProvider.SetError(txtCMND, "");
            }


            if (txtAddress.Text == string.Empty)
            {
                warningProvider.SetError(txtAddress, "Vui lòng nhập địa chỉ!");
                errorProvider.SetError(txtAddress, "");
                tickProvider.SetError(txtAddress, "");

            }
            else
            {
                warningProvider.SetError(txtAddress, "");
                errorProvider.SetError(txtAddress, "");
                tickProvider.SetError(txtAddress, "Hoàn thành");
             
            }


            if (txtSDT.Text == string.Empty)
            {
                warningProvider.SetError(txtSDT, "Vui lòng nhập số điện thoại!");
                onlyNumberProvider.SetError(txtSDT, "");
                errorProvider.SetError(txtSDT, "");
                tickProvider.SetError(txtSDT, "");
            }
            else if (RegEx.CheckPhone(txtSDT.Text))
            {
                onlyNumberProvider.SetError(txtSDT, "");
                warningProvider.SetError(txtSDT, "");
                errorProvider.SetError(txtSDT, "");
                tickProvider.SetError(txtSDT, "Hoàn thành");
            }
            else
            {
                errorProvider.SetError(txtSDT, "");
                warningProvider.SetError(txtSDT, "");
                onlyNumberProvider.SetError(txtSDT, "Đủ 10 chữ số và bắt đầu bằng số 0");
                tickProvider.SetError(txtSDT, "");
            }


            if (txtAcc.Text == string.Empty)
            {
                warningProvider.SetError(txtAcc, "Vui lòng nhập tên tài khoản!");
                errorProvider.SetError(txtAcc, "");
                tickProvider.SetError(txtAcc, "");
          
            }
            else
            {
                warningProvider.SetError(txtAcc, "");
                errorProvider.SetError(txtAcc, "");
                tickProvider.SetError(txtAcc, "Hoàn thành");
            
            }


            if (txtPass.Text == string.Empty)
            {
                warningProvider.SetError(txtPass, "Vui lòng nhập mật khẩu!");
                errorProvider.SetError(txtPass, "");
                tickProvider.SetError(txtPass, "");

            }
            else
            {
                warningProvider.SetError(txtPass, "");
                errorProvider.SetError(txtPass, "");
                tickProvider.SetError(txtPass, "Hoàn thành");
                
            }
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }

        private void txtCMND_KeyUp(object sender, KeyEventArgs e)
        {
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }

        private void txtSDT_KeyUp(object sender, KeyEventArgs e)
        {
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }

        private void txtAcc_KeyUp(object sender, KeyEventArgs e)
        {
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            loadNewValidation();
            btnSave.Enabled = loadValidation() ? true : false;
        }

        #endregion
    }
}
