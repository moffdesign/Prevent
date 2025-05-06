using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    public class Signalement : Entity
    {
        public DateTime DateSiglmt { get; set; }
        public int Gravite { get; set; }
        public int Priorité { get; set; }
        public bool IsUrgence { get; set; } = false;

        public string? Geolocalisation { get; set; }
        public string? Photos { get; set; }

        public string? AuteurSiglmt { get; set; }
        public string? Destinataire { get; set; }
        public string? Description { get; set; }

        public enum EtatSignalement
        {
            Ouvert = 1,
            Soummis = 2,
            Recu = 3,
            EnTraitement = 4,
            AttenteValidation = 5,
            Cloture = 6,
            Annule = 9
        }

        public EtatSignalement Etat { get; set; } = EtatSignalement.Ouvert;
        public string? Commentaires { get; set; }

        public bool IsRequalifie { get; set; } = false;
        public string? Requalification { get; set; }    // plan de vigilance ou plan d'action

        /// <summary>
        /// Espace de survenance de rattachement.
        /// </summary>
        public int EspaceId { get; set; }

        /// <summary>
        /// Un Signalement porte un seul Espace de survenance. L'espace est forcément connu à défaut on met un default(Espace)
        /// </summary>
        public required Espace Espace { get; set; }
    }
}
