using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVideogame
{
    public abstract class EnemyDecorator : IEnemy
    {
        protected IEnemy enemy;

        protected EnemyDecorator(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public virtual double TakeDamage()
        {
            return this.enemy.TakeDamage();
        }
    }
}
