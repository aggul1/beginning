using System.Numerics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumberList = new List<int>();
            Console.WriteLine("Sage mir wieviele Zahln du in deine Liste hinzufügen möchtest");
            int amountNumbers = Convert.ToInt32(Console.ReadLine());

            while(myNumberList.Count < amountNumbers)
            {
                Console.WriteLine("Gebe mir eine Zahl");
                myNumberList.Add(Convert.ToInt32(Console.ReadLine()));
            }
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
