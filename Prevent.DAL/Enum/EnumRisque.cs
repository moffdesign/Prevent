using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Enum
{
    public enum EtatSignalement
    {
        Ouvert = 1,
        Soummission = 2,
        Rejete = 3,
        Approbation = 4,
        Traitement = 5,
        Validation = 6,
        Suspension = 7,
        Cloture = 8,
        Annule = 9
    }

    //public Int16 TypePlan { get; set; } = 0; // 0 = Plan d'action, 1 = Plan de vigilance
    public enum TypePlan
    {
        PlanAction = 1,
        PlanVigilance = 2
    }

}
