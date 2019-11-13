using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Hero : Unit
    {
        public Hero(string _path, Vector2 _pos, Vector2 _dims) : base(_path, _pos, _dims)
        {
            speed = 2.0f;
        }

        public override void Update(Vector2 _offset)
        {
            if (Globals.keyboard.GetPress("A"))
            {
                pos = new Vector2(pos.X - speed, pos.Y);
            }
            if (Globals.keyboard.GetPress("D"))
            {
                pos = new Vector2(pos.X + speed, pos.Y);
            }
            if (Globals.keyboard.GetPress("W"))
            {
                pos = new Vector2(pos.X, pos.Y - speed);
            }
            if (Globals.keyboard.GetPress("S"))
            {
                pos = new Vector2(pos.X, pos.Y + speed);
            }

            if (Globals.mouse.LeftClick())
            {
                GameGlobals.PassProjectile(new Bullet("2d\\bullet", new Vector2(pos.X, pos.Y), new Vector2(100, 100), this, new Vector2(Globals.mouse.newMousePos.X, Globals.mouse.newMousePos.Y)));
            }

            base.Update(_offset);
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
