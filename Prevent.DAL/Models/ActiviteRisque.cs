using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class ActiviteRisque
	{
		[ForeignKey("Activite")]
		public int ActiviteId { get; set; }

		public required Activite Activite { get; set; }


		[ForeignKey("Risque")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }
	}
}
