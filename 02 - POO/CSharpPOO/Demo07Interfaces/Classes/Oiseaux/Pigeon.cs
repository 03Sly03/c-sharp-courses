using Demo07Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Interfaces.Classes.Oiseaux
{
    internal class Pigeon : Oiseau, IPeutVoler
    {
        public void Atterrir()
        {
            Console.WriteLine("Le Pigeon atterrit.");
        }

        public void SEnvoler()
        {
            Console.WriteLine("Le Pigeon s'envole.");
        }
    }
}
