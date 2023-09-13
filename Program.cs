using System.Numerics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = new string[] {
                "luca.schulz@tecalliance.net","abc@tecalliance.net","xyz@tecalliance.net"
            };
            foreach(string email in emails)
            {
                Console.WriteLine($"Die Email lautet: {email}");
            }
            for (int position=0;position< emails.Length; position++)
            {
                Console.WriteLine($"Die Email lautet: {emails[position]}");
            }


        }   
    }
}
