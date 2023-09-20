using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finnish = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combCnt = 0;
            bool isFound = false;
            for (int i = start; i <= finnish; i++)
            {
                for (int j = start; j <= finnish; j++)
                {
                    int result = i + j;
                    combCnt++;
                    if (result==magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combCnt} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combCnt} combinations - neither equals {magicNum}");
            }
        }
    }
}
