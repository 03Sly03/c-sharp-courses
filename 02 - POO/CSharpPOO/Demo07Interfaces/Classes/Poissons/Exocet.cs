using Demo07Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Interfaces.Classes.Poissons
{
    internal class Exocet : Poisson, IPeutVoler
    {
        public void Atterrir()
        {
            Console.WriteLine("L'exocet retombe dans l'eau.");
            Nager();
        }

        public void SEnvoler()
        {
            Console.WriteLine("L'exocet s'envole en sortant de l'eau.");
        }
    }
}
