using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// EmployeReference : Table de jointure entre Espace et Employe.
    /// </summary>
    public class EmployeReference
	{
		[ForeignKey("EspaceId")]
		public int EspaceId { get; set; }

		public required Espace Espace { get; set; }


		[ForeignKey("EmployeId")]
		public int EmployeId { get; set; }

		public required Employe Employe { get; set; }

		public DateTime? DebutAffectation { get; set; } = null;
        public DateTime? FinAffectation { get; set; } = null;
    }
}
