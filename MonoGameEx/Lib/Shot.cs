using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameEx.Lib
{
    internal class Shot
    {
        public int Speed { get; set; }
        public bool IsActive { get; set; } = true;
        public Game game { get; set; }
        public Vector2 Position;
        protected Texture2D Texture { get; set; }

        public Shot(Game game) 
        {
            Speed = -5;
            Texture = game.Content.Load<Texture2D>("shot");

        }

        public  void Update(GameTime gameTime)
        {
            Position.Y += Speed;
            if (Position.Y < 0) this.IsActive = false;
           
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
