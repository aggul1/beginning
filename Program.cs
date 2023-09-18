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

          Console.WriteLine("Gib eine Zahl ein");
          Console.WriteLine("------------------");
          int zahl = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("------------------");
          for(; zahl>=0; zahl--)
          {
            Console.WriteLine(zahl);
            
          }
}
}
}