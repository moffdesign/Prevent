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
    public class Prevention : Entity
    {
		/// <summary>
		/// Les Risques référençant la Mesure de Prévention.
		/// </summary>
		public virtual ICollection<PreventionRisque> PreventionsRisques { get; set; } = [];

		/// <summary>
		/// Les Espaces référençant la Mesure de Prévention.
		/// </summary>
		public virtual ICollection<PreventionReferencee> PreventionsReferencees { get; set; } = [];
    }
}
