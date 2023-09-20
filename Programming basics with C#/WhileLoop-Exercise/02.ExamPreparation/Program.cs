using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bad = int.Parse(Console.ReadLine());
            int badCnt = 0;
            int doneCnt = 0;
            int sum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (badCnt<bad)
            {
                string problemName = Console.ReadLine();
                

                if (problemName=="Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    badCnt++;
                    if (badCnt>=bad)
                    {
                        isFailed = true;
                        break;
                    }
                }
                sum += grade;
                doneCnt++;
                lastProblem = problemName;

            }
            double average = (double)sum / doneCnt;
            if (isFailed==true)
            {
                Console.WriteLine($"You need a break, {bad} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {doneCnt}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
