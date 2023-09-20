using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]

            //· За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]

            int groupCnt = int.Parse(Console.ReadLine());

            double g1Cnt = 0;
            double g2Cnt = 0;
            double g3Cnt = 0;
            double g4Cnt = 0;
            double g5Cnt = 0;

            for (int i = 1; i <= groupCnt; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <=5)
                {
                    g1Cnt += number;
                }
              else  if (number >=5 && number<=12)
                {
                    g2Cnt += number;
                }
                else if (number>=13 && number <=25)
                {
                    g3Cnt += number;
                }
                else if (number >=26 && number<=40)
                {
                    g4Cnt += number;
                }
                else if (number>=41)
                {
                    g5Cnt += number;
                }
   
            }

            double allCnt = g1Cnt + g2Cnt + g3Cnt + g4Cnt + g5Cnt;

            g1Cnt = g1Cnt / allCnt * 100;
            g2Cnt = g2Cnt / allCnt * 100;
            g3Cnt = g3Cnt / allCnt * 100;
            g4Cnt = g4Cnt / allCnt * 100;
            g5Cnt = g5Cnt / allCnt * 100;


            Console.WriteLine($"{g1Cnt:f2}%");
            Console.WriteLine($"{g2Cnt:f2}%");
            Console.WriteLine($"{g3Cnt:f2}%");
            Console.WriteLine($"{g4Cnt:f2}%");
            Console.WriteLine($"{g5Cnt:f2}%");
        }
    }
}
