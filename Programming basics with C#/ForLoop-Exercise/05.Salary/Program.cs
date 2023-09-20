using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabCnt = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <=tabCnt; i++)
            {
                string tab = Console.ReadLine();

                if(tab=="Facebook")
                {
                    salary -= 150;
                }
                else if (tab=="Reddit")
                {
                    salary -= 50;
                }
                else if(tab=="Instagram")
                {
                    salary -= 100;
                }
                if (salary<=0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine($"You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary:f0}");
            }
        }
    }
}
