using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	/// <summary>
	/// Plan de prévention
	/// Récurrent, ils servent généralement à réduire la possibilité de survenance d'un risque potentiel dans un espace donné.
	/// Ils se distinguent des plans d'action à ceci qu'ils sont préventifs et ont une fréquence d'action permanente.
	/// </summary>
	public class PlanVigilance : Plan
	{
		public int Frequence { get; set; }
		
		/// <summary>
		/// Risque objet du plan de prévention
		/// </summary>
		public virtual ICollection<PlanVigilanceRisque> PlanVigilanceRisques { get; set; } = [];
	}
}
