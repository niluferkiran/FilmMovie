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
    
    public partial class KullaniciFilmDetay
    {
        public int KullaniciFilmDetayId { get; set; }
        public Nullable<int> FilmId { get; set; }
        public Nullable<int> KullaniciId { get; set; }
    
        public virtual Filmler Filmler { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
