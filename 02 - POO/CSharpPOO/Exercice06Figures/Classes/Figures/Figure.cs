using Exercice06Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06Figures.Classes.Figures
{
    internal abstract class Figure : IDeplacable
    {
        public Point A { get; private set; }

        protected Figure(Point a)
        {
            A = a;
        }
        protected Figure(double x, double y)
        {
            A = new Point(x, y);
        }

        public void Deplacement(double x, double y)
        {
            //A.X += x;
            //A.Y += y;
            A.Deplacement(x, y);
        }
    }
}
