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
    
    public partial class tblPhieuThue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhieuThue()
        {
            this.tblChiTietPhieuThues = new HashSet<tblChiTietPhieuThue>();
        }
    
        public string maThe { get; set; }
        public string maPhieuThue { get; set; }
        public string maNhanVien { get; set; }
        public Nullable<System.DateTime> ngayLap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuThue> tblChiTietPhieuThues { get; set; }
        public virtual tblNhanVien tblNhanVien { get; set; }
        public virtual tblTheThanhVien tblTheThanhVien { get; set; }
    }
}
