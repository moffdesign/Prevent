using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Espace de survenance délimité et localisé qui accueille des Employés.
    /// Un Espace peut être un poste de travail, un Service, un Atelier, un Parc, etc, 
    ///  soit tout endroit recevant des personnes pouvant être exposées à un risque potentiel.
    /// </summary>
    public class Espace : Entity
    {
        //public string LibelleEspace { get; set; }
        public int Rang { get; set; } = 0;  //pour les renumerotations
		public string? Localisation { get; set; }
        public string? GPS { get; set; }

        public string? Positionnement { get; set; }
        public string? LiensExternes { get; set; }
        public string? LiensInternes { get; set; } 
        public DateTime? DateDebutOuverture { get; set; }
        public DateTime? DateFermeture { get; set; }
        public string? Commentaires { get; set; }
        public string? Description { get; set; }

        /// <summary>
        /// Employés de l'Espace : Plusieurs employés peuvent être affectés au même Espace.
        /// </summary>
        public ICollection<EmployeEspace>? EmployeEspaces { get; set; } 

        /// <summary>
        /// Risques auxquels est exposés l'Espace.
        /// </summary>
        public ICollection<RisqueReference>? EspaceRisques { get; set; } 

        /// <summary>
        /// Mesures de Prévention référencées pour l'Espace courant (Espace+Risque -> Prevention)
        /// Uniquement les Mesures de Prévention retenues pour l'espace courant.
        /// </summary>
        public ICollection<EspacePrevention>? EspacePreventions { get; set; }

        /// <summary>
        /// Activités de l'Espace 
        /// Plusieurs Activités peuvent être exercées dans un même Espace.
        /// </summary>
        public ICollection<Activite>? Activites { get; set; }

        /// <summary>
        /// Signalements référençant l'Espace de survenance.
        /// </summary>
        public ICollection<Signalement>? Signalements { get; set; }

        /// <summary>
        /// Evénements référençant l'Espace de survenance.
        /// </summary>
        public ICollection<Evenement>? Evenements { get; set; }

        /// <summary>
        /// Plans d'action référençant l'Espace de survenance.
        /// </summary>
        public ICollection<PlanAction>? PlanActions { get; set; }

        /// <summary>
        /// Audits référençant l'Espace de survenance. 
        /// Un espace peut être audité autant de fois que nécessaire pour améliorer la sécurité.
        /// </summary>
        public ICollection<Audit>? Audits { get; set; }
    }
}
