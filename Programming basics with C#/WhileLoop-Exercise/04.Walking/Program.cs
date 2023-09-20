using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;
            

            while (sum<10000)
            {
                if (command=="Going home")
                {

                    int toHomeSteps = int.Parse(Console.ReadLine());
                    sum += toHomeSteps;

                    break;
                }

                int steps = int.Parse(command);
                sum += steps;
                if (sum>=10000)
                {
                   
                    break;
                }
                command = Console.ReadLine();
            }
            if (sum>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sum-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-sum} more steps to reach goal.");
            }


        }
    }
}
