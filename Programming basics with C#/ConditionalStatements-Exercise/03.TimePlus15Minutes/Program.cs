using System;

namespace _03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int addedMins = mins+15;
            if (addedMins>=60)
            {
                hour += 1;
                addedMins -= 60;
            }
            if (hour>=24)
            {
                hour =hour- 24;
            }
            if (addedMins<10)
            {
                Console.WriteLine($"{hour}:0{addedMins}");
            }
            else
            {
                Console.WriteLine($"{hour}:{addedMins}");
            }
        }
    }
}
