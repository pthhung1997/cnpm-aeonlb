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
    
    public partial class tblNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhanVien()
        {
            this.tblNhapKhoes = new HashSet<tblNhapKho>();
            this.tblPhieuBanHangs = new HashSet<tblPhieuBanHang>();
            this.tblYeuCauNhapKhoes = new HashSet<tblYeuCauNhapKho>();
        }
    
        public string sMaNV { get; set; }
        public string sHoTenNV { get; set; }
        public string sChucVu { get; set; }
        public string sTenDangNhap { get; set; }
        public string sMatKhau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNhapKho> tblNhapKhoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPhieuBanHang> tblPhieuBanHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblYeuCauNhapKho> tblYeuCauNhapKhoes { get; set; }
    }
}
