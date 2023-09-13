using System.Numerics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();
            Console.WriteLine("Wie alt bist du?");
            string age = Console.ReadLine();
            int  alter = Convert.ToInt16(age);
            int  alterinzehn = alter + 10;
            Console.WriteLine($"Hallo {name}!, Was geht? Du bist schon {age} ? Das heisst ja, dass du in 10 Jahren {alterinzehn} bist");
        }
    }
}