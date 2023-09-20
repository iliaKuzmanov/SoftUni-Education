using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cs = int.Parse(Console.ReadLine());
            double income = 0;
            if (type=="Premiere")
            {
                income = rows * cs * 12;
            }
            else if (type=="Normal")
            {
                income = rows * cs * 7.5;
            }
            else if(type=="Discount")
            {
                income = rows * cs * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
