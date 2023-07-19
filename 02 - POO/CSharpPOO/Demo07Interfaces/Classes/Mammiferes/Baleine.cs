using Demo07Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07Interfaces.Classes.Mammiferes
{
    internal class Baleine : Mammifere, IPeutNager
    {
        public string Nom { get; set; } = "Willy";
        public void Nager()
        {
            Console.WriteLine($"La Baleine nage.");
        }
    }
}
