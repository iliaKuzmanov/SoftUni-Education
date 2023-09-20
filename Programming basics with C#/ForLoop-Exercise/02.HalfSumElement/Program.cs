using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num>max)
                {
                    max = num;
                }

            }
            int sumSum = sum - max;

            if (max==sumSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max-sumSum));
            }
        }
    }
}
