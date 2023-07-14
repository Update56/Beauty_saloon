using Microsoft.VisualBasic.Logging;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
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
    enum Names
    {
        Aimee,
        Alice,
        Paula,
        Stella,
        Sharon,
        Whitney,
        Evelyn,
        Ellen,
        Carly,
        Olivia,
        Emma,
        Charlotte,
        Amelia,
        Sophia,
        Isabella,
        Ava,
        Mia,
        Luna,
        Harper,
        Camila,
        Sofia,
        Scarlett,
        Elizabeth,
        Eleanor,
        Emily,
        Chloe,
        Mila,
        Violet,
        Penelope,
        Gianna,
        Aria
    }
    internal class Saloon
    {
        public Saloon() { }

        List<Customer> customers = new List<Customer>(); //список посетителей
        List<Master> masters = new List<Master>(); //список мастеров
        public Random rnd = new Random(); //генератор случайных чисел
        public Texture2D MasterSprite; //текстура мастера
        public Texture2D WoodenFloor; //текстура пола
        public Texture2D BrickWall; //текструра стены
        public Texture2D Girl1_Spritelist; //спрайт лист анимации посетителя
        public SpriteFont Font;
        string Warn_string = " ";
        string Wait_string = " ";
        Color fontColor = Color.MistyRose;
        public int money = 0;
        int frame = 0; //
        int served = 0;
        int lost = 0;
        GameTime gameTime;


        int switch_walk=0;
        int x_walk = 0;
        int y_walk = 0;
        int to_master = 0;
        bool walk_flag = false;

        public void set_gametime(GameTime time) => gameTime = time;
        public void Creting_masters(List<int> enums, int seed, int amount_masters) //создание списка мастеров
        {
            rnd = new Random(seed); //установка генератору "зерна"
            for (int i = 0, j = 0, x = 120, y = 100; i < amount_masters * 2; i+=2, j++) //формирование списка
            {
                masters.Add(new Master((Qual)enums[i], (Skill)enums[i + 1]));
                masters[j].name = ((Names)rnd.Next(0, 30));
                masters[j].pos = new Vector2(x, y);
                if (x == 390)
                {
                    y += 150;
                    x = 120;
                }
                else 
                {
                    x = 390;
                }
            }
                
        }
        public void Creating_customer() //создание посетителя
        {
            customers.Add(new Customer((Qual)rnd.Next(0, 2), (Skill)rnd.Next(0, 3), new TimeSpan(0, 0, 0, rnd.Next(20, 60))));
            customers[customers.Count-1].name = ((Names)rnd.Next(0, 30));
        }
        void maintenance() //функция обслуживания 
        {
            for (int j = 0; j < customers.Count; j++)  
            {
                bool flag = true;
                for (int i = 0; i < masters.Count; i++)
                {
                    if (customers[j].service == masters[i].qual && customers[j].difficulty <= masters[i].skill)
                    {
                        if (masters[i].finishing_time <= gameTime.TotalGameTime)
                        {
                            masters[i].finishing_time = customers[j].time + gameTime.TotalGameTime;
                            Warn_string = "Customer " + customers[j].name.ToString() + " go\nto master " + masters[i].name.ToString();
                            served++;
                            if (i % 2 == 0)
                                switch_walk = 1;
                            else
                                switch_walk = 2;
                            to_master = i;
                            masters[to_master].employ = false;
                            money += rnd.Next(20, 60);
                            walk_flag = true;
                            x_walk = Convert.ToInt32(customers[j].pos.X);
                            y_walk = Convert.ToInt32(customers[j].pos.Y);
                            customers.RemoveAt(j);
                            flag = false;
                            break;
                        }
                        else
                        {
                            Wait_string = "Customer " + customers[j].name.ToString() + "\nwaiting";

                            flag = false;
                            break;
                        }
                    }
                }
                if(flag)
                {
                    Warn_string = "You lost a customer\nNeeded a master: \n" + customers[j].service.ToString() + ' ' + customers[j].difficulty.ToString();
                    lost++;
                    customers.RemoveAt(j);
                }
            }
        }
        public void Update()
        {
            maintenance();

            foreach (Master master in masters)
            {
                if (master.finishing_time <= gameTime.TotalGameTime)
                {
                    master.employ = false;
                }
            }

            switch (switch_walk)
            {
                case 0:
                    x_walk = 250;
                    y_walk = 700;
                    walk_flag = false;
                    to_master = 0;
                    break;
                case 1:
                    if (x_walk > masters[to_master].pos.X)
                        x_walk -= 5;
                    break;
                case 2:
                    if (x_walk < masters[to_master].pos.X)
                        x_walk += 5;
                    break;
            }
            if (y_walk > masters[to_master].pos.Y)
                y_walk -= 10;
            if (y_walk <= masters[to_master].pos.X && y_walk <= masters[to_master].pos.Y)
            {
                masters[to_master].employ = true;
                switch_walk = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < 768; i += 64)
            {
                for (int j = 30; j < 768 + 30; j += 64)
                {
                    spriteBatch.Draw(WoodenFloor, new Rectangle(i, j, WoodenFloor.Width, WoodenFloor.Height), Color.White);
                }
            }
            spriteBatch.Draw(BrickWall, new Rectangle(0, 30, 540, BrickWall.Height), Color.White);
            bool flag = true;
            for (int i = 0; i < masters.Count; i++)
            {
                if (flag)
                {
                    spriteBatch.Draw(MasterSprite, masters[i].pos, null, Color.White, 0, Vector2.Zero, 0.5f, 0, 0);
                    if (masters[i].finishing_time > gameTime.TotalGameTime && masters[i].employ == true)
                    {
                        spriteBatch.Draw(Girl1_Spritelist, masters[i].pos - new Vector2(45, -30), new Rectangle(0, 0, 71, 97), Color.White, 0, Vector2.Zero, 0.7f, SpriteEffects.FlipHorizontally, 0);
                        spriteBatch.DrawString(Font, ((masters[i].finishing_time - gameTime.TotalGameTime).Minutes * 60 + (masters[i].finishing_time - gameTime.TotalGameTime).Seconds).ToString(), masters[i].pos - new Vector2(30, -5), fontColor);
                    }
                    flag = false;
                }
                else
                {
                    spriteBatch.Draw(MasterSprite, masters[i].pos, null, Color.White, 0, Vector2.Zero, 0.5f, SpriteEffects.FlipHorizontally, 0);
                    if (masters[i].finishing_time > gameTime.TotalGameTime && masters[i].employ == true)
                    {
                        spriteBatch.Draw(Girl1_Spritelist, masters[i].pos + new Vector2(28, 30), new Rectangle(0, 0, 71, 97), Color.White, 0, Vector2.Zero, 0.7f, SpriteEffects.None, 0);
                        spriteBatch.DrawString(Font, ((masters[i].finishing_time - gameTime.TotalGameTime).Minutes * 60 + (masters[i].finishing_time - gameTime.TotalGameTime).Seconds).ToString(), masters[i].pos + new Vector2(45, 5), fontColor);
                    }
                    flag = true;
                }
                spriteBatch.DrawString(Font, masters[i].name.ToString(), masters[i].pos - new Vector2(10, 25), fontColor);
            }

            spriteBatch.DrawString(Font, Warn_string, new Vector2(10, 800), fontColor);
            spriteBatch.DrawString(Font, Wait_string, new Vector2(200, 800), fontColor);
            spriteBatch.DrawString(Font, "Served: "+ served.ToString() + "\n" + "Lost: " + lost.ToString(), new Vector2(400, 800), fontColor);

            if (customers.Count != 0)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    spriteBatch.Draw(Girl1_Spritelist, customers[i].pos + new Vector2(i * 70, 0), new Rectangle(0, 0, 71, 97), Color.White, 0, Vector2.Zero, 0.7f, SpriteEffects.None, 0);
                    spriteBatch.DrawString(Font, customers[i].name.ToString(), customers[i].pos + new Vector2(i * 70, -25), fontColor);
                }
            }

            if (frame == 7)
            {
                frame = 1;
            }
            if (walk_flag)
                spriteBatch.Draw(Girl1_Spritelist, new Vector2(x_walk, y_walk), new Rectangle(71 * frame, 0, 71, 97), Color.White, 0, Vector2.Zero, 0.7f, SpriteEffects.None, 0);
            frame++;


        }
    }
}
