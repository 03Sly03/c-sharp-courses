﻿//Console.WriteLine("\u001b[32m--- Gestion des contacts ---\n\u001b[0m");
//Console.Write("Merci de saisir le nombre de contact : ");
//int nbContact = Convert.ToInt32(Console.ReadLine());
//string[] nomContact = new string[nbContact];
//Console.Clear();

//string choix;


//do
//{
//    Console.WriteLine("\u001b[32m--- Gestion des contacts ---\n\u001b[0m");
//    Console.WriteLine("----- Ma liste de contacts -----");
//    Console.WriteLine("1----Saisir des contacts");
//    Console.WriteLine("2----Afficher mes contacts");
//    Console.WriteLine("0----Quitter\n");

//    do
//    {
//        Console.Write("Faites votre choix : ");
//        choix = Console.ReadLine();
//    } while (choix != "0" && choix != "1" && choix != "2");

//    Console.Clear();

//    switch (choix)
//    {
//        case "1":
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("------ Saisir les contacts ------");
//            //Console.ForegroundColor = ConsoleColor.Gray;
//            Console.ResetColor();
//            for (int i = 0; i < nomContact.Length; i++)
//            {
//                Console.Write("Nom et prénom du contact N° " + (i + 1) + " : ");
//                nomContact[i] = Console.ReadLine();
//            }

//            Console.Clear();
//            break;

//        case "2":
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("--- Affichage des contact ---\n");
//            //Console.ForegroundColor = ConsoleColor.Gray;
//            Console.ResetColor();
//            for (int i = 0; i < nomContact.Length; i++)
//            {
//                Console.WriteLine("\t-Contact N° " + (i + 1) + " : " + nomContact[i]);
//            }
//            Console.WriteLine("Appuyez sur une touche pour retourner au menu.");
//            Console.ReadKey();
//            Console.Clear();
//            break;

//        case "0":
//            //Environment.Exit(0);
//            //return; // sort de la méthode Main de la classe Program
//            break;

//    }
//} while (choix != "0");



Console.WriteLine("*** Gestion des Contacts ***");
Console.Write("Merci de saisir le nombre de contacts : ");
int nbContacts = int.Parse(Console.ReadLine());
string[] contacts = new string[nbContacts];
string choix = "";
Console.Clear();
do
{
    Console.WriteLine("--- Ma liste de contacts ---");
    Console.WriteLine("1---Saisir des contacts");
    Console.WriteLine("2---Afficher mes contacts");
    Console.WriteLine("0---Quitter\n");
    Console.Write("Faites votre choix : ");
    choix = Console.ReadLine();
    Console.Clear();
    switch (choix)
    {
        case "1":

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Saisir les contacts ---");
            Console.ResetColor();
            for (int i = 0; i < nbContacts; i++)
            {
                Console.Write($"Nom et prénom du contact {i + 1} : ");
                contacts[i] = Console.ReadLine();
            }
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Affichage des contacts ---");
            Console.ResetColor();
            for (int i = 0; i < nbContacts; i++)
            {
                Console.WriteLine($"Contact N° {i + 1} : {contacts[i]} ");
            }
            Console.WriteLine("Appuyez sur une touche pour retourner au menu.");
            Console.ReadKey();
            Console.Clear();
            break;
        case "0":
            //Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Saisie incorrecte, réessayez");
            break;
    }

} while (choix != "0");
