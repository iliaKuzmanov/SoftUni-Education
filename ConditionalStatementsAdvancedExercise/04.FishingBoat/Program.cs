using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int cnt = int.Parse(Console.ReadLine());
            double rentMoney = 0;
            if (season=="Spring")
            {
                rentMoney = 3000;
                if (cnt<=6)
                {
                    rentMoney = rentMoney * 0.9;
                }
                else if (cnt<=11)
                {
                    rentMoney = rentMoney * 0.85;
                }
                else if (cnt>11)
                {
                    rentMoney = rentMoney * 0.75;
                }
                if (cnt%2==0)
                {
                    rentMoney = rentMoney * 0.95;
                }
            }
            else if (season == "Summer")
            {
                rentMoney = 4200;
                if (cnt <= 6)
                {
                    rentMoney = rentMoney * 0.9;
                }
                else if (cnt <= 11)
                {
                    rentMoney = rentMoney * 0.85;
                }
                else if (cnt > 11)
                {
                    rentMoney = rentMoney * 0.75;
                }
                if (cnt % 2 == 0)
                {
                    rentMoney = rentMoney *0.95;
                }
            }
            else if (season == "Autumn")
            {
                rentMoney = 4200;
                if (cnt <= 6)
                {
                    rentMoney = rentMoney * 0.9;
                }
                else if (cnt <= 11)
                {
                    rentMoney = rentMoney * 0.85;
                }
                else if (cnt > 11)
                {
                    rentMoney = rentMoney * 0.75;
                }
                
            }
            else if (season == "Winter")
            {
                rentMoney = 2600;
                if (cnt <= 6)
                {
                    rentMoney = rentMoney * 0.9;
                }
                else if (cnt <= 11)
                {
                    rentMoney = rentMoney * 0.85;
                }
                else if (cnt > 11)
                {
                    rentMoney = rentMoney * 0.75;
                }
                if (cnt % 2 == 0)
                {
                    rentMoney = rentMoney * 0.95;
                }
            }
            if (budget>=rentMoney)
            {
                Console.WriteLine($"Yes! You have {(budget-rentMoney):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(rentMoney-budget):f2} leva.");
            }

        }
    }
}
