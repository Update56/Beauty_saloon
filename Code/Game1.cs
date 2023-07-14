using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Project4.Code
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public int windowheight = 768+100; //высота окна
        public int windowwidth = 540;  //ширина окна
        Saloon saloon = new Saloon();  //экземпляр класса Салон
        Start_menu start_Menu = new();
        TimeSpan next_customer_timer = TimeSpan.Zero;
        TimeSpan start_time = TimeSpan.Zero;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            TargetElapsedTime = new System.TimeSpan(0, 0, 0, 0, 66);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = windowheight;
            _graphics.PreferredBackBufferWidth = windowwidth;
            _graphics.ApplyChanges();
            start_Menu.Show();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            saloon.MasterSprite = Content.Load<Texture2D>("master");
            saloon.WoodenFloor = Content.Load<Texture2D>("Wooden_floor");
            saloon.BrickWall = Content.Load<Texture2D>("Brick_wall");
            saloon.Girl1_Spritelist = Content.Load<Texture2D>("Girl_1");
            saloon.Font = Content.Load<SpriteFont>("Font");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            saloon.set_gametime(gameTime);

            if (!start_Menu.IsDisposed)
            {
                if (start_Menu.entry_end)
                {
                    saloon.Creting_masters(start_Menu.cB_values, start_Menu.Seed, start_Menu.Amount_masters);
                    start_Menu.entry_end = false;
                    start_Menu.Dispose();
                    next_customer_timer = gameTime.TotalGameTime + new TimeSpan(0, 0, 3);
                    start_time = gameTime.TotalGameTime;
                }
            }
            else
            {
                if (next_customer_timer <= gameTime.TotalGameTime)
                {
                    saloon.Creating_customer();
                    next_customer_timer = gameTime.TotalGameTime + new TimeSpan(0, 0, saloon.rnd.Next(15, 35));

                }
                saloon.Update();
            }

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGoldenrod);
            _spriteBatch.Begin();
            saloon.Draw(_spriteBatch);
            if (start_Menu.IsDisposed)
            {
                _spriteBatch.DrawString(saloon.Font, "Next visitor will be at " + (next_customer_timer.Minutes - start_time.Minutes).ToString() + ":" + (next_customer_timer.Seconds - start_time.Seconds).ToString() + "      Total time  " + (gameTime.TotalGameTime.Minutes - start_time.Minutes).ToString() + ":" + (gameTime.TotalGameTime.Seconds - start_time.Seconds).ToString(), new Vector2(10, 0), Color.DarkSlateBlue);
                _spriteBatch.DrawString(saloon.Font, "Money: " + saloon.money.ToString(), new Vector2(400, 0), Color.DarkSlateBlue);
            }
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}