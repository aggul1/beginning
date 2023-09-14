using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args){
        
        //Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus

        // int ergebnis = 1+1;
        // Console.WriteLine(ergebnis);


            //Aufgabe 2: Lasse den Nutzer zwei Zahlen eingeben und gebe die Summe auf der Console aus

            // Console.WriteLine("Gebe 2 Zahlen an");
            // int zahl1 = Convert.ToInt16(Console.ReadLine());
            // int zahl2 = Convert.ToInt16(Console.ReadLine());
            // int ergebnis = zahl1 + zahl2;
            // Console.WriteLine($"Das Ergebnis lautet: {ergebnis}");
            

            //Aufgabe 3: Lasse den Nutzer eine Zahl eingeben und gebe alle Zahlen
            //           bis einschließlich der eingegeben Zahl aus

            // Console.WriteLine("Gib eine Zahl an");
            // int startwert = 0;
            // int userzahl = Convert.ToInt16(Console.ReadLine());
            // while(startwert<=userzahl)
            // {
                
            //     Console.WriteLine(startwert);
            //     startwert++;

            // }

            //Aufgabe 4: Lasse den Nutzer eine Zahl eingeben und gebe nur die geraden Zahlen aus.
            //           (Hinweis: Modulo operator. => Geteilt durch 2,
            //                  wenn der Rest 0 ist, ist die Zahl gerade)

            Console.WriteLine("Gib eine Zahl an");
            int startwert = 0;
            int userzahl = Convert.ToInt16(Console.ReadLine());

            for (startwert = 0; startwert <= userzahl; startwert++)
            {
                if (startwert % 2 ==0)
                {
                    Console.WriteLine(startwert);
                }

            }

            //Aufgabe 5: Lasse den Nutzer eine Zahl eingeben und berechne von dieser Zahl die Fakultät.


            //Aufgabe 6a: Lasse den Nutzer einen Text eingeben und gebe den Text nur in Großbuchstaben aus
            //Aufgabe 6b: Gebe die Länge des Textes aus
            //Aufgabe 6c: Zähle wie oft der Buchstabe a vorkommt.
            //Aufgabe 6d: Gebe nur einen Teil des Textes aus. Ab Position 3, und dann die nächsten 5 Buchstaben


}
}
}
