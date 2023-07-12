int CompteurDeLettreA(string chaine)
{
    int compteA = 0;
	foreach (char c in chaine.ToLower())
		if (c == 'a')
			compteA++;
	return compteA;
}

Console.WriteLine(CompteurDeLettreA("C'est le b-a ba"));
Console.WriteLine(CompteurDeLettreA("mixer"));