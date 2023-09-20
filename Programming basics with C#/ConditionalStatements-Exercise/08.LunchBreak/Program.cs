using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int epCont = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double lunchtime = breakTime/8.0;
            double restTime = breakTime/4.0;
            double timeLeft = breakTime - restTime - lunchtime;
            if (timeLeft>=epCont)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft-epCont)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(Math.Abs(epCont-timeLeft))} more minutes.");
            }
        }
    }
}
