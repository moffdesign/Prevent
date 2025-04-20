using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    public class Audit : Entity
    {
        public DateTime DateDebutAudit { get; set; }
        public DateTime DateFinAudit { get; set; }
        public string NomAuditeur { get; set; }

        /// <summary>
        /// Notation: json
        /// </summary>
        public string Notation { get; set; }

        /// <summary>
        /// clef de l'Espace référencé par l'Audit.
        /// </summary>
        public int EspaceId { get; set; }

        /// <summary>
        /// un Audit porte nécessairement sur un Espace de survenance.
        /// </summary>
        public required Espace Espace { get; set; }
    }
}
