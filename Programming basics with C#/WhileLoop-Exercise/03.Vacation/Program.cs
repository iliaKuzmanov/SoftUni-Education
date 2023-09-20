using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMOney = double.Parse(Console.ReadLine());
            double balance = double.Parse(Console.ReadLine());

            int spendCnt = 0;
            int daysCnt = 0;
           
            while (neededMOney>balance && spendCnt < 5)
            {
                string saveOrSpend = Console.ReadLine();
                double opperation = double.Parse(Console.ReadLine());

                if (saveOrSpend=="save")
                {
                    balance += opperation;
                    spendCnt = 0;
                }
                else
                {
                    balance -= opperation;
                    spendCnt++;
                    if (balance<0)
                    {
                        balance = 0;
                    }
                }
                daysCnt++;
            }
            if (spendCnt>=5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCnt);
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCnt} days.");
            }
        }
    }
}
