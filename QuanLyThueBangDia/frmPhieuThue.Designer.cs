namespace QuanLyThueBangDia
{
    partial class frmPhieuThue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaPhieu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.txtHoTenbg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaThebg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInPhieuThue = new FontAwesome.Sharp.IconButton();
            this.txtNgayThue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTongTien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnTaoPhieu = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBangDiaThue = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiaThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtMaPhieu);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 74);
            this.panel1.TabIndex = 0;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMaPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaPhieu.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaPhieu.HintText = "";
            this.txtMaPhieu.isPassword = false;
            this.txtMaPhieu.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaPhieu.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaPhieu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaPhieu.LineThickness = 3;
            this.txtMaPhieu.Location = new System.Drawing.Point(148, 19);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(107, 28);
            this.txtMaPhieu.TabIndex = 27;
            this.txtMaPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(47, 28);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 19);
            this.bunifuCustomLabel3.TabIndex = 26;
            this.bunifuCustomLabel3.Text = "Mã phiếu:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.txtHoTen);
            this.panel4.Controls.Add(this.txtMaThe);
            this.panel4.Controls.Add(this.txtHoTenbg);
            this.panel4.Controls.Add(this.txtMaThebg);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(431, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 74);
            this.panel4.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(100, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(172, 26);
            this.txtHoTen.TabIndex = 29;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(100, 4);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(172, 26);
            this.txtMaThe.TabIndex = 28;
            this.txtMaThe.TextChanged += new System.EventHandler(this.txtMaThe_TextChanged);
            // 
            // txtHoTenbg
            // 
            this.txtHoTenbg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenbg.Enabled = false;
            this.txtHoTenbg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoTenbg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTenbg.HintForeColor = System.Drawing.Color.Empty;
            this.txtHoTenbg.HintText = "";
            this.txtHoTenbg.isPassword = false;
            this.txtHoTenbg.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtHoTenbg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHoTenbg.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtHoTenbg.LineThickness = 3;
            this.txtHoTenbg.Location = new System.Drawing.Point(100, 37);
            this.txtHoTenbg.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenbg.Name = "txtHoTenbg";
            this.txtHoTenbg.Size = new System.Drawing.Size(172, 28);
            this.txtHoTenbg.TabIndex = 4;
            this.txtHoTenbg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaThebg
            // 
            this.txtMaThebg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaThebg.Enabled = false;
            this.txtMaThebg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaThebg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaThebg.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaThebg.HintText = "";
            this.txtMaThebg.isPassword = false;
            this.txtMaThebg.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaThebg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaThebg.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaThebg.LineThickness = 3;
            this.txtMaThebg.Location = new System.Drawing.Point(100, 4);
            this.txtMaThebg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThebg.Name = "txtMaThebg";
            this.txtMaThebg.Size = new System.Drawing.Size(172, 28);
            this.txtMaThebg.TabIndex = 3;
            this.txtMaThebg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thẻ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtNgayThue);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 106);
            this.panel2.TabIndex = 1;
            // 
            // btnInPhieuThue
            // 
            this.btnInPhieuThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuThue.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnInPhieuThue.IconColor = System.Drawing.Color.Black;
            this.btnInPhieuThue.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnInPhieuThue.IconSize = 34;
            this.btnInPhieuThue.Location = new System.Drawing.Point(24, 48);
            this.btnInPhieuThue.Name = "btnInPhieuThue";
            this.btnInPhieuThue.Size = new System.Drawing.Size(139, 55);
            this.btnInPhieuThue.TabIndex = 32;
            this.btnInPhieuThue.Text = "In phiếu thuê";
            this.btnInPhieuThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInPhieuThue.UseVisualStyleBackColor = true;
            this.btnInPhieuThue.Visible = false;
            this.btnInPhieuThue.Click += new System.EventHandler(this.btnInPhieuThue_Click);
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayThue.Enabled = false;
            this.txtNgayThue.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txtNgayThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNgayThue.HintForeColor = System.Drawing.Color.Empty;
            this.txtNgayThue.HintText = "";
            this.txtNgayThue.isPassword = false;
            this.txtNgayThue.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNgayThue.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNgayThue.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNgayThue.LineThickness = 4;
            this.txtNgayThue.Location = new System.Drawing.Point(170, 57);
            this.txtNgayThue.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Size = new System.Drawing.Size(198, 31);
            this.txtNgayThue.TabIndex = 4;
            this.txtNgayThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTongTien.HintForeColor = System.Drawing.Color.Empty;
            this.txtTongTien.HintText = "";
            this.txtTongTien.isPassword = false;
            this.txtTongTien.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTongTien.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTongTien.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTongTien.LineThickness = 4;
            this.txtTongTien.Location = new System.Drawing.Point(170, 5);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(198, 38);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnInPhieuThue);
            this.panel5.Controls.Add(this.btnHuy);
            this.panel5.Controls.Add(this.btnTaoPhieu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(431, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 106);
            this.panel5.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnHuy.IconColor = System.Drawing.Color.Black;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHuy.IconSize = 34;
            this.btnHuy.Location = new System.Drawing.Point(50, 24);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 55);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "  Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieu.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.btnTaoPhieu.IconColor = System.Drawing.Color.Black;
            this.btnTaoPhieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaoPhieu.IconSize = 34;
            this.btnTaoPhieu.Location = new System.Drawing.Point(144, 24);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(118, 55);
            this.btnTaoPhieu.TabIndex = 32;
            this.btnTaoPhieu.Text = "Tạo phiếu";
            this.btnTaoPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoPhieu.UseVisualStyleBackColor = true;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày thuê:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền (VNĐ):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBangDiaThue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 216);
            this.panel3.TabIndex = 2;
            // 
            // dgvBangDiaThue
            // 
            this.dgvBangDiaThue.AllowUserToAddRows = false;
            this.dgvBangDiaThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiaThue.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBangDiaThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBangDiaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiaThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiaThue.Location = new System.Drawing.Point(0, 0);
            this.dgvBangDiaThue.Name = "dgvBangDiaThue";
            this.dgvBangDiaThue.RowHeadersVisible = false;
            this.dgvBangDiaThue.Size = new System.Drawing.Size(727, 216);
            this.dgvBangDiaThue.TabIndex = 0;
            this.dgvBangDiaThue.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDiaThue_CellEndEdit);
            this.dgvBangDiaThue.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvBangDiaThue_EditingControlShowing);
            // 
            // frmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 476);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhieuThue";
            this.Text = "PHIẾU THUÊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuThue_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuThue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiaThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaPhieu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHoTenbg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaThebg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNgayThue;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTongTien;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnTaoPhieu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaThe;
        private FontAwesome.Sharp.IconButton btnInPhieuThue;
        private System.Windows.Forms.DataGridView dgvBangDiaThue;
    }
}