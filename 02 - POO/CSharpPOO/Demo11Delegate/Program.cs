﻿using Demo11Delegate;

// fonctions locales
int Carre(int a)
{
    return a * a;
}

int Multiplication(int a, int b)
{
    return a * b;
}


Console.WriteLine(Carre);
Console.WriteLine(Carre(2));
Console.WriteLine(Multiplication(2,5));

#region Type Func
// Type Func 
Func<int, int> carre = Carre;
Func<int, int> carre2 = a => a * a; // une lambda expression aussi appelée fonction annonyme 
Func<int, int> carre3 = (int a) => a * a; 

Console.WriteLine(carre);
Console.WriteLine(carre(2));
Console.WriteLine(carre2(2));

Func<int, int, int> mul = Multiplication;
Func<int, int, int> mul2 = (a, b) => a * b;
Func<int, int, int> mul3 = (int a, int b) => a * b; // une seule instruction => lambda possible
Func<int, int, int> mul4 = delegate (int a, int b) // une ou plusieurs instructions => delegate (bloc d'instruction {} et types des paramètres obligatoires
{
    Console.WriteLine($"Je multiplie {a} et {b}.");
    return a * b; 
};
// équivalent sans le delegate et avec un "=>"
Func<int, int, int> mul5 = (int a, int b) =>
{
    Console.WriteLine($"Je multiplie {a} et {b}.");
    return a * b;
};

Console.WriteLine(mul);
Console.WriteLine(mul(2, 5));
Console.WriteLine(mul2(2, 6));
Console.WriteLine(mul4(2, 6));

#endregion

Console.WriteLine("-----------------------------------");

Calculatrice cal = new Calculatrice();

Func<int, int, int> add = cal.Addition; // Func
Console.WriteLine(add(1,2));

cal.CalculerEtAfficher(10, 20, Multiplication);
cal.CalculerEtAfficher(10, 20, cal.Addition);
cal.CalculerEtAfficher(10, 20, add);
cal.CalculerEtAfficher(10, 20, mul4);
cal.CalculerEtAfficher(10, 20, (a,b) => a % b);
cal.CalculerEtAfficher(30, 10, (a,b) => a / b);
cal.CalculerEtAfficher(30, 10, delegate (int a, int b) { return a / b; });


Console.WriteLine();


void Afficher(string texte)
{
    Console.WriteLine(texte);
}
void AfficherBonjour()
{
    Console.WriteLine("Bonjour");
}

Action<string> afficher = Afficher;
Action afficherB = AfficherBonjour;