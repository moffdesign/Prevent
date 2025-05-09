using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prevent.DAL.Enum;

namespace Prevent.DAL.Models
{
    public class Signalement : Entity
    {
        public DateTime DateSiglmt { get; set; }

        //public int Gravite { get; set; }
        public Gravite Gravite { get; set; } = Gravite.Mineure;

        //public int Priorité { get; set; }
        public Priorite Priorite { get; set; } = Priorite.Basse;

        public bool IsUrgence { get; set; } = false;

        public string? Geolocalisation { get; set; }
        public string? Photos { get; set; }

        public string? AuteurSiglmt { get; set; }
        public string? Destinataire { get; set; }
        public string? Description { get; set; }

        
        public EtatSignalement Etat { get; set; } = EtatSignalement.Ouvert;
        public string? Commentaires { get; set; }

        public bool IsRequalifie { get; set; } = false;
        public string? Requalification { get; set; }    // plan de vigilance ou plan d'action

        public string Preventeur { get; set; } = string.Empty;

        /// <summary>
        /// Espace de survenance de rattachement.
        /// </summary>
        [ForeignKey("EspaceId")]
        public int EspaceId { get; set; }

        /// <summary>
        /// Un Signalement porte un seul Espace de survenance. L'espace est forcément connu à défaut on met un default(Espace)
        /// </summary>
        public required Espace Espace { get; set; }

        public virtual ICollection<Plan> Plans { get; set; } = [];
    }
}
