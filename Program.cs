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
        if(zeichen == "+")
        {
            Console.WriteLine(zahl1+zahl2);
        }
        else if(zeichen == "-")
        {
            Console.WriteLine(zahl1-zahl2);
        }
        else if(zeichen == "*")
        {
            Console.WriteLine(zahl1*zahl2);
        }
        else if(zeichen == "/")
        {
            Console.WriteLine(zahl1/zahl2);
        }
                }
    }
}
        

