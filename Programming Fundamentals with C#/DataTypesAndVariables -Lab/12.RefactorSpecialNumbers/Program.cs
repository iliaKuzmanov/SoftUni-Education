using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;
            for (int i = 1; i <= num; i++)
            {
                sum = 0;
                int temp = i;
                while (temp > 0)
                {
                   int last=temp%10;
                    sum += last;
                    temp /= 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
