
//Console.WriteLine("Saisissez votre age :");
//int age = 0;
//try // on teste un bloc d'instructions
//{
//    throw new Exception("Ya un gros problème...");
//    age = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex) // si on attrape ce type d'exception
//{
//    Console.WriteLine("J'ai une FormatException !!!");
//    Console.WriteLine("Infos : " + ex.Message);
//    //throw;
//}
//catch (Exception ex) // si on attrape ce type d'exception
//{
//    Console.WriteLine("Autre exception :" + ex.Message);
//    //throw ex; // change le StackTrace, son origine sera ici => cette ligne
//    throw; // conserve toute les informations de l'exception => le throw dans le bloc try
//}
//finally // que l'on attrape ou non une exception, ce bloc est exécuté
//{

//}

//Console.WriteLine(age);


using Demo13Exceptions;

static void RecupererAgeAndPhone()
{
    Personne p = new Personne();
    bool saisieInvalide = true;

    do
    {
        Console.Write("Merci de saisir votre age : ");
        try
        {
            p.Age = Convert.ToInt32(Console.ReadLine());
            saisieInvalide = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType());
            Console.WriteLine("Merci de saisir l'age dans un format correct");
        }
    } while (saisieInvalide);

    saisieInvalide = true;
    do
    {
        Console.Write("Merci de saisir le téléphone : ");
        try
        {
            p.Telephone = Console.ReadLine();
            saisieInvalide = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType());
            Console.WriteLine("Merci de saisir le téléphone dans un format correct");
        }
    } while (saisieInvalide);
    Console.WriteLine(p.Age);
    Console.WriteLine(p.Telephone);
}



RecupererAgeAndPhone();