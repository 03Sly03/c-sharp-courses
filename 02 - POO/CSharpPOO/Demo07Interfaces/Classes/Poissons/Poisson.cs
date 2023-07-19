using Demo07Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Interfaces.Classes.Poissons
{
    internal abstract class Poisson : Animal, IPeutNager
    {
        public void Nager() // possible de mettre en virtual/abstract si on veut pouvoir override cette méthode
        {
            Console.WriteLine($"Le {GetType().Name} nage.");
        }
    }
}
