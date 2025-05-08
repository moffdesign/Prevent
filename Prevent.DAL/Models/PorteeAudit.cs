using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// PorteeAudit : Association entre un Audit et un Espace de survenance.
    /// la dimension de l'Audit sera alors le nbr d'espaces adressés par l'Audit.
    /// </summary>
    public class PorteeAudit
    {
        [ForeignKey("AuditId")]
        public int AuditId { get; set; }

        public required Audit Audit { get; set; }


        [ForeignKey("EspacetId")]
        public int EspaceId { get; set; }

        public required Espace Espace { get; set; }
    }
}
