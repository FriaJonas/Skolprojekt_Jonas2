using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameEx.Lib;
using System.Collections.Generic;

namespace MonoGameEx
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D Background;
        
        Texture2D ShipGraphic;
        Fighter fighter { get; set; }

        Texture2D ShotGraphic;
        List<Shot> shots { get; set; } = new List<Shot>();

        //Ljud
        SoundEffect laserSound;

        public Game1()
        {
           
            //Konstruktorn - här initieras spelet
            //Vi skapar ett objekt av GraphicsDeviceManager som håller reda på spelplanen
            _graphics = new GraphicsDeviceManager(this);
            
            //Vilken mapp som grafiken ligger i!
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            //Vi sätter storleken på fönstret
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 550; 

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Background = Content.Load<Texture2D>("bgspace");
            laserSound = Content.Load<SoundEffect>("laserSound");
            ShotGraphic = Content.Load<Texture2D>("shot");
            ShipGraphic = Content.Load<Texture2D>("fighter");
            // TODO: use this.Content to load your game content here

            //Eftersom jag vill att mitt skepp ska vara med direkt i start så skapar vi  det här!
            fighter = new Fighter(ShipGraphic)
            {
                Position = new Vector2(_graphics.GraphicsDevice.Viewport.Width / 2 - 20, _graphics.GraphicsDevice.Viewport.Height - 60)
            };
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            //Lyssna av tangentbordet
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.Left))
            {
                fighter.Position.X -= 5f;
            }
            if (ks.IsKeyDown(Keys.Right))
            {
                fighter.Position.X += 5;
            }
            if (fighter.Position.X < -40)
            {
                fighter.Position.X = _graphics.GraphicsDevice.Viewport.Width + 40;
            }
            if (fighter.Position.X > _graphics.GraphicsDevice.Viewport.Width + 40)
            {
                fighter.Position.X = -40;
            }
            if (ks.IsKeyDown(Keys.Space))
            {
                //Spelar ljudet
                laserSound.Play(0.7f, 0f, 0f);
                
                shots.Add(new Shot(ShotGraphic)
                {
                    Position = new Vector2(fighter.Position.X + 20, fighter.Position.Y)
                });
            }
            shots.ForEach(e => e.Update(gameTime));
            shots.RemoveAll(e => !e.IsActive);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //Tömmer allt på skärmen varje gång!!!
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(Background, new Vector2(0, 0), Color.White);
            //Uppdatera fightern
            fighter.Draw(_spriteBatch);

            //Uppdatera alla skott
            shots.ForEach(e => e.Draw(_spriteBatch));


            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}