using Demo10CreationGeneriques.Classes;

////Demarreur<List<string>> t = new Demarreur<List<string>>();
////Demarreur<Queue<string>> t2 = new Demarreur<Queue<string>>();
////Demarreur<string[]> t3 = new Demarreur<string[]>();

//Demarreur<Ordinateur> demarreurDOrdinateur = new Demarreur<Ordinateur>();

//demarreurDOrdinateur.DemarreCetteChose(new Ordinateur());
////demarreurDOrdinateur.DemarreCetteChose(new Tronconeuse());


//Arreteur arreteur = new Arreteur();

//arreteur.ArreteCetteChose<Tronconeuse>(new Tronconeuse());
//arreteur.ArreteCetteChose(new Ordinateur());


Scribe.EcritPlusieursFois("chaine",2);
Scribe.EcritPlusieursFois(1,5);
Scribe.EcritPlusieursFois(1.0,3);
Scribe.EcritPlusieursFois(new Tronconeuse(),1);
