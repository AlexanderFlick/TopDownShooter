using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Unit : Basic2d
    {
        public float speed;

        public Unit(string _path, Vector2 _pos, Vector2 _dims) : base(_path, _pos, _dims)
        {
            
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
