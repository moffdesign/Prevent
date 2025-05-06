using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class RisquePrevention
	{
		[ForeignKey("Prevention")]
		public int PreventionId { get; set; }

		public required MesurePrevention MesurePrevention { get; set; }


		[ForeignKey("Risque")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }
	}
}
