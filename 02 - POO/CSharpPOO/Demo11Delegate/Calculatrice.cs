using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11Delegate
{
    internal class Calculatrice
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }

        public void CalculerEtAfficher(int a, int b, Func<int, int, int> methodeDeCalcul)
        {
            int resultat = methodeDeCalcul(a, b);
            Console.WriteLine($"L'operation de calcul entre les entiers {a} et {b} donne {resultat}");
        }
    }
}
