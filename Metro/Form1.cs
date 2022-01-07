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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        QuanLyBangDiaEntities1 db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new QuanLyBangDiaEntities1();
            tblNhanVienBindingSource.DataSource = db.tblNhanViens.ToList();
        }

        private async void titEdit_Click(object sender, EventArgs e)
        {
            tblNhanVien obj = tblNhanVienBindingSource.Current as tblNhanVien;
            if (obj != null)
            {
                using(frmStaff_Info frm = new frmStaff_Info(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tblNhanVienBindingSource.EndEdit();
                            await db.SaveChangesAsync();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void titAdd_Click(object sender, EventArgs e)
        {
            using (frmStaff_Info frm = new frmStaff_Info(new tblNhanVien() { gioiTinh = "Nam" }))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tblNhanVienBindingSource.Add(frm.NhanVienInfo);
                        db.tblNhanViens.Add(frm.NhanVienInfo);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void titRefesh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tblNhanVienBindingSource.DataSource = db.tblNhanViens.ToList();
            Cursor.Current = Cursors.Default;
        }

        private async void titSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this,"Lưu thay đổi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblNhanVienBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void titDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridView1.RowCount;
                for (int i = rows - 1; i>= 0; i--)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        db.tblNhanViens.Remove(dataGridView1.Rows[i].DataBoundItem as tblNhanVien);
                        tblNhanVienBindingSource.RemoveAt(dataGridView1.Rows[i].Index);
                    }
                }
                this.titRefesh_Click(sender, e);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.titEdit_Click(sender, e);
        }
    }
}
