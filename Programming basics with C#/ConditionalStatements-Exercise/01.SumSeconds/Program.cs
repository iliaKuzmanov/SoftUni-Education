using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstMins = int.Parse(Console.ReadLine());
            int secondMins= int.Parse(Console.ReadLine());
            int thirdMins= int.Parse(Console.ReadLine());
            int totalTime = firstMins + secondMins + thirdMins;
            int minutes, seconds;
            minutes = totalTime / 60;
            seconds = totalTime % 60;
            if (seconds<10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
