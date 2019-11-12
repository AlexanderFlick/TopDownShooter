using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownShooter.Source.Engine
{
    public class Globals
    {
        public static ContentManager content;
        public static SpriteBatch spriteBatch;

        public static McKeyboard keyboard;
        public static McMouseControl mouse;
        public static GameTime gameTime;
        public static int screenHeight, screenWidth;

        public static float GetDistance(Vector2 pos, Vector2 target)
        {
            return (float)Math.Sqrt(Math.Pow(pos.X - target.X, 2) + Math.Pow(pos.Y = target.Y, 2));
        }
    }
}
