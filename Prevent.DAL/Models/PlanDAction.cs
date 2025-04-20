using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Plan d'action mis en place.
    /// Généralement lié à un Signalement ou un Evénement pour un Espace donné.
    /// </summary>
    public class PlanDAction : Entity
    {
        public int EspaceId { get; set; }
        public int EvenementId { get; set; }
        public int SignalementId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Espace sur lequel porte le Plan d'action
        /// Un plan d'action concerne un seul Espace de survenance. L'espace est forcément connu à défaut on met un default(Espace)
        /// </summary>
        public required Espace Espace { get; set; }

        /// <summary>
        /// Evénement référençant le plan d'action courant.
        /// Un plan d'action ne porte que sur un Evénement atomique...
        /// </summary>
        public Evenement? Evenement { get; set; }

        /// <summary>
        /// Signalement référençant le plan d'action courant.
        /// Un plan d'action ne porte que sur un Signalement atomique...
        /// </summary>
        public Signalement? Signalement { get; set; }


    }
}
