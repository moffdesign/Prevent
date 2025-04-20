using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
	public class EmployeEspace
	{
		[ForeignKey("Espace")]
		public int EspaceId { get; set; }

		public required Espace Espace { get; set; }


		[ForeignKey("Employe")]
		public int EmployeId { get; set; }

		public required Employe Employe { get; set; }
	}
}
