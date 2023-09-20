using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int cnt = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double neededMoney = 0;
            switch (type)
            {
                case "Roses":
                    price = cnt * 5;
                    if (cnt>80)
                    {
                        neededMoney = price * 0.9;
                    }
                    else
                    {
                        neededMoney = price;
                    }
                    break;
                case "Dahlias":
                    price = cnt * 3.8;
                    if (cnt>90)
                    {
                        neededMoney = price * 0.85;
                    }
                    else
                    {
                        neededMoney = price;
                    }
                    break;
                case "Tulips":
                    price = 2.8 * cnt;
                    if (cnt>80)
                    {
                        neededMoney = price * 0.85;
                    }
                    else
                    {
                        neededMoney = price;
                    }
                    break;
                case "Narcissus":
                    price = cnt * 3;
                    if (cnt<120)
                    {
                        neededMoney = price * 1.15;
                    }
                    else
                    {
                        neededMoney = price;
                    }
                    break;
                case "Gladiolus":
                    price = cnt * 2.5;
                    if (cnt<80)
                    {
                        neededMoney = price * 1.2;
                    }
                    else
                    {
                        neededMoney = price;
                    }
                    break;
                    
            }
            if (neededMoney <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {cnt} {type} and {(budget - neededMoney):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(neededMoney - budget):f2} leva more.");
            }
        }
    }
}
