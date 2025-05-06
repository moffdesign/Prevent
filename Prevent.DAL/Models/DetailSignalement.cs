using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    public class DetailSignalement : Entity
    {
        /// <summary>
        /// Signalement
        /// </summary>
        public int SignalementId { get; set; }

        /// <summary>
        /// Signalement
        /// </summary>
        public required Signalement Signalement { get; set; }

        public string? LigneDetail { get; set; }
        public string? Commentaires { get; set; }

    }
}
