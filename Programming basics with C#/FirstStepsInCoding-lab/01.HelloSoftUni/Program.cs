using System;

namespace _01.HelloSoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = int.Parse(Console.ReadLine());
            double inches = cm * 2.54;
            Console.WriteLine(inches);
        }
    }
}
