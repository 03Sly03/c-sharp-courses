﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02Static.Classes
{
    internal class Dinosaur
    {
        // via l'utilisation du mot clé static
        // nous avons un attribut de classe et non d'instance
        // il est partagé entre toutes les instances et accessible depuis la classe
        private static int _nombreDeDinos = 0;

        public string Nom { get; set; } = "Dinosaur par défaut";
        public int Age { get; set; } = 0;
        public string Espece { get; set; } = "Espèce par défaut";
        public int NbPattes { get; set; } = 4;
        public double Poids { get; set; } = 120;
        public bool PeutVoler { get; set; } = false;
        public string RegimeAlimentaire { get; set; } = "Herbivore";

        // La propriété est static donc est relative à la classe aussi
        public static int NombreDeDinos { get => _nombreDeDinos; }

        // équivalent sans l'attribut static
        //public static int NombreDeDinos { get; } = 0;


        public Dinosaur()
        {
            _nombreDeDinos++;
            AfficherDinosaurCrees();
        }

        // à l'aide du " : this()" on vient préciser que à l'appel de ce constructeur, on appelle aussi le constructeur par défaut
        public Dinosaur(string nom, int age, string espece, bool peutVoler = false) : this()
        {
            Nom = nom;
            Age = age;
            Espece = espece;
            PeutVoler = peutVoler;
        }

        public void Afficher()
        {
            Console.WriteLine($"Le Dinosaur {Nom} est agé de {Age} ans et est de l'espèce {Espece}");
        }

        public void Crier()
        {
            Console.WriteLine($"Le Dinosaur {Nom} crie !");
        }

        public void SEnvoler()
        {
            if (PeutVoler)
            {
                Console.WriteLine($"Le Dinosaur {Nom} s'envole majestueusement !");
                return;
            }
            Console.WriteLine($"Le Dinosaur {Nom} saute et s'écrase lamentablement...");
        }

        // Méthode static (dites "de classe")
        public static void AfficherDinosaurVivants()
        {
            Console.WriteLine("Tout les dinosaures sont morts depuis bien longtemps...");
        }
        public static void AfficherDinosaurCrees()
        {
            Console.WriteLine("Dinosaurs créés avec le constructeur : " + NombreDeDinos);
        }
    }
}
