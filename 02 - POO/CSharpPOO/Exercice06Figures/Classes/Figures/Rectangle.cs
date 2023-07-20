using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06Figures.Classes.Figures
{
    internal class Rectangle : Figure
    {
        /*            +longueur
         *          A           B
         * -largeur
         *          D           c
         */

        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Point B => new Point(A.X + Longueur, A.Y);
        public Point C => new Point(A.X + Longueur, A.Y - Largeur);
        public Point D => new Point(A.X, A.Y - Largeur);

        public Rectangle(Point a, double longueur, double largeur) : base(a)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public Rectangle(double x, double y, double longueur, double largeur) : base(x, y)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public override string ToString()
        {
            return $"Coordonnées du Rectangle ABCD (Longueur = {Longueur}, Largeur = {Largeur})" +
                "\nA = " + A +
                "\nB = " + B +
                "\nC = " + C +
                "\nD = " + D;
        }
    }
}
