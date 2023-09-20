using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tourCnt = int.Parse(Console.ReadLine());
            int startPoints=int.Parse(Console.ReadLine());

            int winCnt = 0;

            int matchPoints = 0;

            int sum = 0;
            for (int i = 1; i <=tourCnt; i++)
            {
                string winFinalOrSf = Console.ReadLine();

                if (winFinalOrSf=="W")
                {
                    matchPoints += 2000;
                    winCnt++;
                }
                else if (winFinalOrSf=="F")
                {
                    matchPoints += 1200;
                }
                else
                {
                    matchPoints += 720;
                }
                sum = matchPoints + startPoints;
            }
            

            


            double averagePoints = matchPoints / tourCnt;

            double percentWinsPerTour =(double)winCnt / tourCnt * 100;

            Console.WriteLine($"Final points: {sum}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWinsPerTour:f2}%");
        }
    }
}
