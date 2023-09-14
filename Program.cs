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
        
            //Aufgabe 11: Frage den Nutzer nach einer Zahl und zähle von dieser Rückwärts bis 0

                // Console.WriteLine("Gib mir eine Zahl!");
                // int counter = Convert.ToInt16(Console.ReadLine());
                // while(counter>=0)
                // {
                //     Console.WriteLine(counter);
                //     counter--;                 
                // }

            //Aufgabe 12: Laufe mit einer For-Schleife über die Namen der Azubis & Studenten. Wenn der Name des Azubis ein „e“ enthält, gebe den Namen aus, ansonsten nicht.

    //       List<string> names = new List<string> {"Luca", "Katharina", "Hans", "Linh", "Marcia", "Benny", "Niklas", "Lea"};

    //         foreach(string name in names)
    //         {
    //             if(name.Contains('e'))
    //             {
    //                 Console.WriteLine(name);
    //             }
    //         }
    //     }
    // }

            //Aufgabe 12b: Wiederhole das Ganze und lass den Nutzer einen Buchstaben bestimmen, nach dem gesucht wird.

            List<string> names = new List<string> {"Luca", "Katharina", "Hans", "Linh", "Marcia", "Benny", "Niklas", "Lea"};
            Console.WriteLine("Welchen Buchstaben möchtest du assortieren?");
            string letter = Console.ReadLine();
            foreach(string name in names)
            {
                if(name.Contains(letter))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}

            //Aufgabe 13: Frage den Nutzer  wie viele Einträge er in einem int-Array haben möchte. Initialisiere ein int-Array von dieser Größe und befülle dieses Int Array in einer Schleife, indem du den Nutzer jedes Mal frägst, welche Zahl eingetragen werden soll.  

            //           => Gebe anschließend alle Zahlen nacheinander nochmal aus

            //Aufgabe 13b: Gehe das Int-array durch und gebe den Maximal-Wert aus, Minimal-Wert und den Durchschnitt.
 




