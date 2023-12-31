﻿using Exercice06Figures.Interfaces;
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
         *        D    C
         */

        public double Cote { get; set; }

        public Point B => new Point(A.X + Cote, A.Y);
        // équivalents :
        //public Point B2 { get => new Point(A.X + Cote, A.Y); }
        //public Point B3 { 
        //    get 
        //    {
        //        return new Point(A.X + Cote, A.Y); 
        //    } 
        //}
        public Point C => new Point(A.X + Cote, A.Y - Cote);
        public Point D => new Point(A.X, A.Y - Cote);

        public Carre(Point a, double cote) : base(a)
        {
            Cote = cote;
        }

        public Carre(double x, double y, double cote) : base(x, y)
        {
            Cote = cote;
        }

        public override string ToString()
        {
            return $"Coordonnées du carré ABCD (Coté = {Cote})" +
                "\nA = " + A +
                "\nB = " + B +
                "\nC = " + C +
                "\nD = " + D; 
        }
    }
}
