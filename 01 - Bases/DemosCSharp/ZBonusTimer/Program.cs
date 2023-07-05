DateTime fin = new DateTime(2023, 07, DateTime.Now.Day, 13, 30, 0);
var delta = fin - DateTime.Now;
Console.ForegroundColor = ConsoleColor.DarkRed;

while (delta.TotalSeconds > 0)
{
    delta = fin - DateTime.Now;
    Console.WriteLine(delta.ToString(@"hh\:mm\:ss"));
    Thread.Sleep(500);
    Console.Clear();
}

Console.WriteLine("TEMPS ECOULÉ !");
Console.ReadKey();