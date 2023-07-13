using System.Text.RegularExpressions;

bool VerificationAdn(string chaineADN)
{
    if (chaineADN == "")
        return false;
    foreach (char chainon in chaineADN)
        if (!"actg".Contains(chainon)) // si on trouve une erreur
            return false;              // on sort de la fonction avec false
    return true;					   // si aucune erreur a été trouvée, on retourne true
}

string SaisieAdn(string message)
{
    string chaineAdn;
    bool chaineEstValide;

    do
    {
        Console.Write(message);
        chaineAdn = Console.ReadLine()!.Trim().ToLower();
        chaineEstValide = VerificationAdn(chaineAdn);
        if (!chaineEstValide)
            Console.WriteLine("Erreur de saisie !!!");
    } while (!chaineEstValide);

    return chaineAdn;
}

double Proportion(string chaine, string sequence)
{
    int nbOccurences = Regex.Matches(chaine, sequence).Count;
    double proportion = (double)nbOccurences * sequence.Length / chaine.Length;
    return proportion * 100;
}

string chaine = SaisieAdn("Veuillez saisir une chaine adn :");
string sequence = SaisieAdn("Veuillez saisir une sequence adn :");
Console.WriteLine("chaine : " + chaine);
Console.WriteLine("sequence : " + sequence);
double pct = Proportion(chaine, sequence);
Console.WriteLine($"Il y a {Math.Round(pct, 2)}% de \"{sequence}\" dans la chaine \"{chaine}\"");