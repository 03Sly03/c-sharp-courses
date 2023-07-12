string Concataineur(int numero, params string[] chaines)
{
    string chainefinale = numero + " - ";
	foreach (var chaine in chaines)
	{
		chainefinale += chaine;
	}
	return chainefinale;
}

string[] mesChaines = { "Bonjour", "Tout", "Le Monde" };


Console.WriteLine(Concataineur(1, mesChaines));

Console.WriteLine(Concataineur(2, "Bonjour", "Tout", "Le Monde"));