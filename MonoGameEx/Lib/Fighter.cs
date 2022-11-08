using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameEx.Lib
{
    public class Fighter
    {
        public Game game { get; set; }
        public Vector2 Position;
        protected Texture2D Texture { get; set; }

        public Fighter(Texture2D graphics)
        {
            Texture = graphics;
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
