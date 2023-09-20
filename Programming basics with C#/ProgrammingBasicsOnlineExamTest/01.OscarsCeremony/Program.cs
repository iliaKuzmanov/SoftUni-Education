using System;

namespace _01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double statues = 0.7 * rent;
            double cathering = statues * 0.85;
            double sounding = cathering / 2;
            double sum = rent + statues + cathering + sounding;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
