//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class HH_NHOM_VTHH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HH_NHOM_VTHH()
        {
            this.HHs = new HashSet<HH>();
            this.HHs1 = new HashSet<HH>();
            this.HH_BANG_GIA_BAN = new HashSet<HH_BANG_GIA_BAN>();
            this.HH_BANG_GIA_BAN1 = new HashSet<HH_BANG_GIA_BAN>();
            this.HH_NHOM_VTHH1 = new HashSet<HH_NHOM_VTHH>();
            this.NCC_LOAI_HANG_CUNG_CAP = new HashSet<NCC_LOAI_HANG_CUNG_CAP>();
            this.KH_POLICY = new HashSet<KH_POLICY>();
            this.MH_YEU_CAU_HOI_GIA = new HashSet<MH_YEU_CAU_HOI_GIA>();
            this.TONKHO_HANG = new HashSet<TONKHO_HANG>();
        }
    
        public string MA_NHOM_HANG_CHI_TIET { get; set; }
        public string CHUNG_LOAI_HANG { get; set; }
        public string MA_NHOM_HANG_CHA { get; set; }
        public string GHI_CHU { get; set; }
        public string MARK_PHU_TRACH { get; set; }
        public string PURC_PHU_TRACH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH> HHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH> HHs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_BANG_GIA_BAN> HH_BANG_GIA_BAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_BANG_GIA_BAN> HH_BANG_GIA_BAN1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_NHOM_VTHH> HH_NHOM_VTHH1 { get; set; }
        public virtual HH_NHOM_VTHH HH_NHOM_VTHH2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NCC_LOAI_HANG_CUNG_CAP> NCC_LOAI_HANG_CUNG_CAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KH_POLICY> KH_POLICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_YEU_CAU_HOI_GIA> MH_YEU_CAU_HOI_GIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO_HANG> TONKHO_HANG { get; set; }
    }
}
