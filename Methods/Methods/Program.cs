using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string namee;

            Console.Write("Enter your name: ");
            namee = Console.ReadLine();


            SayHi(namee);

            Console.ReadLine();
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello User " + name);
        }
    }
}
