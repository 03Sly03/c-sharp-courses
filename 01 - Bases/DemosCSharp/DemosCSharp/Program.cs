
//string? variable = "du texte";
string? variable = null;

string ageString = variable ?? "saisie vide !";
string ageString2 = variable == null ? "saisie vide !" : variable;

Console.WriteLine(ageString);
Console.WriteLine(ageString2);