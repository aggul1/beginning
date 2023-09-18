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

          Console.WriteLine("Wie groß soll das Array sein?");
          int aa = Convert.ToInt32(Console.ReadLine());
          int[] myarray = new int[aa];
          for(int i=0; i<aa; i++)
              {
                int zahl = Convert.ToInt32(Console.ReadLine());
                myarray[i] = zahl;
              }
          Console.WriteLine("------------------");    
          Console.WriteLine($"Die kleinste Zahl ist: {myarray.Min()}");    
          Console.WriteLine($"Die groesste Zahl ist: {myarray.Max()}"); 
          Console.WriteLine($"Der Durchschnittswert beträgt: {myarray.Average()}"); 
}
}
}