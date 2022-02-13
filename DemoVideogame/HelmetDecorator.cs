using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVideogame
{
    public class HelmetDecorator : EnemyDecorator
    {
        public HelmetDecorator(IEnemy enemy) : base(enemy)
        {
        }

        public override double TakeDamage()
        {
            return base.TakeDamage()*0.2;
        }
    }
}
