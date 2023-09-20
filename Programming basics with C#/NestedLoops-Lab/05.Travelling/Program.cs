using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string where = Console.ReadLine();

            while (where!="End")
            {
                double budget = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum<budget)
                {
                    double save = double.Parse(Console.ReadLine());
                    sum += save;
                }
                Console.WriteLine($"Going to {where}!");
                where = Console.ReadLine();
            }

        }
    }
}
