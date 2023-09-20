using System;

namespace _06.EasterDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clientCnt = int.Parse(Console.ReadLine());
            string cmd;
            int itemCnt = 0;
            double sum = 0;
            double averageStack = 0;
            int i = 1;
            while (i<=clientCnt)
            { 
                {
                    while ((cmd = Console.ReadLine()) != "Finish")
                    {
                        itemCnt++;
                        if (cmd == "basket")
                        {
                            sum += 1.5;
                        }
                        else if (cmd == "wreath")
                        {
                            sum += 3.8;
                        }
                        else if (cmd == "chocolate bunny")
                        {
                            sum += 7;
                        }
                    }
                    if (itemCnt % 2 == 0)
                    {
                        sum *= 0.8;
                    }
                    Console.WriteLine($"You purchased {itemCnt} items for {sum:f2} leva.");
                    averageStack += sum;
                    itemCnt = 0;
                    sum = 0;
                }
                i++;
            }
            double average = averageStack / clientCnt;
            Console.WriteLine($"Average bill per client is: {average:f2} leva.");
        }
    }
}
