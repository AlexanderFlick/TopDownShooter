using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;
using TopDownShooterPrompt;

namespace TopDownShooter.Source.Gameplay.World
{
    public class SpawnPoints : Basic2d
    {
        public McTimer spawnTimer = new McTimer(2200);

        public SpawnPoints(string _path, Vector2 _pos, Vector2 _dims) : base(_path, _pos, _dims)
        {
        }

        public override void Update(Vector2 _offset)
        {
            spawnTimer.UpdateTimer();
            if (spawnTimer.Test())
            {
                SpawnMob();
                spawnTimer.ResetToZero();
            }

            base.Update(_offset);
        }

        public virtual void SpawnMob()
        {
            GameGlobals.PassMob(new Squid(new Vector2(pos.X, pos.Y)));
        }

        public override void Draw(Vector2 _offset)
        {
            base.Draw(_offset);
        }
    }
}
