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
    
    public partial class QUY_CT_PHIEU_THU
    {
        public int ID { get; set; }
        public string SO_CHUNG_TU { get; set; }
        public string DIEN_GIAI { get; set; }
        public string LOAI_TIEN { get; set; }
        public decimal TY_GIA { get; set; }
        public string TK_NO { get; set; }
        public string TK_CO { get; set; }
        public decimal SO_TIEN { get; set; }
        public decimal QUY_DOI { get; set; }
        public string DOI_TUONG { get; set; }
        public string TK_NGAN_HANG { get; set; }
    
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN1 { get; set; }
        public virtual QUY_PHIEU_THU QUY_PHIEU_THU { get; set; }
    }
}
