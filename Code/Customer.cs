using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Code
{
    internal class Customer
    {
        public Qual service;      //тип услуги
        public Skill difficulty; //сложность услуги
        public TimeSpan time;         //время оказания услуги
        public Names name;
        public Vector2 pos = new Vector2(50, 700);
        public Customer(Qual service, Skill difficulty, TimeSpan time) //конструктор
        {
            this.service = service;
            this.difficulty = difficulty;
            this.time = time;
        }

    }
}
