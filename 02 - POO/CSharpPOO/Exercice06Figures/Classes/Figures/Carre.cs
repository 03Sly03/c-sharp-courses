using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06Figures.Classes.Figures
{
    internal class Carre : Figure
    {
        /*         +cote
         *        A    B
         *  -cote
         *        D    c
         */

        public double Cote { get; set; }

        public Point B => new Point(A.X + Cote, A.Y);

        public Carre(Point a, double cote) : base(a)
        {
            Cote = cote;
        }

        public Carre(double x, double y, double cote) : base(x, y)
        {
            Cote = cote;
        }
    }
}
