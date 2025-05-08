using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Activité
    /// </summary>
    public class Activite : Entity
    {
		/// <summary>
		/// ActivitesRisques : Risques liés à l'Activité (many-to-many)
		/// Une même Activité peut exposer à plusieurs risques.
		/// </summary>
		public virtual ICollection<ActiviteRisque> ActivitesRisques { get; set; } = [];

        /// <summary>
        /// ActivitesReferences : Les Espaces où cette activité est pratiquée.
        /// </summary>
        public virtual ICollection<ActiviteReference> ActivitesReferences { get; set; } = [];
    }
}
