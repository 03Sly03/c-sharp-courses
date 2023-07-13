void IHM() // IHM == interface Homme-Machine, ici notre affichage de menu
{
    string[] noms =
    {
        "Malik",
        "Gaëtan",
        "Rémy",
        "Aicha",
        "Clémence",
        "Thomas",
        "Johnny",
        "Slimane",
        "Kévin",
        "Grégory",
        "Guillaume",
        "Adrien",
        "Anthony",
        "Carole",
        "Nicolas",
    };
    string[] nomsTires = new string[noms.Length];
    Console.WriteLine("--- Le grand tirage au sort ---");
    while (true)
    {
        Console.WriteLine("1--- Effectuer un tirage");
        Console.WriteLine("2--- Voir la liste des personnes déjà tirées");
        Console.WriteLine("3--- Voir la liste des personnes restantes");
        Console.WriteLine("4--- Ajouter un prenom");
        Console.WriteLine("0--- Quitter\n");
        Console.Write("Faites votre choix : ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                EffectuerTirage(noms, nomsTires);
                break;
            case "2":
                AfficherTirees(nomsTires);
                break;
            case "3":
                AfficherRestantes(noms, nomsTires);
                break;
            case "4":
                AjouterNom(ref noms, ref nomsTires);
                break;
            case "0":
                return;
            default:
                WriteInColor("Erreur, réessayez !", ConsoleColor.Red);
                break;
        }
        Console.WriteLine("Appuyez sur une touche pour revenir au menu");
        Console.ReadKey();
        Console.Clear();
    };
}
void WriteInColor(string text, ConsoleColor color) // fonction pour faire un affichage en couleur
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}
void EffectuerTirage(string[] noms, string[] nomsTires)
{
    Random random = new Random();
    string nouveauNomTire;
    do
    {
        nouveauNomTire = noms[random.Next(nomsTires.Length)];   // on selectionne un nom au hasard
    } while (nomsTires.Contains(nouveauNomTire));               // tant que c'est déjà un nom tiré, on en resélectionne un nouveau

    AjouterDansTableau(nouveauNomTire, nomsTires);              // on l'ajoute aux tirés

    WriteInColor($"L'heureux gagnant est {nouveauNomTire}", ConsoleColor.Green);

    if (nomsTires[nomsTires.Length - 1] != null)                // si la dernière case du tableau n'est pas vide, on a tiré tout le monde !
    {
        WriteInColor("Toutes les personnes ont été tirées, on remet tout à 0 !", ConsoleColor.DarkYellow);
        //for (int i = 0; i < nomsTires.Length; i++)              // remise du tableau tires à 0
        //{
        //    nomsTires[i] = null;                                // donc réafectation des cellules à null
        //}
        Array.Clear(nomsTires);
    }
}
void AjouterDansTableau(string chaine, string[] tableau)
{
    for (int i = 0; i < tableau.Length; i++) // on va mettre le nouveau nom tiré dans la listeTires
        if (tableau[i] == null)                // au premier index ou la case du tableau est vide
        {
            tableau[i] = chaine;
            break;
        }
}
void AfficherTirees(string[] nomsTires)
{
    WriteInColor("Personnes Tirées : ", ConsoleColor.Red);
    string tab = "  ";
    string tabs = "";
    foreach (string nom in nomsTires)
        if (nom != null)                    // on affiche que les cases du tableau où un nom est inscrit
        {
            Console.WriteLine(tabs + nom);
            tabs += tab;
        }
}
void AfficherRestantes(string[] noms, string[] nomsTires)
{
    WriteInColor("Personnes pas encore Tirées : ", ConsoleColor.Blue);
    string tab = "  ";
    string tabs = "";
    foreach (string nom in noms)            // on itère sur tout les noms du tableau
        if (!nomsTires.Contains(nom))       // et on affiche uniquement ceux qui ne sont pas déjà tirés (pas dans nomsTires)
        {
            Console.WriteLine(tabs + nom);
            tabs += tab;
        }
}
void AjouterNom(ref string[] noms, ref string[] nomsTires) // saisie d'un nouveau nom
{
    Console.Write("Saisir un nom : ");
    string nouveauNom = Console.ReadLine();
    Array.Resize(ref noms, noms.Length + 1);        // on redimentionne les tableaux pour pouvoir accueillir le nouveau nom
    Array.Resize(ref nomsTires, noms.Length + 1);
    noms[noms.Length - 1] = nouveauNom;             // on le met à la fin du tableau nom (nouvelle case)
}

// appeller la fonction dans la partie principale du programme pour lancer l'IHM
IHM();