//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsTakipSistemi.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Cagri
    {
        public int ID_CAGRI { get; set; }
        public int FIRMA_ID { get; set; }
        public string KONU { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<bool> CAGRI_DURUM { get; set; }
    
        public virtual tbl_Firmalar tbl_Firmalar { get; set; }
    }
}