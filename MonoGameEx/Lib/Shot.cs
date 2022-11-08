using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameEx.Lib
{
    public class Shot
    {
        //Hastigheten på skottet i antal pixlar
        public int Speed { get; set; } 
        public bool IsActive { get; set; } = true;

        public Vector2 Position;
        protected Texture2D Texture { get; set; }

        public Shot(Texture2D grafics) 
        {
            Speed = -5;
            Texture = grafics;
        }

        public  void Update(GameTime gameTime)
        {
            Position.Y += Speed;
            if (Position.Y < 0)
            {
                this.IsActive = false;
            }
           
        }
        public  void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
