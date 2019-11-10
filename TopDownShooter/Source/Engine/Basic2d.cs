using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownShooter.Source.Engine
{
    class Basic2d
    {
        public Vector2 pos, dims;

        public Texture2D myModel;

        public Basic2d(string _path, Vector2 _pos, Vector2 _dims)
        {
            pos = _pos;
            dims = _dims;

            myModel = Globals.content.Load<Texture2D>(_path);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            if(myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X), (int)(pos.Y), (int)dims.X, (int)dims.Y), null, Color.White, 0.0f, new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2), new SpriteEffects(), 0));
            }
        }
    }
}
