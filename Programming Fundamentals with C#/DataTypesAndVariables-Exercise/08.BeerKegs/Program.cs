using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double best = double.MinValue;
            
            int n = int.Parse(Console.ReadLine());
            string theBest = "";
            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius* radius * height;
                if (volume>best)
                {
                    best = volume;
                    theBest = type;
                }

            }
           
            Console.WriteLine(theBest);
        }
    }
}
