using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";

            Console.WriteLine("he really liked the name " + characterName);
            Console.WriteLine("But didn't lkike being " + characterAge);


            Console.ReadLine();
        }
    }
}
