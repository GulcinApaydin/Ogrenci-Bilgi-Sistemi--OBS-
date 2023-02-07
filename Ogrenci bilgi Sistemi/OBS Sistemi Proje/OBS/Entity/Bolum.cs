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
    
    public partial class Bolum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bolum()
        {
            this.Ders = new HashSet<Der>();
            this.Ogrencis = new HashSet<Ogrenci>();
            this.DersSecmes = new HashSet<DersSecme>();
        }
    
        public int BolumID { get; set; }
        public string BolumAd { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<int> FakulteID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Der> Ders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogrenci> Ogrencis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DersSecme> DersSecmes { get; set; }
        public virtual Fakulte Fakulte { get; set; }
        public virtual OgrenciIsleri OgrenciIsleri { get; set; }
    }
}
