string[] joursSem = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi",
"Samedi", "Dimanche"};

int i = 0;

foreach (string jour in joursSem)
{
    i++;
    Console.WriteLine(i);
    Console.WriteLine(jour);
    //jour = "test";

    string j = "le jour est " + jour;
    Console.WriteLine(j);
}



for (i = 0; i < joursSem.Length; i++)
{
    joursSem[i] = "test";
    Console.WriteLine(joursSem[i]);

}