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
    
    public partial class POST_CATEGORIES
    {
        public int ID { get; set; }
        public string MA_DANH_MUC { get; set; }
        public int MA_BAI_VIET { get; set; }
    
        public virtual CATEGORy CATEGORy { get; set; }
        public virtual POST POST { get; set; }
    }
}
