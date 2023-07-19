using Demo07Interfaces.Classes;
using Demo07Interfaces.Classes.Mammiferes;
using Demo07Interfaces.Classes.Oiseaux;
using Demo07Interfaces.Classes.Poissons;
using Demo07Interfaces.Interfaces;

Baleine baleine = new Baleine();
baleine.Nager();
Console.WriteLine(baleine.Nom);

//Mammifere baleine2 = new Baleine();
//Animal baleine2 = new Baleine();
//object baleine2 = new Baleine();

IPeutNager baleine2 = new Baleine();
baleine2.Nager();
//Console.WriteLine(baleine2.Nom); //mauvais type de variable

Baleine baleine3 = (Baleine) baleine2;  // ereur si impossible
//Baleine baleine3 = baleine2 as Baleine; // null si impossible
Console.WriteLine(baleine3.Nom);


Exocet poissonVolant = new Exocet(); 
// types compatibles : object, Animal, Poisson, IPeutVoler, IPeutNager
poissonVolant.Nager();
poissonVolant.SEnvoler();
poissonVolant.Atterrir();


IPeutNager poissonVolant2 = new Exocet();
poissonVolant2.Nager();
//poissonVolant2.SEnvoler();
//poissonVolant2.Atterrir();



List<Animal> animaux = new List<Animal>()
{
    new Baleine(),
    new Baleine(),
    new Baleine(),
    new Baleine(),
    new Baleine(),
    new ChauveSouris(),
    new Pigeon(),
    new Exocet(),
    new Exocet(),
    new Perche()
};


List<IPeutNager> nageurs = new List<IPeutNager>()
{
    new Baleine(),
    new Baleine(),
    new Baleine(),
    new Baleine(),
    new Baleine(),
    //new ChauveSouris(),
    //new Pigeon(),
    new Exocet(),
    new Exocet(),
    new Perche()
};

List<IPeutVoler> volants = new List<IPeutVoler>()
{
    //new Baleine(),
    //new Baleine(),
    //new Baleine(),
    //new Baleine(),
    //new Baleine(),
    new ChauveSouris(),
    new Pigeon(),
    new Exocet(),
    new Exocet(),
    //new Perche()
};

Console.WriteLine("-------------------");


foreach (Animal animal in animaux)
{
    if (animal is IPeutNager nageur)
    {
        Console.WriteLine(animal.GetType().Name + " => Cet Animal peut nager !");
        nageur.Nager();
    }
    else
    {
        Console.WriteLine(animal.GetType().Name + " => Cet Animal ne peut pas nager !");
    }

    if (animal is IPeutVoler volant)
    {
        Console.WriteLine(animal.GetType().Name + " => Cet Animal peut voler !");
        volant.SEnvoler();
        volant.Atterrir();
    }
    else
    {
        Console.WriteLine(animal.GetType().Name + " => Cet Animal ne peut pas voler !");
    }
    Console.WriteLine("-------------------");
}