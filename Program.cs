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

        

// Erstelle ein Array das Zahlen beinhaltet.
            // Es sollen 5 Zahlen eingegeben werden können
            // Befülle das Array in einer Schleife durch den Nutzer
            // Gebe am Ende:
            // - die kleinste Zahl aus
            // - die größte Zahl
            // - den Durchschnitt

            int[] mynumber = new int[5];
            for(int position=0; position < mynumber.Count(); position++)
            {
                int text1 = Convert.ToInt32(Console.ReadLine());
                mynumber[position]=text1;
            }
          Console.WriteLine("--------------");  
          Console.WriteLine(mynumber.Min());
          Console.WriteLine(mynumber.Max());
          Console.WriteLine(mynumber.Average());

        }
}
}       

