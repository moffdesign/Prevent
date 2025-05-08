using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// PreventionReferencee : Table de jointure entre Espace et Prevention.
    /// </summary>
    public class PreventionReferencee
	{
		[ForeignKey("EspaceId")]
		public int EspaceId { get; set; }

		public required Espace Espace { get; set; }


		[ForeignKey("PreventionId")]
		public int PreventionId { get; set; }

		public required Prevention Prevention { get; set; }
	}
}
