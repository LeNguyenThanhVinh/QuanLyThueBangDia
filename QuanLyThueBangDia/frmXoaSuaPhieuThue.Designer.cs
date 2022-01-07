namespace QuanLyThueBangDia
{
    partial class frmXoaSuaPhieuThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaSuaPhieuThue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSBangDia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachPhieuThue = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel8 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtTheKH = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnTimTheKH = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtMaBangDia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoNgayThue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoLuongThue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoLuongDaTra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnXoaPhieuThue = new FontAwesome.Sharp.IconButton();
            this.btnXoaBangDia = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBangDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bunifuGradientPanel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel4);
            this.panel1.Controls.Add(this.bunifuGradientPanel3);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.panel1.Controls.Add(this.dgvDSBangDia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDanhSachPhieuThue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 540);
            this.panel1.TabIndex = 0;
            // 
            // dgvDSBangDia
            // 
            this.dgvDSBangDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBangDia.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvDSBangDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSBangDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBangDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBangDia.Location = new System.Drawing.Point(0, 319);
            this.dgvDSBangDia.Name = "dgvDSBangDia";
            this.dgvDSBangDia.ReadOnly = true;
            this.dgvDSBangDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBangDia.Size = new System.Drawing.Size(1059, 118);
            this.dgvDSBangDia.TabIndex = 9;
            this.dgvDSBangDia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBangDia_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1059, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH SÁCH BĂNG ĐĨA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachPhieuThue
            // 
            this.dgvDanhSachPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuThue.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvDanhSachPhieuThue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhSachPhieuThue.Location = new System.Drawing.Point(0, 82);
            this.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue";
            this.dgvDanhSachPhieuThue.ReadOnly = true;
            this.dgvDanhSachPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuThue.Size = new System.Drawing.Size(1059, 208);
            this.dgvDanhSachPhieuThue.TabIndex = 7;
            this.dgvDanhSachPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuThue_CellClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Cyan;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1059, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "DANH SÁCH PHIẾU THUÊ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 103);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txtSoLuongDaTra);
            this.panel6.Controls.Add(this.txtSoLuongThue);
            this.panel6.Controls.Add(this.txtSoNgayThue);
            this.panel6.Controls.Add(this.txtMaBangDia);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(166, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(889, 99);
            this.panel6.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số lượng đã trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số ngày thuê:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng thuê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã băng đĩa:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Controls.Add(this.btnXoaBangDia);
            this.panel5.Controls.Add(this.btnXoaPhieuThue);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 99);
            this.panel5.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuGradientPanel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 53);
            this.panel2.TabIndex = 0;
            // 
            // bunifuGradientPanel8
            // 
            this.bunifuGradientPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel8.BackgroundImage")));
            this.bunifuGradientPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel8.Controls.Add(this.flowLayoutPanel1);
            this.bunifuGradientPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel8.GradientBottomLeft = System.Drawing.Color.MediumSlateBlue;
            this.bunifuGradientPanel8.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel8.GradientTopLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel8.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel8.Name = "bunifuGradientPanel8";
            this.bunifuGradientPanel8.Quality = 10;
            this.bunifuGradientPanel8.Size = new System.Drawing.Size(1059, 53);
            this.bunifuGradientPanel8.TabIndex = 33;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.flowLayoutPanel1.Controls.Add(this.txtTheKH);
            this.flowLayoutPanel1.Controls.Add(this.btnTimTheKH);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(250, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 45);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(179, 19);
            this.bunifuCustomLabel3.TabIndex = 27;
            this.bunifuCustomLabel3.Text = "Nhập mã thẻ khách hàng:";
            // 
            // txtTheKH
            // 
            this.txtTheKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTheKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTheKH.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTheKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTheKH.HintForeColor = System.Drawing.Color.Empty;
            this.txtTheKH.HintText = "";
            this.txtTheKH.isPassword = false;
            this.txtTheKH.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTheKH.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTheKH.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTheKH.LineThickness = 3;
            this.txtTheKH.Location = new System.Drawing.Point(189, 4);
            this.txtTheKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheKH.Name = "txtTheKH";
            this.txtTheKH.Size = new System.Drawing.Size(134, 28);
            this.txtTheKH.TabIndex = 28;
            this.txtTheKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnTimTheKH
            // 
            this.btnTimTheKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimTheKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheKH.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnTimTheKH.IconColor = System.Drawing.Color.Black;
            this.btnTimTheKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimTheKH.IconSize = 25;
            this.btnTimTheKH.Location = new System.Drawing.Point(330, 3);
            this.btnTimTheKH.Name = "btnTimTheKH";
            this.btnTimTheKH.Size = new System.Drawing.Size(124, 30);
            this.btnTimTheKH.TabIndex = 29;
            this.btnTimTheKH.Text = "Tìm kiếm";
            this.btnTimTheKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimTheKH.UseVisualStyleBackColor = true;
            this.btnTimTheKH.Click += new System.EventHandler(this.btnTimTheKH_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.Location = new System.Drawing.Point(460, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 30);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 53);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel2.TabIndex = 10;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(659, 53);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel1.TabIndex = 14;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 290);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel3.TabIndex = 15;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(253)))));
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(659, 290);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(400, 29);
            this.bunifuGradientPanel4.TabIndex = 16;
            // 
            // txtMaBangDia
            // 
            this.txtMaBangDia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBangDia.Enabled = false;
            this.txtMaBangDia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMaBangDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaBangDia.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaBangDia.HintText = "";
            this.txtMaBangDia.isPassword = false;
            this.txtMaBangDia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaBangDia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaBangDia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaBangDia.LineThickness = 3;
            this.txtMaBangDia.Location = new System.Drawing.Point(198, 18);
            this.txtMaBangDia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBangDia.Name = "txtMaBangDia";
            this.txtMaBangDia.Size = new System.Drawing.Size(140, 26);
            this.txtMaBangDia.TabIndex = 29;
            this.txtMaBangDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoNgayThue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSoNgayThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoNgayThue.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoNgayThue.HintText = "";
            this.txtSoNgayThue.isPassword = false;
            this.txtSoNgayThue.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSoNgayThue.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoNgayThue.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSoNgayThue.LineThickness = 3;
            this.txtSoNgayThue.Location = new System.Drawing.Point(198, 52);
            this.txtSoNgayThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.Size = new System.Drawing.Size(197, 26);
            this.txtSoNgayThue.TabIndex = 30;
            this.txtSoNgayThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoLuongThue
            // 
            this.txtSoLuongThue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongThue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSoLuongThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuongThue.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoLuongThue.HintText = "";
            this.txtSoLuongThue.isPassword = false;
            this.txtSoLuongThue.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSoLuongThue.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoLuongThue.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSoLuongThue.LineThickness = 3;
            this.txtSoLuongThue.Location = new System.Drawing.Point(616, 18);
            this.txtSoLuongThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongThue.Name = "txtSoLuongThue";
            this.txtSoLuongThue.Size = new System.Drawing.Size(138, 26);
            this.txtSoLuongThue.TabIndex = 31;
            this.txtSoLuongThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoLuongDaTra
            // 
            this.txtSoLuongDaTra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongDaTra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSoLuongDaTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuongDaTra.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoLuongDaTra.HintText = "";
            this.txtSoLuongDaTra.isPassword = false;
            this.txtSoLuongDaTra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSoLuongDaTra.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSoLuongDaTra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSoLuongDaTra.LineThickness = 3;
            this.txtSoLuongDaTra.Location = new System.Drawing.Point(616, 52);
            this.txtSoLuongDaTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongDaTra.Name = "txtSoLuongDaTra";
            this.txtSoLuongDaTra.Size = new System.Drawing.Size(138, 26);
            this.txtSoLuongDaTra.TabIndex = 32;
            this.txtSoLuongDaTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnXoaPhieuThue
            // 
            this.btnXoaPhieuThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuThue.IconChar = FontAwesome.Sharp.IconChar.FolderMinus;
            this.btnXoaPhieuThue.IconColor = System.Drawing.Color.Black;
            this.btnXoaPhieuThue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaPhieuThue.IconSize = 25;
            this.btnXoaPhieuThue.Location = new System.Drawing.Point(12, 3);
            this.btnXoaPhieuThue.Name = "btnXoaPhieuThue";
            this.btnXoaPhieuThue.Size = new System.Drawing.Size(143, 30);
            this.btnXoaPhieuThue.TabIndex = 33;
            this.btnXoaPhieuThue.Text = "Xóa phiếu thuê";
            this.btnXoaPhieuThue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnXoaPhieuThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaPhieuThue.UseVisualStyleBackColor = true;
            this.btnXoaPhieuThue.Click += new System.EventHandler(this.btnXoaPhieuThue_Click);
            // 
            // btnXoaBangDia
            // 
            this.btnXoaBangDia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBangDia.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnXoaBangDia.IconColor = System.Drawing.Color.Black;
            this.btnXoaBangDia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaBangDia.IconSize = 25;
            this.btnXoaBangDia.Location = new System.Drawing.Point(12, 34);
            this.btnXoaBangDia.Name = "btnXoaBangDia";
            this.btnXoaBangDia.Size = new System.Drawing.Size(143, 30);
            this.btnXoaBangDia.TabIndex = 34;
            this.btnXoaBangDia.Text = "Xóa băng đĩa";
            this.btnXoaBangDia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnXoaBangDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaBangDia.UseVisualStyleBackColor = true;
            this.btnXoaBangDia.Click += new System.EventHandler(this.btnXoaBangDia_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSua.IconSize = 25;
            this.btnSua.Location = new System.Drawing.Point(12, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 30);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmXoaSuaPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXoaSuaPhieuThue";
            this.Text = "Xóa sửa phiếu thuê";
            this.Load += new System.EventHandler(this.frmXoaSuaPhieuThue_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBangDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.bunifuGradientPanel8.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSBangDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTheKH;
        private FontAwesome.Sharp.IconButton btnTimTheKH;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoNgayThue;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaBangDia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoLuongDaTra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoLuongThue;
        private FontAwesome.Sharp.IconButton btnXoaPhieuThue;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoaBangDia;
    }
}