using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Erstelle eine Randomzahl, die der Nutzer erraten soll. Frage den Nutzer nach einer Zahl zwischen 1 bis 100.
            // Wenn der Nutzer die Zahl trifft, hat er gewonnen. Wenn nicht, sage ob die Zal zu klein oder zu Groß ist.
            Console.WriteLine("Versuche die Zahl zwischen 1 und 100 zu erraten");

            Random random = new Random();
            int numberToGuess = random.Next(0,101);

            int userzahl = Convert.ToInt16(Console.ReadLine());

            while(numberToGuess != userzahl)
            {
                Console.WriteLine("Leider Falsch!");
                if(numberToGuess<userzahl)
                {
                    Console.WriteLine("Deine Zahl ist zu groß!");
                }
                else if(numberToGuess>userzahl)
                {
                    Console.WriteLine("Deine Zahl ist zu klein!");
                }
                userzahl= Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Glückwunsch du hast gewonnen!");
        }
    }
}
        

