//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OBS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.DersSecmes = new HashSet<DersSecme>();
            this.Not_ = new HashSet<Not_>();
        }
    
        public string OgrNo { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTar { get; set; }
        public string OgrTelNo { get; set; }
        public string Sinif { get; set; }
        public string OgrResim { get; set; }
        public string OgrMail { get; set; }
        public string OgrSifre { get; set; }
        public string DanismanID { get; set; }
        public Nullable<int> BolumID { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public string OgrYetkiID { get; set; }
    
        public virtual Bolum Bolum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DersSecme> DersSecmes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Not_> Not_ { get; set; }
        public virtual OgretimElemani OgretimElemani { get; set; }
        public virtual OgrenciIsleri OgrenciIsleri { get; set; }
    }
}
