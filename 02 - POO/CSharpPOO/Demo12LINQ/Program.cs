using Demo12LINQ;

List<int> l1 = new List<int> { 0, 1, 21, 1, 0, 321, 1, 0, 156, 464, 45, 0, 102, 0 };

List<int> l2 = new List<int> { 4,5,8,6,4,7,65465,9,4,58,5,96 };

List<Personne> personnes = new List<Personne>()
{
    new Personne(){ Prenom = "Guillaume", Nom = "Mairesse"},
    new Personne(){ Prenom = "Mathieu", Nom = "Dupont"},
    new Personne(){ Prenom = "José", Nom = "Doe"},
    new Personne(){ Prenom = "Rémy", Nom = "D"},
    new Personne(){ Prenom = "Clémence", Nom = "G"},
    new Personne(){ Prenom = "Aicha", Nom = "E"},
};

void AfficherListe<T>(string nom, List<T> values)
{
    Console.WriteLine(nom + " = " + string.Join(", ", values));
}


#region FIRSTORDEFAULT et FIND

// premier de la liste
Console.WriteLine(l1.FirstOrDefault()); 
// le premier qui respecte la condition ou default
Console.WriteLine(l1.FirstOrDefault(entier => entier == 21)); 
Console.WriteLine(l1.FirstOrDefault(entier => entier == 489));
Console.WriteLine(l1.FirstOrDefault(entier => entier > 48));

// Find marche prefsque pareil mails il ne vient pas de LINQ
Console.WriteLine(l1.Find(entier => entier == 21));
Console.WriteLine(l1.Find(entier => entier == 489));
Console.WriteLine(l1.Find(entier => entier > 48));

#endregion

Console.WriteLine("---------------------");

#region WHERE


// pour retourner une liste de résultats qui correspondent
//var l3 = l1.Where(i => i > 48).ToArray();
var l3 = l1.Where(i => i > 48).ToList();

Console.WriteLine(l3);

//foreach (var item in l3)
//{
//    Console.Write(item + ", ");
//}
//Console.WriteLine();

Console.WriteLine("l3 = " + string.Join(", ", l3));
#endregion

Console.WriteLine("---------------------");

#region SELECT
// équivalent au Map dans plusieurs autres langages
// on applique une fonction sur chaque éléments d'une liste

//List<double> l1double = (List<double>)l1; // IMPOSSIBLE

Func<int, double> cast = i => (double)i;

List<double> l1double = l1.Select(cast).ToList();

Console.WriteLine("l1double = " + string.Join(", ", l1double));
l1double.Clear();

foreach (int i in l1)
{
    l1double.Add(cast(i));
}
Console.WriteLine("l1double = " + string.Join(", ", l1double));

Console.WriteLine("---------------------");

Func<int, int> carre = i => i*i; // équivalent en fonction : int Carre(int i) { return i * i; }

List<int> l1carre = l1.Select(carre).ToList();
// équivalent
//List<int> l1carre = l1.Select(i => i * i).ToList();

Console.WriteLine("l1carre = " + string.Join(", ", l1carre));
l1carre.Clear();

foreach (int i in l1)
{
    l1carre.Add(carre(i)); // l1carre.Add(i * i);
}

Console.WriteLine("l1carre = " + string.Join(", ", l1carre));

Console.WriteLine("---------------------");


string Capitalize(string str)
{
    return str[0].ToString().ToUpper() + str.Substring(1).ToLower();
}


List<string> prenoms = personnes.Select(p => p.Prenom).ToList();
Console.WriteLine("prenoms = " + string.Join(", ", prenoms));

List<string> noms = personnes.Select(p => p.Nom).ToList();
Console.WriteLine("noms = " + string.Join(", ", noms));

Func<Personne, string> fonctionNomComplet = p => p.Nom.ToUpper() + " " + Capitalize(p.Prenom);

List<string> nomComplet = personnes.Select(fonctionNomComplet).ToList();
Console.WriteLine("nomComplet = " + string.Join(", ", nomComplet));

#endregion

Console.WriteLine("---------------------");

#region SORT et ORDERBY

l1.Sort();

AfficherListe("L1 triée", l1);

//personnes.Sort(); // Erreur car on ne sait pas comment trier des personnes

List<Personne> personnesOrdonnees = personnes.OrderBy(p => p.Nom).ToList(); // on trie sur le champ nom

foreach(Personne p in personnesOrdonnees)
{
    Console.WriteLine(p.Nom);
}

List<string> nomCompletOrdonnés = personnesOrdonnees.Select(fonctionNomComplet).ToList();

AfficherListe("nomCompletOrdonnés", nomCompletOrdonnés);

// pour aller plus loin avec le order by (exemple de la doc)
IEnumerable<IGrouping<char, Personne>> personnesOrdonneesPremiereLettre =
    from personne in personnes
    group personne by personne.Nom[0];

foreach (IGrouping<char, Personne> studentGroup in personnesOrdonneesPremiereLettre)
{
    Console.WriteLine(studentGroup.Key);
    foreach (Personne student in studentGroup)
    {
        Console.WriteLine("   {0}, {1}",
                  student.Nom, student.Prenom);
    }
}

#endregion

Console.WriteLine("---------------------");

#region MIN MAX AVERAGE SUM

Console.WriteLine(l1.Min());
Console.WriteLine(l1.Max());
Console.WriteLine(l1.Average());
Console.WriteLine(l1.Sum());

#endregion

Console.WriteLine("---------------------");

#region AGGREGATE
// appellée Reduce dans d'autres langages
// son but est de réduire un ensemble à une seule valeur

var resultat = l2.Aggregate((a, v) => a + v); // fait l'addition de toutes les valeurs de la liste
Console.WriteLine(resultat);
resultat = l2.Aggregate(22, (a, v) => a + v); // fait l'addition de toutes les valeurs de la liste en ajoutant 22 au début
Console.WriteLine(resultat);

resultat = l2.Aggregate((a, v) => a * v); // fait la multiplication de toutes les valeurs de la liste
Console.WriteLine(resultat);

string toutLeMonde = personnes.Aggregate("Tout le monde :", (concat, pers) => concat + " " + pers.Nom);
Console.WriteLine(toutLeMonde);

#endregion