using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Code
{
    internal class Customer
    {
        Qual service;     //тип услуги
        Skill difficulty; //сложность услуги
        int time;         //время оказания услуги
        
        public Customer(Qual service, Skill difficulty, int time) //конструктор
        {
            this.service = service;
            this.difficulty = difficulty;
            this.time = time;
        }

    }
}
