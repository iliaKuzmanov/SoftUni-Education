using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d1Count = 0;
            int d2Count = 0;
            int d3Count = 0;
            int d4Count = 0;
            int d5Count = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                   
                    d1Count++;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    d2Count++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    d3Count++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    d4Count++;
                }
                else
                {
                    d5Count++;
                }
            }
            double d1Part = ((double)d1Count/ n) * 100;  
            double d2Part = ((double)d2Count / n) * 100;
            double d3Part = ((double)d3Count / n) * 100;
            double d4Part = ((double)d4Count / n) * 100;
            double d5Part = ((double)d5Count / n) * 100;

            Console.WriteLine($"{d1Part:f2}%");
            Console.WriteLine($"{d2Part:f2}%");
            Console.WriteLine($"{d3Part:f2}%");
            Console.WriteLine($"{d4Part:f2}%");
            Console.WriteLine($"{d5Part:f2}%");
        }
    }
}
