
using Exercice07Pile.Classes;

Pile<string> pileString = new Pile<string>();

pileString.Empiler("Bonjour");
pileString.Empiler("Test");
pileString.Empiler("ABC");

Console.WriteLine(pileString);

var element = pileString.Depiler();

Console.WriteLine(element);
Console.WriteLine(pileString.Depiler());
Console.WriteLine(pileString.Depiler());
Console.WriteLine(pileString.Depiler());

Pile<Personne> pilePersonne = new Pile<Personne>();


pilePersonne.Empiler(new Personne());
pilePersonne.Empiler(new Personne());

Personne maPersonne = new Personne();
maPersonne.Prenom = "Guillaume";
maPersonne.Nom = "Mairesse";
maPersonne.Age = 56;

Personne maPersonne2 = new Personne()
{
    Prenom = "Guillaume",
    Nom = "Mairesse",
    Age = 56
};


pilePersonne.Empiler(maPersonne2);