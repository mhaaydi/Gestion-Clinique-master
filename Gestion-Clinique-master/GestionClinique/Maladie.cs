//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionClinique
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maladie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maladie()
        {
            this.Traitements = new HashSet<Traitement>();
        }
    
        public int Id { get; set; }
        public string Famille { get; set; }
        public string SousFamille { get; set; }
        public string Designation { get; set; }
        public double Prix { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Traitement> Traitements { get; set; }
    }
}