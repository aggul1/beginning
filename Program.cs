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
    {        static void Main(string[] args)
        {
           /*
            Erstelle ein Array mit folgenden Zahlen [20,50,11,2,49]
            Gebe die Werte innerhalb des Arrays nacheinander aus
            Gebe die Werte innerhalb des Arrays rückwärts aus
            Gebe die Werte in einer sortierten Reihenfolge aus ([20,50,11,2,49] => [2,11,20,49,50]) (Sort Ascending)
            Gebe die Werte in einer sortierten Reihenfolge rückwärts aus ([20,50,11,2,49] => [50,49,20,11,2]) (Sort Descending)
            */
  
          
          int[] myarray = new int[5];
          int a = myarray[0] = 50;
          int b = myarray[1] = 20;
          int c = myarray[2] = 11;
          int d = myarray[3] = 2;
          int e = myarray[4] = 49;
            Console.WriteLine("---------------vorwärts");
            for(int i=0; i<=4; i++)
            {
                Console.WriteLine(myarray[i]);
            }
            Console.WriteLine("---------------rückwärts");

            for(int j=4; j>=0; j--)
            {
                Console.WriteLine(myarray[j]);
            }
            Console.WriteLine("---------------vorwärts sortiert");

            for(int k=0; k<=4; k++)
            {
                Array.Sort(myarray);
                Console.WriteLine(myarray[k]);
            }
            Console.WriteLine("---------------rückwärts sortiert");

            for(int l=4; l>=0; l--)
            {
                Array.Sort(myarray);
                Console.WriteLine(myarray[l]);
            }
        }
    }
}