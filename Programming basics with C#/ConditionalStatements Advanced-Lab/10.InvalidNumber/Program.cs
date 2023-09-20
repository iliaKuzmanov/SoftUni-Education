using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            double finalPrice = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        price = 2.5;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.2;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 2.7;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.5;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 3.85;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        price = 2.7;
                    }
                    else if (fruit == "apple")
                    {
                        price = 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        price = 0.9;
                    }
                    else if (fruit == "grapefruit")
                    {
                        price = 1.6;
                    }
                    else if (fruit == "kiwi")
                    {
                        price = 3;
                    }
                    else if (fruit == "pineapple")
                    {
                        price = 5.6;
                    }
                    else if (fruit == "grapes")
                    {
                        price = 4.2;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            finalPrice = price * quantity;
            if (finalPrice == 0)
            {

            }
            else
            {
                Console.WriteLine(  $"{ finalPrice:f2}") ;
            }


        }
    }
}
