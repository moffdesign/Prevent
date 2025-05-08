using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prevent.DAL.Models
{
    /// <summary>
    /// Employé tant interne que externe pouvant être affecté à un Espace de survenance.
    /// </summary>
    public class Employe : Entity
    {
        [StringLength(50, MinimumLength = 3)]
        public required string Nom { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public required string Prenom { get; set; }
        public string? Patronime { get; set; }
        public string? Initiales { get; set; }
        public string? Civilites { get; set; }
        public DateOnly DateNaissance { get; set; }
        public string? LieuNaissance { get; set; }
        public Int16 Sexe { get; set; }     //1:Homme 2:Femme 3:Autre 4:Inconnu
        public string? Adresse { get; set; }
        public string? Complement { get; set; }
        public string? Localite { get; set; }
        public string? CodePostal { get; set; }
        public string? Pays { get; set; }
        public string? Telephone { get; set; }
        public string? Portable { get; set; }
        public string? Email { get; set; }
        public string? Matricule { get; set; }
        public string? INSEE { get; set; }
        public string? Nationalite { get; set; } 
        public bool PermisDeCon { get; set; } = false;
        public DateOnly DatePermis { get; set; }
        public int SituationMaritale { get; set; } = 0;
        public byte[] Photo { get; set; } = []; //TODO: Convertir en image


        public override string Libelle { get => Nom + " " + Prenom; }

        /// <summary>
        /// EmployesReferences : Espaces où exerce l'Employé.
        /// Un employé peut travailler ou être affecté dans plus d'un espace
        /// </summary>
        public ICollection<EmployeReference> EmployesReferences { get; set; } = [];
    }
}
