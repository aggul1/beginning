using System.Numerics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        // Frage den Nutzer nach 2 Zahlen und gebe das Ergebnis auf der Console aus /Subtraktion)
        Console.WriteLine("Welche 2 Zahlen möchtest du voneinander subtrahieren?");
        int zahl1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Und?");
        int zahl2 = Convert.ToInt16(Console.ReadLine());
        int ergebnis = zahl1 - zahl2;
        Console.WriteLine($"{zahl1} - {zahl2} = {ergebnis}");


    }   
}
}