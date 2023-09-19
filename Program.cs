using System.ComponentModel;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using System.Globalization;

namespace HelloWorld
{
    class Program
    {        static void Main(string[] args)
        {
            /*
            // Passe die Methode "Fahren" so an, dass 
            //- bei einer Geschwindigkeit von 0 die Methode "steht" zurück gibt: Hinweis: return
            //- bei einer Geschwindigkeit von 1-10 "schleicht" zurück gibt
            //- bei einer Geschwindigkeit von 11-50 "fährt langsam" zurück gibt
            //- bei einer Geschwindigkeit von 51-100 "fährt schnell" zurück gibt
            //- bei einer Geschwindigkeit über 100 "rast" zurück gibt.

            //Bau die Ausgabe so, dass nach jedem Aufruf folgende Texte ausgegeben werden können. 
            //Das Auto steht.
            //Das Auto schleicht.
            //Das Auto fährt langsam.
            //Das Auto fährt schnell. 
            //Das Auto rast.
            */
            Console.WriteLine("Wie schnell fährt das Auto?");
            int geschwindigkeit = Convert.ToInt32(Console.ReadLine());
            string kmh = Fahren(geschwindigkeit);
            Console.WriteLine($"Das Auto {kmh} ");
        }

        static string Fahren(int geschwindigkeit)
        {
              if(geschwindigkeit==0)
              {
                return "steht.";
              }
              else if(geschwindigkeit<=10 && 1<=geschwindigkeit)
              {
                return "schleicht.";
              }
              else if(geschwindigkeit<=55 && 11<=geschwindigkeit)
              {
                return "fährt langsam.";
              }
              else if(geschwindigkeit<=100 && 51<=geschwindigkeit)
              {
                return "fährt schnell.";
              }
              else if(geschwindigkeit>100)
              {
                return "rast.";
              }
              else
              {
                return "Das Auto ist kaputt!!!";
              }
             
      
        }
    }
}