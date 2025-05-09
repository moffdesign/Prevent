using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prevent.DAL.Enum;

namespace Prevent.DAL.Models
{
    public class Plan : Entity
    {
        
        public TypePlan Type { get; set; } = TypePlan.PlanAction;

        public int Frequence { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        [ForeignKey("EvenementId")]
        public int? EvenementId { get; set; }
        /// <summary>
        /// Evénement référençant le plan d'action courant.
        /// Un plan d'action ne porte que sur un Evénement atomique...
        /// </summary>
        public Evenement? Evenement { get; set; }

        [ForeignKey("SignalementId")]
        public int? SignalementId { get; set; }
        /// <summary>
        /// Signalement référençant le plan d'action courant.
        /// Un plan d'action ne porte que sur un Signalement atomique...
        /// </summary>
        public Signalement? Signalement { get; set; }

        /// <summary>
        /// Espaces référençant le plan.
        /// </summary>
        public virtual ICollection<PorteePlan> PorteesPlans { get; set; } = [];
    }
}
