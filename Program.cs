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
      Random random = new Random();
            
            int kapital = 10000;
            int anzahlSpiele = 0; 
            bool lostLastGame = false;
            int lastInset = 10;
            int geworfeneZahl = 0;
            while(kapital>0 || kapital > 20000) 
            {
                lastInset = BerechneEinsatz(kapital, lostLastGame, lastInset, geworfeneZahl);

                if(lastInset > kapital)
                {
                    lastInset = kapital;
                }

                kapital -= lastInset;
                geworfeneZahl = random.Next(0,37);
                anzahlSpiele += 1;

                if(geworfeneZahl % 2 == 0 && geworfeneZahl != 0) 
                {
                    kapital = kapital + 2*lastInset;
                    lostLastGame = false;
                }
                else
                {
                    lostLastGame = true;
                }
                Console.WriteLine($"Anzahl Spiel: {anzahlSpiele}, Geworfene Zahl {geworfeneZahl}, Aktuelles Kapital: {kapital}, Letzter Einsatz: {lastInset}");

                Thread.Sleep(10);
            }
        }

        static int BerechneEinsatz(int kapital, bool lostLastGame, int lastInset, int geworfeneZahl)
        {
            if(geworfeneZahl == 0)
            {
                return lastInset;
            }

            if(lostLastGame == false && kapital > 10000)
            {
                return 10;
            }
            else if (lostLastGame == true && kapital > 10000)
            {
                return Math.Min(lastInset*2,1000);
            }

            if(kapital < 10000)
            {
                int gesamtVerlust = 10000-kapital;
                return Math.Min(gesamtVerlust *2, 1000);
            }

            //Trifft nie zu aber C# will den case.
            return 10;
        }
          }
              
        }
    