using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Mob : Unit
    {
        public Mob(string _path, Vector2 _pos, Vector2 _dims) : base(_path, _pos, _dims)
        {
            speed = 2.0f;
        }

        public virtual void Update(Vector2 _offset, Hero _hero)
        {
            AI(_hero);
            base.Update(_offset);
        }

        public virtual void AI(Hero _hero)
        {
            pos += Globals.RadialMovement(_hero.pos, pos, speed);
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
