using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Models
{
    /// <summary>
    /// Evénement survenant dans un Espace et affectant toutes les personnes référencées à cet Espace.
    /// </summary>
    public class Evenement : Entity
    {
        public int EspaceId { get; set; }
        public required Espace Espace { get; set; }
    }
}
