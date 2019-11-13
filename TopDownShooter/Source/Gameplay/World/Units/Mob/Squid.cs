using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Squid : Mob
    {
        public Squid(Vector2 _pos) : base("2d\\enemy", _pos, new Vector2(40,40))
        {
            speed = 1.0f;
        }

        public override void Update(Vector2 _offset, Hero _hero)
        {
            base.Update(_offset, _hero);
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
