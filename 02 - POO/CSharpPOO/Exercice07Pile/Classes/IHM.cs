using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Pile.Classes
{
    internal class IHM
    {
        string choix;
        Pile<Personne> pilePersonne;
        Pile<decimal> pileDecimal;
        Pile<string> pileString;

        public void Start()
        {
            do
            {
                ActionChoixTypePile();
                Menu();
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        //ActionAjouterElement();
                        break;
                    case "2":
                        ActionSupprimerElement();
                        break;
                    case "3":
                        ActionRecuperElement();
                        break;
                    case "0":
                        return;
                }
            } while (choix != "0");
        }

        private void ActionChoixTypePile()
        {
            Console.WriteLine("1-- Pile Personne");
            Console.WriteLine("2-- Pile Decimal");
            Console.WriteLine("3-- Pile String");
            Console.Write("Votre choix : ");
            choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    pilePersonne = new Pile<Personne>();
                    break;
                case "2":
                    pileDecimal = new Pile<decimal>();
                    break;
                case "3":
                    pileString = new Pile<string>();
                    break;
            }

        }
        private void Menu()
        {
            Console.WriteLine("1--- Ajouter un élément");
            Console.WriteLine("2--- Supprimer un élément");
            Console.WriteLine("3--- Récupérer un élément");
            Console.WriteLine("0--- Quitter ");
        }

        private void ActionAjouterElement<T>(Pile<T> pile)
        {

        }

        private void ActionSupprimerElement()
        {

        }
        private void ActionRecuperElement()
        {

        }
    }
}
