using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TopDownShooter.Source;
using TopDownShooter.Source.Engine;
using TopDownShooterPrompt;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Bullet : Projectile2d
    {
        public Bullet(string _path, Vector2 _pos, Vector2 _dims, Unit _owner, Vector2 _target) : base("2d\\bullet", _pos, new Vector2(50,50), _owner, _target)
        {
            
        }

        public override void Update(Vector2 _offset, List<Unit> _units)
        {
            base.Update(_offset, _units);
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
