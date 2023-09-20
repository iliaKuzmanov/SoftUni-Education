using System;

namespace _03.FilmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenesCnt = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());
            double prepareTime = 0.15 * time;
            int sceneNeededTime = scenesCnt * sceneTime;
            double sum = prepareTime + sceneNeededTime;
            if (sum<=time)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(Math.Abs(sum - time))} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(Math.Abs(sum - time))} minutes.");
            }
        }
    }
}
