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
        
        int zahl1 = 10;
        int zahl2 = 5;
        Console.WriteLine("Gebe mir ein Rechenzeichen");
        string zeichen = Console.ReadLine();
        switch(zeichen)
        {
            case "+":
            Console.WriteLine(zahl1+zahl2);
            break;
            case "-":
            Console.WriteLine(zahl1-zahl2);
            break;
            case "*":
            Console.WriteLine(zahl1*zahl2);
            break;
            case "/":
            Console.WriteLine(zahl1/zahl2);
            break;
            default:
                Console.WriteLine("Ich kenne dieses Rechenzeichen nicht");
            break;
        }
                }
    }
}
        

