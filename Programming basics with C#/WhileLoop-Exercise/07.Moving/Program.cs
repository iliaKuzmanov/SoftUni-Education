using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height=int.Parse(Console.ReadLine());
            int sumSpace = 0;
            int freeSpace = width * height * length;

            bool isNotEnough = false;

            string command = Console.ReadLine();

            while (command!="Done")
            {
                int n = int.Parse(command);
                sumSpace += n;

                if (sumSpace > freeSpace)
                {
                    isNotEnough = true;
                    break;
                }
                command = Console.ReadLine();
            }
            if (isNotEnough==true)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(sumSpace-freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(sumSpace-freeSpace)} Cubic meters left.");
            }

        }
    }
}
