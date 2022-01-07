namespace Metro
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titSave = new MetroFramework.Controls.MetroTile();
            this.titEdit = new MetroFramework.Controls.MetroTile();
            this.titDel = new MetroFramework.Controls.MetroTile();
            this.titAdd = new MetroFramework.Controls.MetroTile();
            this.titRefesh = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titSave
            // 
            this.titSave.ActiveControl = null;
            this.titSave.Location = new System.Drawing.Point(411, 72);
            this.titSave.Name = "titSave";
            this.titSave.Size = new System.Drawing.Size(91, 63);
            this.titSave.TabIndex = 4;
            this.titSave.Text = "Save";
            this.titSave.TileImage = global::Metro.Properties.Resources.iconfinder_Multimedia_Save_download_disk_guardar_interface_3841801;
            this.titSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titSave.UseSelectable = true;
            this.titSave.UseTileImage = true;
            this.titSave.Click += new System.EventHandler(this.titSave_Click);
            // 
            // titEdit
            // 
            this.titEdit.ActiveControl = null;
            this.titEdit.Location = new System.Drawing.Point(217, 72);
            this.titEdit.Name = "titEdit";
            this.titEdit.Size = new System.Drawing.Size(91, 63);
            this.titEdit.TabIndex = 3;
            this.titEdit.Text = "Edit";
            this.titEdit.TileImage = global::Metro.Properties.Resources.iconfinder_edit_3855617;
            this.titEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titEdit.UseSelectable = true;
            this.titEdit.UseTileImage = true;
            this.titEdit.Click += new System.EventHandler(this.titEdit_Click);
            // 
            // titDel
            // 
            this.titDel.ActiveControl = null;
            this.titDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titDel.Location = new System.Drawing.Point(314, 72);
            this.titDel.Name = "titDel";
            this.titDel.Size = new System.Drawing.Size(91, 63);
            this.titDel.TabIndex = 2;
            this.titDel.Text = "Delete";
            this.titDel.TileImage = global::Metro.Properties.Resources.iconfinder_delete_372214;
            this.titDel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titDel.UseSelectable = true;
            this.titDel.UseTileImage = true;
            this.titDel.Click += new System.EventHandler(this.titDel_Click);
            // 
            // titAdd
            // 
            this.titAdd.ActiveControl = null;
            this.titAdd.Location = new System.Drawing.Point(120, 72);
            this.titAdd.Name = "titAdd";
            this.titAdd.Size = new System.Drawing.Size(91, 63);
            this.titAdd.TabIndex = 1;
            this.titAdd.Text = "Add";
            this.titAdd.TileImage = global::Metro.Properties.Resources.iconfinder_Add_728898;
            this.titAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titAdd.UseSelectable = true;
            this.titAdd.UseTileImage = true;
            this.titAdd.Click += new System.EventHandler(this.titAdd_Click);
            // 
            // titRefesh
            // 
            this.titRefesh.ActiveControl = null;
            this.titRefesh.Location = new System.Drawing.Point(23, 72);
            this.titRefesh.Name = "titRefesh";
            this.titRefesh.Size = new System.Drawing.Size(91, 63);
            this.titRefesh.TabIndex = 0;
            this.titRefesh.Text = "Refesh";
            this.titRefesh.TileImage = global::Metro.Properties.Resources.iconfinder_arrow_cycle_15178;
            this.titRefesh.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titRefesh.UseSelectable = true;
            this.titRefesh.UseTileImage = true;
            this.titRefesh.Click += new System.EventHandler(this.titRefesh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.soCMNDDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNhanVienBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 157);
            this.dataGridView1.TabIndex = 5;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "maNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "tenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            // 
            // soCMNDDataGridViewTextBoxColumn
            // 
            this.soCMNDDataGridViewTextBoxColumn.DataPropertyName = "soCMND";
            this.soCMNDDataGridViewTextBoxColumn.HeaderText = "Số CMND";
            this.soCMNDDataGridViewTextBoxColumn.Name = "soCMNDDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "soDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "taiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "matKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataSource = typeof(Metro.tblNhanVien);
            // 
            // tblNhanVienBindingSource1
            // 
            this.tblNhanVienBindingSource1.DataSource = typeof(Metro.tblNhanVien);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titSave);
            this.Controls.Add(this.titEdit);
            this.Controls.Add(this.titDel);
            this.Controls.Add(this.titAdd);
            this.Controls.Add(this.titRefesh);
            this.Name = "Form1";
            this.Text = "Staff Manage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile titRefesh;
        private MetroFramework.Controls.MetroTile titAdd;
        private MetroFramework.Controls.MetroTile titDel;
        private MetroFramework.Controls.MetroTile titEdit;
        private MetroFramework.Controls.MetroTile titSave;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource1;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
    }
}

