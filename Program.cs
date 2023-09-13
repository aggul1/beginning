using System.Numerics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumberList = new List<int>();
            int user_zahl = 0;
            do
            {
                //codeblock
                Console.WriteLine("Gebe mir eine Zahl");
                user_zahl = Convert.ToInt32(Console.ReadLine());
                myNumberList.Add(user_zahl);
            } while(user_zahl > 0);

            //Summiere alle Zahlen auf
            int ergebnis = 0;
            foreach(int zahl in myNumberList)
            {
                ergebnis += zahl;
            }

        Console.WriteLine($"Das Eegebnis ist {ergebnis}");
        }   
    }
}
