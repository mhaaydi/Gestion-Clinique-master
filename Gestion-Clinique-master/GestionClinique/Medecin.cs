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
    
    public partial class Medecin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medecin()
        {
            this.Responsables = new HashSet<Responsable>();
            this.Traitements = new HashSet<Traitement>();
        }
    
        public int Id { get; set; }
        public string IdUser { get; set; }
        public int IdPatient { get; set; }
        public int IdService { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Genre { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Grade { get; set; }
        public string Fonction { get; set; }
        public string Specialite { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public System.DateTime DateRecrutement { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Service Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Responsable> Responsables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Traitement> Traitements { get; set; }
    }
}