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
            //Frage den Nutzer wieviele Texte er in einem Array speichern will.
            //Initalisiere das Array in der gewünschten größe
            // string[] myText = new string[5];
            //Lasse den Nutzer das Array nacheinander mit Texten befüllen.
            //Gebe die Texte mit mindestens 20 Zeichen aus, fülle den Text mit Leerzeichen auf von Links wenn kleiner.
            /* */
            Console.WriteLine("Wie groß soll dein Array sein?");
            int arrayanzahl = Convert.ToInt32(Console.ReadLine());
            string[] myText = new string[arrayanzahl];
            for(int position=0; position<arrayanzahl; position++)
            {
                string text1 = Console.ReadLine();
                myText[position]=text1;
            }
            foreach(string entry in myText)
            {
                Console.WriteLine(entry.PadLeft(20,' '));
            } 
        }
}
}       

