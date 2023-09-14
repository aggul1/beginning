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
        

            //Aufgabe 7: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“
            Console.WriteLine("Schreibe etwas!");
            string mytext = Console.ReadLine();
            string mytext2 = mytext.Replace("g","u").Replace("G","U");

            Console.WriteLine(mytext2);

            //Aufgabe 8: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 20 Stellen mit einem y von links auf
            //Aufgabe 9: Frage den Nutzer nach einer Eingabe mit Semikolons ( ; ) und Splitte die Eingabe an diesem Zeichen. Gebe die einzelnen Werte auf der Console aus.
            //Aufgabe 10: Frage den Nutzer nach einer Eingabe und überprüfe die Texteingabe des Nutzers, ob die Zeichen „abc“ in der Eingabe enthalten sind. Gebe true oder false auf der Konsole aus.

 


}
}
}
