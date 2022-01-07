namespace QuanLyThueBangDia
{
    partial class frmTraBangDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraBangDia));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuThue = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.daTra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvDanhSachBangDia = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel7 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel8 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnToanBoPhieu = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboPhieuThueLoc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new FontAwesome.Sharp.IconButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtMaKhachHang = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBangDia)).BeginInit();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1243, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH PHIẾU THUÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPhieuThue
            // 
            this.dgvPhieuThue.AllowUserToOrderColumns = true;
            this.dgvPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuThue.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPhieuThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhieuThue.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhieuThue.Location = new System.Drawing.Point(0, 85);
            this.dgvPhieuThue.Name = "dgvPhieuThue";
            this.dgvPhieuThue.ReadOnly = true;
            this.dgvPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuThue.Size = new System.Drawing.Size(1243, 196);
            this.dgvPhieuThue.TabIndex = 3;
            this.dgvPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThue_CellClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1243, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "DANH SÁCH BĂNG ĐĨA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daTra
            // 
            this.daTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.daTra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.daTra.HeaderText = "Đã trả đủ";
            this.daTra.Name = "daTra";
            // 
            // dgvDanhSachBangDia
            // 
            this.dgvDanhSachBangDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBangDia.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDanhSachBangDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachBangDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBangDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.daTra});
            this.dgvDanhSachBangDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachBangDia.Location = new System.Drawing.Point(0, 310);
            this.dgvDanhSachBangDia.Name = "dgvDanhSachBangDia";
            this.dgvDanhSachBangDia.RowHeadersVisible = false;
            this.dgvDanhSachBangDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachBangDia.Size = new System.Drawing.Size(1243, 299);
            this.dgvDanhSachBangDia.TabIndex = 5;
            this.dgvDanhSachBangDia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBangDia_CellContentClick);
            this.dgvDanhSachBangDia.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBangDia_CellContentDoubleClick);
            this.dgvDanhSachBangDia.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBangDia_CellValueChanged);
            this.dgvDanhSachBangDia.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDanhSachBangDia_EditingControlShowing);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bunifuGradientPanel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 46);
            this.panel2.TabIndex = 1;
            // 
            // bunifuGradientPanel7
            // 
            this.bunifuGradientPanel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel7.BackgroundImage")));
            this.bunifuGradientPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel7.Controls.Add(this.panel3);
            this.bunifuGradientPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel7.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel7.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel7.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel7.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel7.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel7.Name = "bunifuGradientPanel7";
            this.bunifuGradientPanel7.Quality = 10;
            this.bunifuGradientPanel7.Size = new System.Drawing.Size(1239, 42);
            this.bunifuGradientPanel7.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Location = new System.Drawing.Point(418, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 41);
            this.panel3.TabIndex = 33;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Black;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 30;
            this.btnLuu.Location = new System.Drawing.Point(112, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 33);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnHuy.IconColor = System.Drawing.Color.Black;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 30;
            this.btnHuy.Location = new System.Drawing.Point(200, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 33);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bunifuGradientPanel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 56);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel8
            // 
            this.bunifuGradientPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel8.BackgroundImage")));
            this.bunifuGradientPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel8.Controls.Add(this.btnToanBoPhieu);
            this.bunifuGradientPanel8.Controls.Add(this.panel4);
            this.bunifuGradientPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel8.GradientBottomLeft = System.Drawing.Color.MediumSlateBlue;
            this.bunifuGradientPanel8.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel8.GradientTopLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel8.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel8.Name = "bunifuGradientPanel8";
            this.bunifuGradientPanel8.Quality = 10;
            this.bunifuGradientPanel8.Size = new System.Drawing.Size(1239, 52);
            this.bunifuGradientPanel8.TabIndex = 32;
            // 
            // btnToanBoPhieu
            // 
            this.btnToanBoPhieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToanBoPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToanBoPhieu.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnToanBoPhieu.IconColor = System.Drawing.Color.Black;
            this.btnToanBoPhieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToanBoPhieu.IconSize = 25;
            this.btnToanBoPhieu.Location = new System.Drawing.Point(1031, 6);
            this.btnToanBoPhieu.Name = "btnToanBoPhieu";
            this.btnToanBoPhieu.Size = new System.Drawing.Size(137, 37);
            this.btnToanBoPhieu.TabIndex = 31;
            this.btnToanBoPhieu.Text = "Toàn bộ phiếu";
            this.btnToanBoPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToanBoPhieu.UseVisualStyleBackColor = true;
            this.btnToanBoPhieu.Click += new System.EventHandler(this.btnToanBoPhieu_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtMaKhachHang);
            this.panel4.Controls.Add(this.cboPhieuThueLoc);
            this.panel4.Controls.Add(this.btnLoc);
            this.panel4.Controls.Add(this.bunifuCustomLabel3);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Location = new System.Drawing.Point(166, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 37);
            this.panel4.TabIndex = 0;
            // 
            // cboPhieuThueLoc
            // 
            this.cboPhieuThueLoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPhieuThueLoc.BackColor = System.Drawing.Color.Thistle;
            this.cboPhieuThueLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuThueLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhieuThueLoc.FormattingEnabled = true;
            this.cboPhieuThueLoc.Items.AddRange(new object[] {
            "Danh sách phiếu thuê đã trả",
            "Danh sách phiếu trễ hạn",
            "Danh sách phiếu đang thuê",
            "Tất cả phiếu"});
            this.cboPhieuThueLoc.Location = new System.Drawing.Point(462, 3);
            this.cboPhieuThueLoc.Name = "cboPhieuThueLoc";
            this.cboPhieuThueLoc.Size = new System.Drawing.Size(203, 27);
            this.cboPhieuThueLoc.TabIndex = 42;
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnLoc.IconColor = System.Drawing.Color.Black;
            this.btnLoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoc.IconSize = 25;
            this.btnLoc.Location = new System.Drawing.Point(671, 2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(67, 30);
            this.btnLoc.TabIndex = 43;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(5, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(179, 19);
            this.bunifuCustomLabel3.TabIndex = 27;
            this.bunifuCustomLabel3.Text = "Nhập mã thẻ khách hàng:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.Location = new System.Drawing.Point(744, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 30);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.Location = new System.Drawing.Point(332, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 30);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 56);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel2.TabIndex = 9;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(843, 56);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(843, 281);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel3.TabIndex = 14;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(0, 281);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel4.TabIndex = 15;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.txtMaKhachHang.BaseColor = System.Drawing.Color.White;
            this.txtMaKhachHang.BorderColor = System.Drawing.Color.Silver;
            this.txtMaKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhachHang.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaKhachHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaKhachHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaKhachHang.Location = new System.Drawing.Point(190, 3);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.PasswordChar = '\0';
            this.txtMaKhachHang.Radius = 5;
            this.txtMaKhachHang.SelectedText = "";
            this.txtMaKhachHang.Size = new System.Drawing.Size(136, 30);
            this.txtMaKhachHang.TabIndex = 16;
            // 
            // frmTraBangDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 655);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.dgvDanhSachBangDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPhieuThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTraBangDia";
            this.Text = "frmTraBangDia";
            this.Load += new System.EventHandler(this.frmTraBangDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBangDia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.bunifuGradientPanel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn daTra;
        public System.Windows.Forms.DataGridView dgvDanhSachBangDia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnHuy;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel7;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboPhieuThueLoc;
        private FontAwesome.Sharp.IconButton btnLoc;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnToanBoPhieu;
        private Guna.UI.WinForms.GunaTextBox txtMaKhachHang;
    }
}