//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhanVien()
        {
            this.tblPhieuThues = new HashSet<tblPhieuThue>();
        }
    
        public string maNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public string soCMND { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public Nullable<System.DateTime> ngaySinh { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public string avatar { get; set; }
        public Nullable<bool> trangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuThue> tblPhieuThues { get; set; }
    }
}
