//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_PHAN_HOI_PHAN_MEM
    {
        public int ID { get; set; }
        public string NHAN_VIEN_PHAN_HOI { get; set; }
        public System.DateTime NGAY_PHAN_HOI { get; set; }
        public string THONG_TIN_PHAN_HOI { get; set; }
        public bool THONG_TIN_PHAN_HOI_TOT { get; set; }
        public bool THONG_TIN_PHAN_HOI_TRUNG_BINH { get; set; }
        public bool THONG_TIN_PHAN_HOI_KHONG_TOT { get; set; }
        public bool THONG_TIN_PHAN_HOI_LUNG_TUNG { get; set; }
        public string NGUOI_DUYET { get; set; }
        public Nullable<System.DateTime> NGAY_DUYET { get; set; }
        public int TINH_DIEM { get; set; }
    
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG1 { get; set; }
    }
}
