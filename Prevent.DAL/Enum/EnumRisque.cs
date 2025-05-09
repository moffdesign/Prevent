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
        Soummis = 2,
        Recu = 3,
        EnTraitement = 4,
        AttenteValidation = 5,
        Cloture = 6,
        Annule = 9
    }

    //public Int16 TypePlan { get; set; } = 0; // 0 = Plan d'action, 1 = Plan de vigilance
    public enum TypePlan
    {
        PlanAction = 1,
        PlanVigilance = 2
    }

}
