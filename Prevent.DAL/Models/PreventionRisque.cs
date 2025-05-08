using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// PreventionRisque : Association entre une Prevention et un Risque (Many-to-Many).
    /// </summary>
    public class PreventionRisque
	{
		[ForeignKey("PreventionId")]
		public int PreventionId { get; set; }

		public required Prevention Prevention { get; set; }


		[ForeignKey("RisqueId")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }
	}
}
