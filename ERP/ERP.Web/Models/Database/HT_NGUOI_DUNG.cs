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
    
    public partial class HT_NGUOI_DUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HT_NGUOI_DUNG()
        {
            this.BH_DON_HANG_PO = new HashSet<BH_DON_HANG_PO>();
            this.BH_PHUONG_AN_KINH_DOANH = new HashSet<BH_PHUONG_AN_KINH_DOANH>();
            this.CN_NGHIEP_VU_NHAN_VIEN = new HashSet<CN_NGHIEP_VU_NHAN_VIEN>();
            this.COMMENTS_CONG_NO_KH = new HashSet<COMMENTS_CONG_NO_KH>();
            this.HH_COMMENTS = new HashSet<HH_COMMENTS>();
            this.HH_HANG_DUOC_QUAN_TAM = new HashSet<HH_HANG_DUOC_QUAN_TAM>();
            this.HT_CONG_VIEC_NHAN_VIEN = new HashSet<HT_CONG_VIEC_NHAN_VIEN>();
            this.HT_CONG_VIEC_NHAN_VIEN1 = new HashSet<HT_CONG_VIEC_NHAN_VIEN>();
            this.HT_LICH_SU_DANG_NHAP = new HashSet<HT_LICH_SU_DANG_NHAP>();
            this.HT_PHAN_HOI_PHAN_MEM = new HashSet<HT_PHAN_HOI_PHAN_MEM>();
            this.HT_PHAN_HOI_PHAN_MEM1 = new HashSet<HT_PHAN_HOI_PHAN_MEM>();
            this.KH_CONG_NO = new HashSet<KH_CONG_NO>();
            this.KH_POLICY = new HashSet<KH_POLICY>();
            this.MH_DE_NGHI_NHAP_KHO = new HashSet<MH_DE_NGHI_NHAP_KHO>();
            this.MH_HANG_CAN_DAT = new HashSet<MH_HANG_CAN_DAT>();
            this.MH_PO_MUA_HANG = new HashSet<MH_PO_MUA_HANG>();
            this.NH_NTTK = new HashSet<NH_NTTK>();
            this.NH_UNC = new HashSet<NH_UNC>();
            this.NH_NTTK1 = new HashSet<NH_NTTK>();
            this.NH_UNC1 = new HashSet<NH_UNC>();
            this.NOTIFICATIONS = new HashSet<NOTIFICATION>();
            this.POST_COMMENTS = new HashSet<POST_COMMENTS>();
            this.POST_KINHDOANH = new HashSet<POST_KINHDOANH>();
            this.QUY_PHIEU_CHI = new HashSet<QUY_PHIEU_CHI>();
            this.QUY_PHIEU_THU = new HashSet<QUY_PHIEU_THU>();
            this.QUY_PHIEU_CHI1 = new HashSet<QUY_PHIEU_CHI>();
            this.QUY_PHIEU_THU1 = new HashSet<QUY_PHIEU_THU>();
        }
    
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string HO_VA_TEN { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public string AVATAR { get; set; }
        public Nullable<bool> IS_ADMIN { get; set; }
        public bool ALLOWED { get; set; }
        public string MA_CONG_TY { get; set; }
        public string MA_XAC_NHAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_DON_HANG_PO> BH_DON_HANG_PO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_PHUONG_AN_KINH_DOANH> BH_PHUONG_AN_KINH_DOANH { get; set; }
        public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CN_NGHIEP_VU_NHAN_VIEN> CN_NGHIEP_VU_NHAN_VIEN { get; set; }
        public virtual CN_NHOM_NGUOI_DUNG_NGHIEP_VU CN_NHOM_NGUOI_DUNG_NGHIEP_VU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENTS_CONG_NO_KH> COMMENTS_CONG_NO_KH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_COMMENTS> HH_COMMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH_HANG_DUOC_QUAN_TAM> HH_HANG_DUOC_QUAN_TAM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HT_CONG_VIEC_NHAN_VIEN> HT_CONG_VIEC_NHAN_VIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HT_CONG_VIEC_NHAN_VIEN> HT_CONG_VIEC_NHAN_VIEN1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HT_LICH_SU_DANG_NHAP> HT_LICH_SU_DANG_NHAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HT_PHAN_HOI_PHAN_MEM> HT_PHAN_HOI_PHAN_MEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HT_PHAN_HOI_PHAN_MEM> HT_PHAN_HOI_PHAN_MEM1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KH_CONG_NO> KH_CONG_NO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KH_POLICY> KH_POLICY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_DE_NGHI_NHAP_KHO> MH_DE_NGHI_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_HANG_CAN_DAT> MH_HANG_CAN_DAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_PO_MUA_HANG> MH_PO_MUA_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_NTTK> NH_NTTK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_UNC> NH_UNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_NTTK> NH_NTTK1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_UNC> NH_UNC1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST_COMMENTS> POST_COMMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POST_KINHDOANH> POST_KINHDOANH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_PHIEU_CHI> QUY_PHIEU_CHI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_PHIEU_THU> QUY_PHIEU_THU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_PHIEU_CHI> QUY_PHIEU_CHI1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_PHIEU_THU> QUY_PHIEU_THU1 { get; set; }
    }
}