//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metro
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTheThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTheThanhVien()
        {
            this.tblPhieuThues = new HashSet<tblPhieuThue>();
        }
    
        public string maThe { get; set; }
        public string maKH { get; set; }
        public Nullable<System.DateTime> ngayHetHan { get; set; }
        public Nullable<System.DateTime> ngayCap { get; set; }
    
        public virtual tblKhachHang tblKhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuThue> tblPhieuThues { get; set; }
    }
}