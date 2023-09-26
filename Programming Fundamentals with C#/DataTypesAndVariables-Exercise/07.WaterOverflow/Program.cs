    using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int poured = 0;
                while (capacity >= 0 &&n>0)
                {
                n--;
                int liters = int.Parse(Console.ReadLine());
                    capacity -= liters;
                    if (capacity < 0)
                    {
                        Console.WriteLine("Insufficient capacity!");
                    capacity += liters;
                    continue;
                    }
                poured += liters;
                
                }
            Console.WriteLine(poured);
        }
    }
}
