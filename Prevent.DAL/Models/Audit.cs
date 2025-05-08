using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Audit : Audit de sécurité.
    /// </summary>
    public class Audit : Entity
    {
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string? NomAuditeur { get; set; }

        /// <summary>
        /// Notation: json
        /// </summary>
        public string? Notation { get; set; }

        /// <summary>
        /// Espaces référençés par l'Audit.
        /// Un audit peur porter sur plus d'un espace de survenance
        /// </summary>
        public virtual ICollection<PorteeAudit> PorteesAudits { get; set; } = [];
    }
}
