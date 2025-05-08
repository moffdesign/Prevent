using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// PorteePlan : Association entre un Plan et un Espace de survenance.
    /// </summary>
    public class PorteePlan
    {
        [ForeignKey("PlanId")]
        public int PlanId { get; set; }

        public required Plan Plan { get; set; }


        [ForeignKey("EspacetId")]
        public int EspaceId { get; set; }

        public required Espace Espace { get; set; }
    }
}
