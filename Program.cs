using System.ComponentModel;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Gib einen Zeitraum in Sekunden an:");
      Console.WriteLine("------------------");
      int sek = Convert.ToInt32(Console.ReadLine());
      int days = sek / 86400;
      int hours = sek % 86400 / 3600;
      int min = sek % 86400 % 3600 / 60;
      int sek1 = sek % 86400 % 3600 % 60 % 60;

      Console.WriteLine($"Tage:{days}, Stunden: {hours}, Minuten: {min}, Sekunden: {sek1}");
      }
    }
  }

///1 tag = 86400 sek
///1 stunde = 3600 sek
///1 1 min = 60 sek