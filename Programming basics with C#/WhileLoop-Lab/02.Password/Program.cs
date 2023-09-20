using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string keyPass = Console.ReadLine();

            string input = Console.ReadLine();

            while (input!=keyPass)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
