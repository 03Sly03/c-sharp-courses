Console.WriteLine("-- Est pair...? Est impair...? ---");
Console.Write("Combien de nombres contiendra le tableau ? : ");
int nb = Convert.ToInt32(Console.ReadLine());

int[] ints = new int[nb];

Console.Write("Affectation automatique des valeurs...");

Random random = new Random();

for (int i = 0; i < nb; i++)
    ints[i] = random.Next(1, 51);



Console.WriteLine("Vérification des valeurs du tableau : ");

for (int i = 0; i < nb; i++)
{
    string estPair = ints[i] % 2 == 1 ? "impair" : "pair";
    Console.WriteLine($"Le nombre {ints[i]} est {estPair}.");
}


// Exemples sur le formatage de strings

//Console.WriteLine("Le chiffre {0} est {1}{0}.", 1, "impair"); // utilise le string.Format()

//string str = string.Format("Le chiffre {0} est {1}{0}.", 1, "impair");
//Console.WriteLine(str);