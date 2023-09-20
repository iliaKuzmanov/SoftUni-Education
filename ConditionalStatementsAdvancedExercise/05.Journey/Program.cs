using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //winter,summer
           string tripType="";
            string place = "";
            double moneySpent = 0;
            if (budget<=100)
            {
                tripType = "Bulgaria";
                if (season=="winter")
                {
                    moneySpent = budget * 0.7;
                    place = "Hotel";
                }
                else
                {
                    moneySpent = budget * 0.3;
                    place = "Camp";
                }
            }
            else if (budget<=1000)
            {
                tripType = "Balkans";
                if (season == "winter")
                {
                    moneySpent = budget * 0.8;
                    place = "Hotel";
                }
                else
                {
                    moneySpent = budget * 0.4;
                    place = "Camp";
                }
            }
            else
            {
                tripType = "Europe";
                moneySpent = budget * 0.9;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {tripType}");
            Console.WriteLine($"{ place} - { moneySpent:f2}");
        }
    }
}
