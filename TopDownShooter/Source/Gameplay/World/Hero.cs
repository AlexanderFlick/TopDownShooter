using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;

namespace TopDownShooter.Source.Gameplay.World
{
    public class Hero : Basic2d
    {
        public Hero(string _path, Vector2 _pos, Vector2 _dims) : base(_path, _pos, _dims)
        {

        }

        public override void Update()
        {
            if (Globals.keyboard.GetPress("A"))
            {
                pos = new Vector2(pos.X - 1, pos.Y);
            }
            if (Globals.keyboard.GetPress("D"))
            {
                pos = new Vector2(pos.X + 1, pos.Y);
            }
            if (Globals.keyboard.GetPress("W"))
            {
                pos = new Vector2(pos.X, pos.Y - 1);
            }
            if (Globals.keyboard.GetPress("S"))
            {
                pos = new Vector2(pos.X, pos.Y + 1);
            }

            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
