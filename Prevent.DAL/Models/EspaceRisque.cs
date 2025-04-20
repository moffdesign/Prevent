using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class EspaceRisque
	{
		[ForeignKey("Espace")]
		public int EspaceId { get; set; }

		public required Espace Espace { get; set; }


		[ForeignKey("Risque")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }

		public int Gravite { get; set; } = 0;
		public int Criticite { get; set; } = 0;

		public string Observation { get; set; } = string.Empty;
	}
}
