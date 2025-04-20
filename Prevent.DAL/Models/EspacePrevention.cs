using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class EspacePrevention
	{
		[ForeignKey("Espace")]
		public int EspaceId { get; set; }

		public required Espace Espace { get; set; }


		[ForeignKey("Prevention")]
		public int PreventionId { get; set; }

		public required MesurePrevention Prevention { get; set; }
	}
}
