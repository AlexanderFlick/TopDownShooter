using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownShooter.Source.Engine
{
    public class Basic2d
    {
        public float rot;

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

        public virtual void Draw(Vector2 _offset)
        {
            if(myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X + _offset.X), (int)(pos.Y + _offset.Y), (int)dims.X, (int)dims.Y), null, Color.White, 0.0f, new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2), new SpriteEffects(), 0);
            }
        }

        public virtual void Draw(Vector2 _offset, Vector2 _origin)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X + _offset.X), (int)(pos.Y + _offset.Y), (int)dims.X, (int)dims.Y), null, Color.White, rot, new Vector2(_origin.X, _origin.Y), new SpriteEffects(), 0);
            }
        }
    }
}
