using System;

namespace _03.EasterTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string timeSpan = Console.ReadLine();
            int nightCnt = int.Parse(Console.ReadLine());

            switch (destination)
            {
              
                case "France":
                    switch (timeSpan)
                    {
                        case "21-23":
                            nightCnt *= 30;
                            break;
                        case "24-27":
                            nightCnt *= 35;
                            break;
                        case "28-31":
                            nightCnt *= 40;
                            break;
                    }
                    break;
                case "Italy":
                    switch (timeSpan)
                    {
                        
                        case "21-23":
                            nightCnt *= 28;
                            break;
                        case "24-27":
                            nightCnt *= 32;
                            break;
                        case "28-31":
                            nightCnt *= 39;
                            break;
                    }
                    break;
                case "Germany":
                    switch (timeSpan)
                    {
                        case "21-23":
                            nightCnt *= 32;
                            break;
                        case "24-27":
                            nightCnt *= 37;
                            break;
                        case "28-31":
                            nightCnt *= 43;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Easter trip to {destination} : {nightCnt:f2} leva.");
        }
    }
}
