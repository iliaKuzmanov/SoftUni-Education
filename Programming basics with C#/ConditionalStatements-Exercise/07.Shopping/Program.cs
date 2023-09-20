using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpuCnt = int.Parse(Console.ReadLine());
            int cpuCnt= int.Parse(Console.ReadLine());
            int ramCnt= int.Parse(Console.ReadLine());

            double gpuSum = gpuCnt * 250;
            double cpuSum = cpuCnt * (0.35 * gpuSum);
            double ramSum = ramCnt * (0.10 * gpuSum);

            double sum = gpuSum + cpuSum + ramSum;
            if (gpuCnt>cpuCnt)
            {
                
                sum =sum*0.85;
            }
            if (budget>=sum)
            {
                Console.WriteLine($"You have {(budget-sum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(sum-budget):f2} leva more!");
            }
        }
    }
}
