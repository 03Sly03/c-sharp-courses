long Soustraire(long a, long b)
{
    Console.WriteLine($"Je soustrait {a} et {b}");
    return a - b;
}


long sub = Soustraire(2, 1);
Console.WriteLine("Résultat : " + sub);


sub = Soustraire(20, 100);
Console.WriteLine("Résultat : " + sub);