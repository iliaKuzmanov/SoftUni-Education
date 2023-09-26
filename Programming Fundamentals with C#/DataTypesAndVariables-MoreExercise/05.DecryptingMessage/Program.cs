using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string final = "";
            for (int i = 0; i < numberOfLines; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                final += (char)((int)ch + interval);
            }
            Console.WriteLine(final);
        }
    }
}
