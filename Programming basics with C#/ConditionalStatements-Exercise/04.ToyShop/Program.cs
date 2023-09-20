using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCnt = int.Parse(Console.ReadLine());
            int dollsCnt = int.Parse(Console.ReadLine());
            int bearsCnt = int.Parse(Console.ReadLine());
            int minionsCnt = int.Parse(Console.ReadLine());
            int trucksCnt = int.Parse(Console.ReadLine());
            double allCnt = puzzleCnt + dollsCnt + bearsCnt + minionsCnt + trucksCnt;
            double sum = puzzleCnt * 2.60 + dollsCnt * 3 + bearsCnt * 4.10 + minionsCnt * 8.20 + trucksCnt * 2;
            if (allCnt >= 50)
            {
                sum = 0.75 * sum;
            } 
            
            sum = sum *0.90;
            if (tripPrice<=sum)
            {
                Console.WriteLine($"Yes! {Math.Abs(tripPrice-sum):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(sum-tripPrice):f2} lv needed.");
            }

        }
    }
}
