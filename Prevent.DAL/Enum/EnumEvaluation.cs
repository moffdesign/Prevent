using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Enum
{

    public enum Probabilite
    {
        Improbable = 1,
        PeuProbable = 2,
        Probable = 3,
        Frequent = 4
    }

    public enum Gravite
    {
        Mineure = 1,
        Notable = 2,    //Moderee
        Critique = 3,
        Majeure = 4
    }

    public enum Priorite
    {
        Basse = 1,
        Moyenne = 2,
        Haute = 3
    }
}
