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
        


                Console.WriteLine("Gib mir eine Zahl!");
                int counter = Convert.ToInt16(Console.ReadLine());
                int start = 0;
                while(start<=counter)
                {
                    Console.WriteLine(start);
                    start++;  
                    if(start%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }      
                    if(start%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                    if(start%3 == 0 && start%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                
                }
                }
        }
        }
        }

