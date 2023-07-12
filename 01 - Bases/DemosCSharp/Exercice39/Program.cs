//// VERSION AVEC LISTES

//List<string> listBase = new List<string>
//{
//    "Sébastien",
//    "Allan",
//    "Dominique",
//    "Eric",
//    "Anthony",
//    "Yves",
//    "Aguit",
//    "Adrien",
//    "Jérome",
//    "Walid",
//    "Olivier",
//    "Stéphanie",
//    "Yannick",
//    "Christopher",
//    "Brice"
//};

//List<string> listRestante = new List<string>(listBase); // crée une nouvelle instance via le constructeur de recopie

//Random rand = new Random();
//List<string> listTirer = new List<string>();
//bool fin = false;


//while (!fin)
//{
//    Console.WriteLine(" --- Le grand tirage au sort ---" +
//    "\n" +
//    "\n 1---Effectuer un tirage" +
//    "\n 2---Voir la liste des personnes déja tirées" +
//    "\n 3---Voir la liste des personnes restantes" +
//    "\n 0---Quitter");
//    Console.WriteLine();
//    Console.Write("Faites votre choix :");
//    var choice = Console.ReadLine();
//    var tab = "";
//    var longueurListRestante = listRestante.Count();
//    switch (choice)
//    {
//        case "1":
//            if (longueurListRestante > 0)
//            {
//                var randName = listRestante[rand.Next(0, longueurListRestante)];
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine($"* L'heureux gagnant est : {randName} *");
//                Console.ForegroundColor = ConsoleColor.White;
//                listRestante.Remove(randName);
//                listTirer.Add(randName);
//            }
//            else if (longueurListRestante == 0)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Il n'y a plus de candidat, on réinitialise nos listes");
//                Console.ForegroundColor = ConsoleColor.White;
//                listRestante = new List<string>(listBase);
//                listTirer = new List<string>();
//            }
//            break;
//        case "2":
//            foreach (var name in listTirer)
//            {
//                Console.WriteLine(tab + name);
//                tab += " ";
//            }
//            break;
//        case "3":
//            foreach (var name in listRestante)
//            {
//                Console.WriteLine(tab + name);
//                tab += " ";
//            }
//            break;
//        case "0":
//            fin = true;
//            break;
//        default:
//            Console.WriteLine("Erreur de saisie");
//            break;
//    }
//}


// VERSION AVEC TABLEAU

string[] players = new string[15]
{
    "Rémi", "Aicha", "Clémence", "Gaetan", "Kevin", "Gregory", "Adrien", "Anthony", "Carole", "Guillaume", "Johnny", "Malik", "Nicolas", "Slimane", "Thomas"
};

string[] winners = new string[15];
int i = 0;

while (true)
{
    Console.ResetColor();
    Console.WriteLine("--- Tombola ---\n");
    Console.WriteLine("1. Effectuer un tirage");
    Console.WriteLine("2. Afficher la liste des gagnants");
    Console.WriteLine("3. Afficher la liste des joueurs restants");
    Console.WriteLine("0. Quitter\n");

    Console.Write("Faites votre choix : ");
    string userChoice = Console.ReadLine()!;

    switch (userChoice)
    {
        case "0":
            Environment.Exit(0);
            break;

        case "1":
            Random randomly = new Random();
            int randomIndex = randomly.Next(0, players.Length);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n*** L'heureux.se gagnant.e est : {players[randomIndex]} !! ***\n");
            Console.ResetColor();
            Console.WriteLine();

            winners[i] = players[randomIndex];
            i++;
            players[randomIndex] = players[players.Length - 1];
            Array.Resize(ref players, players.Length - 1);

            if (players.Length == 0)
            {
                players = (string[])winners.Clone();
                i = 0;
                Array.Clear(winners, 0, 15);
                Console.WriteLine("Il n'y a plus de candidat, on réinitialise nos listes");
            }
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Liste des personnes déjà tirées au sort ---\n");
            Console.ResetColor();
            foreach (var winner in winners)
                if (winner != null)
                    Console.WriteLine($"\t{winner}");
            Console.WriteLine("");
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--- Liste des personnes en attente ---\n");
            Console.ResetColor();
            foreach (var player in players)
                Console.WriteLine($"\t{player}");
            Console.WriteLine("");
            break;

        default:
            Console.Clear();
            break;
    }
}