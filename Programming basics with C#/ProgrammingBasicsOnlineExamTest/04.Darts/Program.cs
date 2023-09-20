using System;

namespace _04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string cmd;
            int startPts = 301;
            int failedShotsCnt = 0;
            int shotsCnt = 0;
            bool isGG = false;
            while ((cmd = Console.ReadLine())!="Retire" && startPts>0)
            {
                shotsCnt++;
                int points = int.Parse(Console.ReadLine());
                if (cmd=="Double")
                {
                    points *= 2;
                }
                else if (cmd=="Triple")
                {
                    points *= 3;
                }
                if (points>startPts)
                {
                    failedShotsCnt++;
                    shotsCnt--;
                    continue;
                }
                startPts-=points;
                if (startPts==0)
                {
                    isGG = true;
                    break;
                }
            }
            if (isGG)
            {
                Console.WriteLine($"{name} won the leg with {shotsCnt} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {failedShotsCnt} unsuccessful shots.");
            }
        }
    }
}
