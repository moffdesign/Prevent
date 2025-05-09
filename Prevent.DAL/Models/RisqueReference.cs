using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// RisqueReference : Référence entre un Espace et un Risque.
	/// Risque référencé à un Espace de survenance.
    /// </summary>
    public class RisqueReference
	{
		[ForeignKey("EspaceId")]
		public int EspaceId { get; set; }

		public required Espace Espace { get; set; }


		[ForeignKey("RisqueId")]
		public int RisqueId { get; set; }

		public required Risque Risque { get; set; }

		public int Probabilite { get; set; } = 0;
		public int Gravite { get; set; } = 0;
		public int Criticite { get; set; } = 0;

		public bool EstPermanent { get; set; } = false;
		public DateTime? DateDebut { get; set; } = null;
        public DateTime? DateFin { get; set; } = null;
		        
		public DateTime DateEvaluation { get; set; } = DateTime.Now;
        public string Preventeur { get; set; } = string.Empty;

        public string Observation { get; set; } = string.Empty;
    }
}
