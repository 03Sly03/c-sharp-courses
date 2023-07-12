void QuelleHeure(string heure = "12h00")
{
    Console.WriteLine($"Il est {heure}");
}


QuelleHeure("14h00");
QuelleHeure();





void BonjourQuelleHeure(string nom, string heure = "12h00", params string[] chaines) // ATTENTION A L'ORDRE : +obligatoire > +facultatifs > 1params
{
    Console.WriteLine($"Bonjour {nom}, il est {heure}");
    foreach (string chaine in chaines)
        Console.WriteLine(chaine);
}

BonjourQuelleHeure("Guillaume");
BonjourQuelleHeure("Thibault", "14h00");
BonjourQuelleHeure("Thibault", "14h00", "chaine1", "chaine2");

// possible de préciser les nomc des paramètres
BonjourQuelleHeure(nom: "Guillaume", heure: "test", chaines: new string[] { "a", "b" });
BonjourQuelleHeure("Guillaume", chaines: new string[]{"a","b"});
BonjourQuelleHeure(nom: "Guillaume", chaines: new string[]{"a","b"});