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
	public class PlanPrevention : Entity
	{
		public int EspaceId { get; set; }

		public DateTime DateDebut { get; set; }

		public int Frequence { get; set; }
		public DateTime DateFin { get; set; }

		/// <summary>
		/// Espace sur lequel porte le Plan de prévention
		/// Un plan de prévention concerne un seul Espace de survenance. L'espace est forcément connu à défaut on met un default(Espace)
		/// </summary>
		public required Espace Espace { get; set; }

		/// <summary>
		/// Risque objet du plan de prévention
		/// </summary>
		public virtual ICollection<PlanPreventionRisque> PlanPreventionRisques { get; set; } = [];
	}
}
