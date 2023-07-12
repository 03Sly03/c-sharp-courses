(int, double, string) t1 = (5,4.5,"test");

Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
Console.WriteLine(t1.Item3);


(int MonInt, double MonDouble, string MonString) t2 = t1;

Console.WriteLine($"Tuple with elements {t2.MonDouble} and {t2.MonInt}.");
Console.WriteLine(t2.Item3);
Console.WriteLine(t2.MonString);


(string NomComplet, string NomMaj, string Prenom) NomComplet(string nom, string prenom)
{
    var nomMaj = nom.ToUpper();
    var t = (nomMaj + " " + prenom, nomMaj, prenom);
    return t;
}



var t3 = NomComplet("Guillaume", "Mairesse");

Console.WriteLine(t3);
Console.WriteLine(t3.NomComplet);

// https://learn.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/value-tuples