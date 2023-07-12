Console.WriteLine("Enumération du tableau avec un foreach :");
string[] moisAnnee = {
    "Janvier",
    "Février",
    "Mars",
    "Avril",
    "Mai",
    "Juin",
    "Juillet",
    "Août",
    "Septembre",
    "Octobre",
    "Novembre",
    "Décembre"
};

//string[] moisAnnee = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames; // attention c'est un tableau à 13 valeurs

//for (int i = 0; i < moisAnnee.Length-1; i++)
//{
//    //moisAnnee[i] = moisAnnee[i][0].ToString().ToUpper() + moisAnnee[i].Substring(1).ToLower();
//    moisAnnee[i] = moisAnnee[i].Substring(0, 1).ToUpper() + moisAnnee[i].Substring(1).ToLower();
//}



string tabulations = "";
foreach (string mois in moisAnnee)
{
    Console.WriteLine(tabulations + mois);
    tabulations += "\t";
}
