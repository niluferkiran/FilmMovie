//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class KullaniciDiziDetay
    {
        public int KullaniciDiziDetayId { get; set; }
        public Nullable<int> DiziId { get; set; }
        public Nullable<int> KullaniciId { get; set; }
    
        public virtual Diziler Diziler { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}