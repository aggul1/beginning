using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args){
        
        //     Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden? (0,1,2,...,x)");
        //     int untilNumber = Convert.ToInt16(Console.ReadLine());
            
        //     int ergebnis = 0;
        //     for(int i = 0; i <=untilNumber;i++)
        //     {
        //             ergebnis+= i;
        //             Console.WriteLine($"Added number {i}, current result {ergebnis}");
        //     }

                Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden? (0,1,2,...,x)");
            
                int untilnumber = Convert.ToInt16(Console.ReadLine());

                int i=0;
                int zahl=0;
                int ergebnis=0;

                while(i<untilnumber)
                {
                    zahl=i+1;
                    ergebnis+=zahl;
                    Console.WriteLine($"Added number {i}, current result {ergebnis}");
                    i++;
                }
}
}
}
