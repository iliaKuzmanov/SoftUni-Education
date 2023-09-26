using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char ch = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char ch1 = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {                 
                        char ch2=(char)('a' + k);
                        Console.WriteLine($"{ch}{ch1}{ch2}");
                    }
                }
                
            }
        }
    }
}
