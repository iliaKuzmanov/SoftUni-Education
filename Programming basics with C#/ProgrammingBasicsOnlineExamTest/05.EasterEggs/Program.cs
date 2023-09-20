using System;

namespace _05.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            int redCnt = 0;
            int greenCnt = 0;
            int blueCnt = 0;
            int orangeCnt = 0;
            int max = int.MinValue;
            string maxColor = string.Empty;
            for (int i = 0; i < cnt; i++)
            {
                string color = Console.ReadLine();
                if (color=="red")
                {
                    redCnt++;
                    if (redCnt>max)
                    {
                        max = redCnt;
                        maxColor = "red";
                        continue;
                    }
                }
                else if (color=="green")
                {
                    greenCnt++;
                    if (greenCnt > max)
                    {
                        max = greenCnt;
                        maxColor = "green";
                        continue;
                    }
                }
                else if (color=="blue")
                {
                    blueCnt++;
                    if (blueCnt > max)
                    {
                        max = blueCnt;
                        maxColor = "blue";
                        continue;
                    }
                }
                else if (color=="orange")
                {
                    orangeCnt++;
                    if (orangeCnt > max)
                    {
                        max = orangeCnt;
                        maxColor = "orange";
                        continue;
                    }
                }
            }
            Console.WriteLine($"Red eggs: {redCnt}");
            Console.WriteLine($"Orange eggs: {orangeCnt}");
            Console.WriteLine($"Blue eggs: {blueCnt}");
            Console.WriteLine($"Green eggs: {greenCnt}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");
        }
    }
}
