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
    
    public partial class tblPhieuBanHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPhieuBanHang()
        {
            this.tblChiTietPhieuBanHangs = new HashSet<tblChiTietPhieuBanHang>();
        }
    
        public int iSoPhieu { get; set; }
        public Nullable<System.DateTime> dThoiGianBan { get; set; }
        public string sMaNV { get; set; }
        public string sMaKH { get; set; }
        public string sKieuGiaoDich { get; set; }
        public Nullable<float> fGiamGia { get; set; }
    
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual tblNhanVien tblNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuBanHang> tblChiTietPhieuBanHangs { get; set; }
    }
}