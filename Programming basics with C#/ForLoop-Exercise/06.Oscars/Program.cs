using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int cnt = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= cnt; i++)
            {
                string refName = Console.ReadLine();
                double refPoins = double.Parse(Console.ReadLine());

                int length = refName.Length;

                points += (refPoins * length) / 2;

                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
                    break;
                }

            }
            if (points < 1250.5)
            {
                double pointsNeeded = Math.Abs(points - 1250.5);
                Console.WriteLine($"Sorry, {name} you need {pointsNeeded} more!");
            }
        }
    }
}

