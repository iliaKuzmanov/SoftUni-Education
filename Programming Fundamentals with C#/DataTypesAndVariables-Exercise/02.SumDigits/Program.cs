using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int temp = int.Parse(num[i].ToString());
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
