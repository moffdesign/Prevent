using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class PlanRisque
	{
		[ForeignKey("PlanId")]
		public int PlanId { get; set; }

		public required Plan Plan { get; set; }


		[ForeignKey("RisqueId")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }

		public int Duree { get; set; } = 0;

		public string ActionMenee { get; set; } = string.Empty;
	}
}
