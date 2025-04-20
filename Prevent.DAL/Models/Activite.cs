using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Activité exercée dans un Espace de survenance
    /// </summary>
    public class Activite : Entity
    {
        /// <summary>
        /// ID de l'Espace
        /// </summary>
        public int EspaceId { get; set; }

        /// <summary>
        /// Espace où est exercée cette Activité.
        /// </summary>
        public Espace Espace { get; set; }

		/// <summary>
		/// ActiviteRisques : Risques liés à l'Activité (many-to-many)
		/// Une même Activité peut exposer à plusieurs risques.
		/// </summary>
		public virtual ICollection<ActiviteRisque> ActiviteRisques { get; set; } 
    }
}
