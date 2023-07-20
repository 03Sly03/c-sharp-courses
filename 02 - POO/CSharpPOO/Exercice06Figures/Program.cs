using Exercice06Figures.Classes;
using Exercice06Figures.Classes.Figures;

Point pointOrigineCarre = new Point(2,4);

Console.WriteLine(pointOrigineCarre);

Carre carre = new Carre(pointOrigineCarre, 2);

Console.WriteLine(carre.A);
Console.WriteLine(carre.B);