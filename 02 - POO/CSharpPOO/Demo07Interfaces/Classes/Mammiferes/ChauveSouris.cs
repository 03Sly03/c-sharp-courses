using Demo07Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Interfaces.Classes.Mammiferes
{
    internal class ChauveSouris : Mammifere, IPeutVoler
    {
        public void Atterrir()
        {
            Console.WriteLine("La chauve-souris atterrit sur le plafond.");
        }

        public void SEnvoler()
        {
            Console.WriteLine("La chauve-souris s'envole vers le bas.");
        }
    }
}
