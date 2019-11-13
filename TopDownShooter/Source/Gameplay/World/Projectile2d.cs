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
    public class Projectile2d : Basic2d
    {
        public bool done;

        public float speed;

        public Vector2 direction;

        public Unit owner;

        public McTimer timer;

        public Projectile2d(string _path, Vector2 _pos, Vector2 _dims, Unit _owner, Vector2 _target) : base(_path, _pos, _dims)
        {
            done = false;
            speed = 5.0f;
            owner = _owner;
            direction = _target - owner.pos;
            direction.Normalize();

            timer = new McTimer(1200);
        }

        public virtual void Update(Vector2 _offset, List<Unit> _units)
        {
            pos += direction * speed;

            timer.UpdateTimer();

            if (timer.Test())
            {
                done = true;
            }

            if (HitSomething(_units))
            {
                done = true;
            }
        }

        public virtual bool HitSomething(List<Unit> _units)
        {
            return false;
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
