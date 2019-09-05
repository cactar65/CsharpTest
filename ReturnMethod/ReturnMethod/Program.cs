using System;

namespace ReturnMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry;

            Console.Write("Enter a number to be Cubed: ");
            entry = Console.Read();


            Console.WriteLine(Cube(entry));

            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
