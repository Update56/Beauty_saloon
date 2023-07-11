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

        List<Customer> customers = new List<Customer>();
        List<Master> masters = new List<Master>();
        Random rnd = new Random();
        public void Creting_masters(List<int> enums, int seed, int amount_masters)
        {
            rnd = new Random(seed);
            
            for (int i = 0; i < amount_masters * 2; i+=2)
            {
                masters.Add(new Master((Qual)enums[i], (Skill)enums[i + 1]));
            }
        }
        void Creting_customers()
        {
            customers.Add(new Customer((Qual)rnd.Next(0, 2), (Skill)rnd.Next(0, 3), rnd.Next(20, 60)));
        }
    }
}
