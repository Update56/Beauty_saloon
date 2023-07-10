using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Code
{
    internal class Master
    {
        Qual qual;       //квалификация мастера
        Skill skill;     //умение мастера
        int remaining_time; //оставшееся время до завершения работы

        public Master(Qual qual, Skill skill, int remaining_time)
        {
            this.qual = qual;
            this.skill = skill;
            this.remaining_time = remaining_time;
        }


    }
}
