using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Code
{
    enum Qual //перечисление квалификаций
    {
        haircutter,
        visagiste,
        manicurist
    }
    enum Skill //перечисление мастерства
    {
        novice,
        skilled,
        expert,
        pro
    }
    
    internal class Saloon
    {
        public Saloon() { }

        static private int seed; //ключ генератора???
        private int amount_masters; //количество мастеров
        List<Customer> customers = new List<Customer>();
        public int Seed
        {
            get { return seed; }
            set { seed = value; }
        }
        public int Amount_masters 
        {
            get { return amount_masters; } 
            set { amount_masters = value; } 
        }

        static Random rnd = new Random(seed);
        void Creting_masters()
        {
            for (int i = 0; i < amount_masters; i++)
            {
                customers.Add(new Customer((Qual)rnd.Next(0, 2), (Skill)rnd.Next(0, 3), rnd.Next(20, 60)));
            }
        }        
    }
}
