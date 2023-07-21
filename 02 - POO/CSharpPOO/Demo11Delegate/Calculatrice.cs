using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11Delegate
{
    /// <summary>
    /// Classe servant à faire des opérations mathématiques
    /// </summary>
    internal class Calculatrice
    {
        public Func<int, int, int> MethodeCalcul { get; set; }

        /// <summary>
        /// Méthode qui fait la somme de 2 entiers.
        /// </summary>
        /// <param name="a">Un entier</param>
        /// <param name="b">Un deuxième entier</param>
        /// <returns>La somme des entiers a et b</returns>
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


        public void CalculerEtAfficher(int a, int b)
        {
            int resultat = MethodeCalcul(a, b);
            Console.WriteLine($"L'operation de calcul entre les entiers {a} et {b} donne {resultat}");
        }
    }
}
