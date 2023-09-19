using System.ComponentModel;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using System.Globalization;

namespace HelloWorld
{
    class Program
    {
      static void Main(string[] args)
        {
          List<int> myList = new List<int>() {2,5,7,9,15,17,19};
          int summefromthemethod = Sum(myList);
          Console.WriteLine($"{summefromthemethod}");
        }
        
      static int Sum(List<int> tocalculate)
      {
        int summe = 0;
        foreach(int value in tocalculate)
          {
            summe += value;
          }
        return summe;
      }   
    }
}
    