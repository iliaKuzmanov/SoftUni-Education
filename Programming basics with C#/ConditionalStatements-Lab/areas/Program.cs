using System;

namespace areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area;
            if(figure=="square")
            {
                double a = double.Parse(Console.ReadLine());
                 area = a * a;
                Console.WriteLine("{0:f3}",area);
            }
            else if(figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double be = double.Parse(Console.ReadLine());
                 area = a * be;
                Console.WriteLine("{0:f3}", area);
            }
            else if(figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                 area = a *ha / 2;
                Console.WriteLine("{0:f3}", area);
            }
            else if(figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                 area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("{0:f3}", area);
            }
        }
    }
}
