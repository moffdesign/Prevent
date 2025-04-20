using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class PlanPreventionRisque
	{
		[ForeignKey("PlanPrevention")]
		public int PlanPreventionId { get; set; }

		public required PlanPrevention PlanPrevention { get; set; }


		[ForeignKey("Risque")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }

		public int Duree { get; set; } = 0;

		public string ActionMenee { get; set; } = string.Empty;
	}
}
