//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aeonlb.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblYeuCauNhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblYeuCauNhapKho()
        {
            this.tblChiTietYeuCauNhaps = new HashSet<tblChiTietYeuCauNhap>();
        }
    
        public string sMaYeuCauNhapKho { get; set; }
        public string sMaNV { get; set; }
        public System.DateTime dThoiGianYeuCau { get; set; }
        public string sTrangThaiYeuCau { get; set; }
    
        public virtual tblNhanVien tblNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietYeuCauNhap> tblChiTietYeuCauNhaps { get; set; }
    }
}
