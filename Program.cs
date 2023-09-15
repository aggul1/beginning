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

        Console.WriteLine("Gebe mir ein Rechenzeichen");
        string zahl1 = Console.ReadLine();
        string zahl2 = Console.ReadLine();
        
        string zeichen = Console.ReadLine();
        switch(zeichen)
        {
            case "+":
                int ergebnis = AdditionwithReturn(zahl1,zahl2);
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
    
    
static int AdditionwithReturn(string zahl1, string zahl2)
     {
        int numero1 = Convert.ToInt16(zahl1);
        int numero2 = Convert.ToInt16(zahl2);

        return numero1+numero2;
     }

     static void Addition(string zahl1, string zahl2)
     {
        int numero1 = Convert.ToInt16(zahl1);
        int numero2 = Convert.ToInt16(zahl2);
    }

    static void Substraction(string zahl1, string zahl2)
     {
        int numero1 = Convert.ToInt16(zahl1);
        int numero2 = Convert.ToInt16(zahl2);
    }

    static void Multiplication(string zahl1, string zahl2)
     {
        int numero1 = Convert.ToInt16(zahl1);
        int numero2 = Convert.ToInt16(zahl2);
    }

    static void Division(string zahl1, string zahl2)
     {
        int numero1 = Convert.ToInt16(zahl1);
        int numero2 = Convert.ToInt16(zahl2);
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
        

