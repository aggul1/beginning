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
           Console.WriteLine("Gib mir 2 Zahlen");
           int zahl1 = Convert.ToInt32(Console.ReadLine());
           int zahl2 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(zahl1%zahl2);
        }
}
}       

