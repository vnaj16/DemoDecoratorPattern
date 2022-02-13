using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVideogame
{
    public class BossEnemy : IEnemy
    {
        public double TakeDamage()
        {
            return 10;
        }
    }
}
