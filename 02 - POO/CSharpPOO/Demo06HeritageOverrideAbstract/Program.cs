using Demo06HeritageOverrideAbstract;


// Animal étant maintenant une classe abstraite ON NE PEUT PLUS L'INSTANCIER
//Animal animal = new Animal("nom animal", true);
//Console.WriteLine(animal.Nom);
//animal.SeDeplacer();
//animal.Respirer();
//animal.Crier();

// Mammifere étant maintenant une classe abstraite ON NE PEUT PLUS L'INSTANCIER
//Mammifere mammifere = new Mammifere("nom mamifere", true, "Féminin");
//Console.WriteLine(mammifere.Nom);
//mammifere.SeDeplacer();
//mammifere.Respirer();
//mammifere.Crier();

Animal chien = new Chien("Pepette", true, "femelle", "Rottweiler");
//Console.WriteLine(chien.Nom);
//chien.SeDeplacer();
//chien.Respirer();
//chien.Crier();
//chien.Allaiter();

Animal chat = new Chat("Mistigri", true, "femelle", false);
//Console.WriteLine(chat.Nom);
//chat.SeDeplacer();
//chat.Respirer();
//chat.Crier();
//chat.Crier("le cri du chat");
//chat.Allaiter();


List<object> animals = new List<object>
{
    1,
    "test",
    chat,
    chien
};

// operateur is
foreach (object mon_objet in animals)
{
    //ani.Crier();

    if (mon_objet is Animal mon_animal) // on teste si c'est un animal et on l'envoie si c'est le cas dans la variable mon_animal
    {
        Console.WriteLine("C'est un animal !");
        if (mon_objet is Chat mon_chat)
        {
            Console.WriteLine("C'est un chat !");
            mon_chat.Allaiter();
        }
        if (mon_animal is Chien)
        {
            Console.WriteLine("C'est un chien !");
        }
        mon_animal.Crier();
    }
    else
        Console.WriteLine("Ce n'est pas un animal !");

    Console.WriteLine("-----------------------------------------");
}


// operateur as
foreach (object mon_objet in animals)
{
    Chat? mon_chat = mon_objet as Chat;
    Console.WriteLine("Contenu de la variable mon_chat (vide si null) : " + mon_chat);
}