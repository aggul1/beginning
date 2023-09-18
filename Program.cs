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

      Console.WriteLine("Gib das Limit an, bis zu welchem die Fibonacci Reihe ausgegeben werden soll");
      Console.WriteLine("------------------");
      int limit = Convert.ToInt32(Console.ReadLine());
      int zahl1 = 0;
      int zahl2 = 1;
      int ergebnis = 0;
      for(; zahl1+zahl2 < limit;)
      {
        ergebnis = zahl1 + zahl2;
        Console.WriteLine(ergebnis);
        zahl1 = zahl2;
        zahl2 = ergebnis;
      }
    }
  }
}
