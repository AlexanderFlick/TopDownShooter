﻿using Microsoft.Xna.Framework;
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
        public bool dead;
        public float speed, hitDist;

        public Unit(string _path, Vector2 _pos, Vector2 _dims) : base(_path, _pos, _dims)
        {
            dead = false;
            hitDist = 50.0f;
        }

        public override void Update(Vector2 _offset)
        {
            base.Update(_offset);
        }

        public virtual void GetHit()
        {
            dead = true;
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
