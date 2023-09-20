using System;

namespace godzvskong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistCnt = int.Parse(Console.ReadLine());
            double statistPrice=double.Parse(Console.ReadLine());

            double decor = 0.1 * budget;
            double sumForClothes = statistPrice * statistCnt;
            if (statistCnt>150)
            {
                sumForClothes = sumForClothes * 0.90;
            }
            if (sumForClothes+decor>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(sumForClothes+decor)-budget:f2} leva more.");
            }
            else if (sumForClothes+decor<=budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget- (sumForClothes + decor):f2} leva left.");
            }
        }
    }
}
