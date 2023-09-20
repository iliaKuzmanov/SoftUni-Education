using System;

namespace swimminrecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secs = double.Parse(Console.ReadLine());
            double  length = double.Parse(Console.ReadLine());
            double lengthForMeter = double.Parse(Console.ReadLine());

            double addedSecs = length * lengthForMeter;
            double resist = (Math.Floor((length / 15 ))* 12.5);
            double timeSum = addedSecs + resist;
            if (secs>timeSum)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeSum:f2} seconds.");
            }
            else if (secs<=timeSum)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(secs-timeSum):f2} seconds slower.");
            }
            

        }
    }
}
