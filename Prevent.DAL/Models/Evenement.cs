using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Evénement survenant dans un Espace et affectant toutes les personnes référencées à cet Espace.
    /// </summary>
    public class Evenement : Entity
    {
        public DateOnly DateEvenement { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public int Gravite { get; set; } = 0;
        public int Criticite { get; set; } = 0;

        public string Preventeur { get; set; } = string.Empty;

        /// <summary>
        /// Espaces référençant l'événement courant.
        /// </summary>
        public virtual ICollection<PorteeEvenement> PorteesEvenements { get; set; } = [];

        /// <summary>
        /// Plans d'action ou de vigilance mis en oeuvre, référençant l'événement courant.
        /// </summary>
        public virtual ICollection<Plan> Plans { get; set; } = [];
    }
}
