using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Code
{
    enum Skill
    {
        novice,
        skilled,
        expert,
        pro
    }
    enum Qual
    {
        haircutter,
        visagiste,
        manicurist
    }
    internal class Master
    {

        Skill skill;
        Qual qual;
    }
}
