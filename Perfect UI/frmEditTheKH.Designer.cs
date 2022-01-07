namespace Perfect_UI
{
    partial class frmEditTheKH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditTheKH));
            this.tblTheThanhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaThe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.errorCardProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.warningProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tickProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.onlyNumberProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notActiveProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblTheThanhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCardProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlyNumberProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notActiveProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTheThanhVienBindingSource
            // 
            this.tblTheThanhVienBindingSource.DataSource = typeof(Model.tblTheThanhVien);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaThe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTheThanhVienBindingSource, "maThe", true));
            this.txtMaThe.Enabled = false;
            this.txtMaThe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMaThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaThe.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaThe.HintText = "";
            this.txtMaThe.isPassword = false;
            this.txtMaThe.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaThe.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaThe.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaThe.LineThickness = 3;
            this.txtMaThe.Location = new System.Drawing.Point(145, 63);
            this.txtMaThe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(92, 29);
            this.txtMaThe.TabIndex = 47;
            this.txtMaThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTen.HintText = "";
            this.txtTen.isPassword = false;
            this.txtTen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTen.LineThickness = 3;
            this.txtTen.Location = new System.Drawing.Point(145, 153);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(157, 27);
            this.txtTen.TabIndex = 46;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTheThanhVienBindingSource, "maKH", true));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(145, 108);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 29);
            this.txtID.TabIndex = 45;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = "Tên khách hàng:";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblTheThanhVienBindingSource, "ngayHetHan", true));
            this.metroDateTime2.Enabled = false;
            this.metroDateTime2.Location = new System.Drawing.Point(145, 240);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(229, 29);
            this.metroDateTime2.TabIndex = 43;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblTheThanhVienBindingSource, "ngayCap", true));
            this.metroDateTime1.Enabled = false;
            this.metroDateTime1.Location = new System.Drawing.Point(145, 194);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(229, 29);
            this.metroDateTime1.TabIndex = 42;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Ngày cấp:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 250);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Ngày hết hạn:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Mã thẻ:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Mã khách hàng:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(230, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 25);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Turquoise;
            this.btnExit.Location = new System.Drawing.Point(306, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 25);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "&Thoát";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorCardProvider
            // 
            this.errorCardProvider.ContainerControl = this;
            this.errorCardProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCardProvider.Icon")));
            // 
            // warningProvider
            // 
            this.warningProvider.ContainerControl = this;
            this.warningProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("warningProvider.Icon")));
            // 
            // tickProvider
            // 
            this.tickProvider.ContainerControl = this;
            this.tickProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("tickProvider.Icon")));
            // 
            // onlyNumberProvider
            // 
            this.onlyNumberProvider.ContainerControl = this;
            this.onlyNumberProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("onlyNumberProvider.Icon")));
            // 
            // notActiveProvider
            // 
            this.notActiveProvider.ContainerControl = this;
            this.notActiveProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("notActiveProvider.Icon")));
            // 
            // frmEditTheKH
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 317);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmEditTheKH";
            this.Text = "Thông tin chi tiết";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditTheKH_FormClosing);
            this.Load += new System.EventHandler(this.frmEditTheKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTheThanhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCardProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlyNumberProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notActiveProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tblTheThanhVienBindingSource;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaThe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.ErrorProvider errorCardProvider;
        private System.Windows.Forms.ErrorProvider warningProvider;
        private System.Windows.Forms.ErrorProvider tickProvider;
        private System.Windows.Forms.ErrorProvider onlyNumberProvider;
        private System.Windows.Forms.ErrorProvider notActiveProvider;
    }
}