using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Mesures de Prévention associées à un ou plusieurs Risques.
    /// </summary>
    public class MesurePrevention : Entity
    {
		/// <summary>
		/// Les Risques référençant la Mesure de Prévention.
		/// </summary>
		public virtual ICollection<RisquePrevention> RisquePreventions { get; set; }

		/// <summary>
		/// Les Espaces référençant la Mesure de Prévention.
		/// </summary>
		public ICollection<EspacePrevention> EspacePreventions { get; set; } 
    }
}
