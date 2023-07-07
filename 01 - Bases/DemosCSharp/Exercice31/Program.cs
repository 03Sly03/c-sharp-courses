//définir min max sum nbnotes

while (true)
{
    string choice;
    Console.WriteLine("--- Gestion des notes avec menu ---\n ");
    Console.Write("1----Saisir les notes" +
        "\n2----La meilleure note" +
        "\n3----La pire note" +
        "\n4----La moyenne des notes" +
        "\n0----Quitter" +
        "\n\nFaites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            Console.Write("cas 1");
            break;
        case "2":
            Console.Write("cas 2");
            break;
        case "3":
            Console.Write("cas 3");
            break;
        case "4":
            Console.Write("cas 4");
            break;
        case "0":
            Console.Write("cas 0"); // sortir du programme
            break;
        default:
            Console.WriteLine("Erreur de saisie, recommencez !");
            break;
    }
}