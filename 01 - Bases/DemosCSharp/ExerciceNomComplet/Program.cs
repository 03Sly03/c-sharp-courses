string NomComplet(string prenom, string nom)
{
    //return prenom + " " + nom;
    return $"{prenom} {nom}";
}


string nomPrenom = NomComplet("Guillaume", "MAIRESSE");

Console.WriteLine(nomPrenom);
Console.WriteLine(NomComplet("Titi", "TOTO"));


// cette fonction effectue la même tâche mais ce n'était pas ce qui était demandé
void AfficheNomComplet(string prenom, string nom)
{
    Console.WriteLine($"{prenom} {nom}");
}