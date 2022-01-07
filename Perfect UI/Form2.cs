using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using QuanLyThueBangDia;
using BUS;
using EnteriesQLBangDia;

namespace Perfect_UI
{
    public partial class Form2 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form2()
        {
            InitializeComponent();    
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new frmInit());
        }

        string tk = "";
        string mk = "";
        NhanVienBUS nvBUS;
        public eNhanVien nvTrangChu;
        public Form2(string taiKhoan, string matKhau)
        {
            InitializeComponent();
            nvBUS = new NhanVienBUS();
            nvTrangChu = new eNhanVien();
            tk = taiKhoan;
            mk = matKhau;
            nvTrangChu = nvBUS.GetNhanVienTheoTaiKhoan(tk);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form         
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new frmInit());
        }

        //SubMenu
        //private void custommizeDesing()
        //{
        //    subMenuQLThue.Visible = false;
        //    subMenuQlKH.Visible = false;
        //}

        private void hideSubMenu()
        {
            if (subMenuQLThue.Visible == true)
            {

                subMenuTrans.HideSync(subMenuQLThue, false, BunifuAnimatorNS.Animation.Mosaic);
                subMenuQLThue.Visible = false;

            }

            if (subMenuQlKH.Visible == true)
            {

                subMenuTrans.HideSync(subMenuQlKH, false, BunifuAnimatorNS.Animation.Mosaic);
                subMenuQlKH.Visible = false;
            }

            if (subMenuThongKe.Visible == true)
            {

                subMenuTrans.HideSync(subMenuThongKe, false, BunifuAnimatorNS.Animation.Mosaic);
                subMenuThongKe.Visible = false;
            }

        }

        private void showSubMenu(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                hideSubMenu();
                subMenuTrans.ShowSync(pnl);
                pnl.Visible = true;
            }
            else
            {
                subMenuTrans.HideSync(pnl, false, BunifuAnimatorNS.Animation.Mosaic);
               
                pnl.Visible = false;


            }

        }

        //Text Button
        private void hideTextButton()
        {
            btnBangDia.Text = "";
            btnKhachHang.Text = "";
            btnNhanVien.Text = "";
            btnThue.Text = "";
            btnThongKe.Text = "";
        }

        private void showTextButton()
        {
            btnBangDia.Text = "    Quản lý băng đĩa";
            btnKhachHang.Text = "   Quản lý khách hàng";
            btnNhanVien.Text = "   Quản lý nhân viên";
            btnThue.Text = "    Quản lý thuê";
            btnThongKe.Text = "   Thống kê";
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(0, 232, 58);
            public static Color color5 = Color.FromArgb(255, 255, 66);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color, Panel pnl)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                if (pnl == null)
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                else
                    leftBorderBtn.Location = new Point(0, pnl.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Form
                icnCurrentChosen.IconChar = currentBtn.IconChar;
                icnCurrentChosen.IconColor = currentBtn.IconColor;

                //Lable Title Form
                lblTileHome.Text = currentBtn.Text.Substring(3);
                lblTileHome.ForeColor = currentBtn.ForeColor;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = nvTrangChu.MaNhanVien.ToString();
            txtTenNV.Text = nvTrangChu.HoTen.ToString();
            if (txtMaNV.Text.Substring(0, 2).Equals("QL"))
            {
                btnNhanVien.Enabled = true;
                iconNote.Visible = false;
                
            }
            else
            {
                btnNhanVien.Enabled = false;
                iconNote.Visible = true;
            }

            try
            {
                if (!string.IsNullOrEmpty(nvTrangChu.Avatar))
                    picAvatar.Image = Image.FromFile(nvTrangChu.Avatar.ToString());
                else
                        picAvatar.Image = picAvatar.ErrorImage;
            }
            catch
            {
                picAvatar.Image = picAvatar.ErrorImage;
            }
        }

        //private void icnDash_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender, RGBColors.color1);
        //    //OpenChildForm(new FormDashboard());
        //}

        private void btnThue_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6, null);
            showSubMenu(subMenuQLThue);
        }

        private void btnBangDia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2, null);
            hideSubMenu();
           OpenChildForm(new frmQLBangDia());
            panelDesktop.Visible = false;

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3, null);
            showSubMenu(subMenuQlKH);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4, panelBoundBtnNV);
            hideSubMenu();
            OpenChildForm(new frmNhanVien(txtMaNV.Text, picAvatar));
            panelDesktop.Visible = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5, panelBoundBtnThongKe);
            //OpenChildForm(new frmThongKe());
            showSubMenu(subMenuThongKe);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmInit());
            Reset();
        }
        private bool CheckExistForm(string nameForm)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == nameForm)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string nameForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == nameForm)
                {
                    frm.Activate();
                    break;
                }
            }

        }
        private void OpenChildForm(Form frmChild)
        {
            if (!CheckExistForm(frmChild.Name))
            {
                this.IsMdiContainer = true;
                frmChild.MdiParent = this;
                frmChild.TopLevel = false;
                frmChild.FormBorderStyle = FormBorderStyle.None;
                frmChild.Dock = DockStyle.Fill;
                frmChild.BringToFront();
                frmChild.Show();
            }
            else
                ActiveChildForm(frmChild.Name);



            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            //currentChildForm = childForm;
            ////End
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelDesktop.Controls.Add(childForm);
            //panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
        }

        private void OpenChildForm2(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icnCurrentChosen.IconChar = IconChar.Home;
            icnCurrentChosen.IconColor = Color.MediumOrchid;
            lblTileHome.Text = "Home";
            lblTileHome.ForeColor = Color.MediumOrchid;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Application.Exit();
            }
                
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.Visible = false;
            hideTextButton(); hideSubMenu();
            logoTrans.HideSync(btnHome);
            
            pnlMenu.Visible = false;
            btnThoat.Text = "";

            DisableButton();
       
            pnlMenu.Width = 70;
            pnlTrans.ShowSync(pnlMenu);
            logoTrans2.ShowSync(picHouse);
            btnThue.Enabled = false;
            btnKhachHang.Enabled = false;
            btnNhanVien.Enabled = false;
            btnThongKe.Enabled = false;
            btnBangDia.Enabled = false;
            
        }

        private void picHouse_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            showTextButton();
            picHouse.Visible = false;
            btnMenu.Visible = true;
            btnThoat.Text = "   Thoát";

            

            pnlMenu.Width = 220;
            pnlTrans2.ShowSync(pnlMenu);
            logoTrans.ShowSync(btnHome);
            btnThue.Enabled = true;
            btnKhachHang.Enabled = true;
            if (txtMaNV.Text.Substring(0, 2).Equals("QL"))
                btnNhanVien.Enabled = true;
            btnThongKe.Enabled = true;
            btnBangDia.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            //
            //
            hideSubMenu();
            OpenChildForm(new frmTaoPhieuThue(nvTrangChu));
            panelDesktop.Visible = false;
        }

        private void btnTraBangDia_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm2(new frmTraBangDia());
            //OpenChildForm(new frmTraBangDia());
            panelDesktop.Visible = true;       

        }

        private void btnXoaSuaPT_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           OpenChildForm(new frmXoaSuaPhieuThue());
        }

        private void btnSubKhachHang_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           OpenChildForm(new frmKhachHang());
            panelDesktop.Visible = false;
        }

        private void btnTheKH_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmTheKhachHang());
            panelDesktop.Visible = false;
        }


        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmTKDoanhThu());
            panelDesktop.Visible = false;
        }

        private void btnBangDiaThue_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmDSBangDiaThueNhieu());
            panelDesktop.Visible = false;
        }

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new frmDSKhachQuaHan());
            panelDesktop.Visible = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpFileName = @"C:\Users\ASUS\Desktop\BaoCao_PTUD_3_1_2021_Final\BaoCao_PTUD\QuanLyThueBangDia\Perfect UI\bin\Debug\Huong_Dan\Huong_Dan.chm";//Application.StartupPath + @"Huong_Dan.chm";//@"C:\Users\ASUS\Desktop\BaoCao_PTUD_3_1_2021_Final\BaoCao_PTUD\QuanLyThueBangDia\Help\Help.chm";
            if (System.IO.File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }
        }

        //Windown Media Player
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            play();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {     
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    open(ofd.FileName);
                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            stop();
        }
    }
}
