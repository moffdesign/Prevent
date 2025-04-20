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
        public bool UrgenceSignalee { get; set; } = false;

        public string Geolocalisation { get; set; }
        public string Photos { get; set; }

        public string AuteurSiglmt { get; set; }
        public string Description { get; set; }

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
