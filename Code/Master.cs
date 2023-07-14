using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Code
{
    internal class Master
    {
        public Qual qual;       //квалификация мастера
        public Skill skill;     //умение мастера
        public TimeSpan finishing_time; //оставшееся время до завершения работы
        public Names name;
        public bool employ = false;
        public Vector2 pos;
        public Master(Qual qual, Skill skill)
        {
            this.qual = qual;
            this.skill = skill;
            this.finishing_time = TimeSpan.Zero;
        }
        public Master()
        {
            this.qual = Qual.haircutter;
            this.skill = Skill.novice;
            this.finishing_time = TimeSpan.Zero;
        }

    }
}
