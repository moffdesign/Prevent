using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// ActiviteRisque : Activité exposant à un Risque donné (many-to-many)
    /// </summary>
    public class ActiviteRisque
	{
		[ForeignKey("ActiviteId")]
		public int ActiviteId { get; set; }

		public required Activite Activite { get; set; }


		[ForeignKey("RisqueId")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }
	}
}
