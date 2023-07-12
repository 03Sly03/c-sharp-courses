Console.WriteLine("--- Où est passé mon numéro ? ---");
Console.WriteLine("Affectation des valeurs...");
Random rnd = new Random();
int[] valeurs = new int[10];
for (int i = 0; i < valeurs.Length; i++)
{
    int num = rnd.Next(1, 51);
    valeurs[i] = num;
}


Console.WriteLine("Affichage avant triage : ");


const string tabulation = "  ";
string tabulations = tabulation;

foreach (int val in valeurs)
{
    Console.WriteLine(tabulations + val);
    tabulations += tabulation;
}

int premiereValeur = valeurs[0];

Array.Sort(valeurs);

Console.WriteLine("Après : ");

tabulations = tabulation;
foreach (int val in valeurs)
{
    Console.WriteLine(tabulations + val);
    tabulations += tabulation;
}

int premiereValeurApresTriage = Array.IndexOf(valeurs, premiereValeur) + 1;

Console.WriteLine($"Le nombre {premiereValeur} se trouvait en 1ere position");
Console.WriteLine($"il se retrouve à la position {premiereValeurApresTriage} après triage.");

