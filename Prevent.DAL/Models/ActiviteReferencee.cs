using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// ActiviteReference : Activité exercée dans un Espace donné (many-to-many)
    /// </summary>
    public class ActiviteReferencee
    {
        [ForeignKey("ActiviteId")]
        public int ActiviteId { get; set; }

        public required Activite Activite { get; set; }


        [ForeignKey("EspaceId")]
        public int EspaceId { get; set; }

        public required Espace Espace { get; set; }
    }
}
