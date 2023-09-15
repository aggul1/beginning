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
            Addition(zahl1,zahl2);
            break;
            case "-":
            Substraction(zahl1,zahl2);
            break;
            case "*":
            Multiplication(zahl1,zahl2);
            break;
            case "/":
            Division(zahl1,zahl2);
            break;
            default:
                Console.WriteLine("Ich kenne dieses Rechenzeichen nicht");
            break;
        }
                }
    
    static void Addition(int zahl1, int zahl2){
        Console.WriteLine(zahl1+zahl2);
    }
    static void Substraction(int zahl1, int zahl2){
        Console.WriteLine(zahl1-zahl2);
    }
     static void Multiplication(int zahl1, int zahl2){
        Console.WriteLine(zahl1*zahl2);
    }
     static void Division(int zahl1, int zahl2){
        Console.WriteLine(zahl1/zahl2);
    }
    }

}
        

