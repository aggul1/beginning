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
           Erzeuge eine ganzzahlige Zufallszahl k im Bereich[0...36]. die Zahl k ist das Ergebnis
           eines Roulette-Wurf. Simuliere nun das Spiel:
            •   Sie gehen mit $10.000 in ein Spielkasino und setzen $10 auf Pair:
                o   Wenn k gerade ist und k ungleich 0 ist, erhalten Sie nach dem nächsten Spiel $20 (Gewinn = doppelter Einsatz bei Erfolg).
                o   Wenn k=0, bleibt Ihr Einsatz bestehen.
                o   Wenn k ungerade ist, verlieren Sie Ihren Einsatz.
            •   Du machst n Spiele mit der folgenden Strategie:
                o   Wenn du mindestens $10.000 besitzt und das letzte Spiel gewonnen hast, setze $10.
                o   Wenn du mindestens 10.000 $ besitzt, aber das letzte Spiel verloren hast, verdoppelst du deinen Einsatz.
                o   Wenn du weniger als 10.000 $ hast, verdoppelst du deinen Gesamtverlust.
                o   Wenn dein Geld für den geplanten Zug nicht ausreicht, wird das komplette Restkapital eingesetzt.
                o   Wenn du den maximal zulässigen Einsatz von $1.000 überschreiten würdest, setzt du nur $1.000.
            Gebe für jedes Spiel die folgenden Informationen an:
            Anzahl des Spiels, die geworfene Zahl, Kapital davor, Kapital danach, Verwende dazu die Methode String. Format mit dem $ -Operator.
            */

          Random random = new Random();
          int geld = 10000;
          int anzahlspiele=0;
          while(geld>0)
          {
              int geworfenezahl = random.Next(0,37);
              int einsatz = 10;
              anzahlspiele += 1;

                  if(geld>=10000)  //mehr als 10000$
                  {

                    if(geworfenezahl % 2 == 0)
                    {
                      einsatz = 10;
                      geld += einsatz;
                    }

                    else if(geworfenezahl != 0)
                    {
                      geld -= einsatz;
                      einsatz = einsatz*2;
                    }
                    else if(geworfenezahl == 0)
                    {
                      geld -= einsatz;
                    }

                  }  

                  if(geld<10000)  //weniger als 10000$

                        if(geworfenezahl % 2 == 0)
                          {
                            einsatz = (10000 - geld)*2;
                            geld += einsatz;
                          }

                        else if(geworfenezahl != 0)
                          {
                            einsatz = (10000 - geld)*2;
                            geld -= einsatz;
                          }
                        else if(geworfenezahl ==0)
                          {
                            einsatz = (10000 - geld)*2;
                            geld -= einsatz;
                        }

                  if(einsatz>1000)  //einsatz groesser als 1000$
                  {
                      if(geworfenezahl % 2 == 0)
                          {
                            einsatz = 1000;
                            geld += einsatz;
                          }

                        else if(geworfenezahl != 0)
                          {
                            einsatz = 1000;
                            geld -= einsatz;
                          }
                        else if(geworfenezahl ==0)
                          {
                            einsatz = 1000;
                            geld -= einsatz;
                        }
                  }
                            
                  if(geld<einsatz) //kapital reicht nicht für den einsatz (all in)
                  {
                      if(geworfenezahl % 2 == 0)
                          {
                            einsatz = geld;
                            geld += einsatz;
                          }

                        else if(geworfenezahl != 0)
                          {
                            einsatz = geld;
                            geld -= einsatz;
                          }
                        else if(geworfenezahl == 0)
                          {
                            einsatz = geld;
                            geld -= einsatz;
                        }
                  }
                  
          Console.WriteLine($"Anzahl des Spiels: {anzahlspiele} || Geworfene Zahl: {geworfenezahl} || Kapital: {geld}");
          Thread.Sleep(50);
          }
              
        }
    }
}