using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopDownShooter.Source.Engine;
using TopDownShooter.Source.Gameplay.World;

namespace TopDownShooter.Source
{
    public class World
    {
        public Vector2 offset;

        public Hero hero;

        public List<Projectile2d> projectiles = new List<Projectile2d>();

        public World()
        {
            hero = new Hero("2d\\skeletonLR", new Vector2(300, 300), new Vector2(48, 48));

            GameGlobals.PassProjectile = AddProjectile;

            offset = new Vector2(0, 0);
        }

        public virtual void Update()
        {
            hero.Update();

            for (int i=0; i<projectiles.Count; i++)
            {
                projectiles[i].Update(offset, null);

                if (projectiles[i].done)
                {
                    projectiles.RemoveAt(i);
                    i--;
                }
            }
        }

        public virtual void AddProjectile(object _info)
        {
            projectiles.Add((Projectile2d)_info);
        }

        public virtual void Draw(Vector2 _offset)
        {
            hero.Draw(_offset);
            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Draw(offset);
            }
        }
    }
}
