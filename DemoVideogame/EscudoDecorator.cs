using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVideogame
{
    public class EscudoDecorator : EnemyDecorator
    {
        private double Resistence;
        public EscudoDecorator(IEnemy enemy, double Resistence) : base(enemy)
        {
            this.Resistence = Resistence;
        }

        public override double TakeDamage()
        {
            if (Resistence <= 0)
            {
                return base.TakeDamage();
            }
            else
            {
                Console.WriteLine("Resistence of Escudo: " + Resistence);
                var damage = base.TakeDamage();
                Resistence -= damage;
                Console.WriteLine($"Resistence of Escudo luego de recibir {damage} de daño: " + Resistence);
                if (Resistence<=0)
                {
                    Console.WriteLine("El escudo se rompió");
                }
                return 0;
            }
          
        }
    }
}
