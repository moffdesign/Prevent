using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// PorteeEvenement : Association entre un Evenement et un Espace de survenance.
    /// </summary>
    public class PorteeEvenement
    {
        [ForeignKey("EvenementId")]
        public int EvenementId { get; set; }

        public required Evenement Evenement { get; set; }


        [ForeignKey("EspacetId")]
        public int EspaceId { get; set; }

        public required Espace Espace { get; set; }
    }
}
