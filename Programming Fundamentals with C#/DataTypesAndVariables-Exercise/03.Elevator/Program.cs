using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            int fittingPeopleCnt = int.Parse(Console.ReadLine());
            if (peopleCnt<fittingPeopleCnt)
            {
                Console.WriteLine(1);
            }
            else
            {
                int courses = (int)Math.Ceiling((double)peopleCnt / fittingPeopleCnt);
                Console.WriteLine(courses);
            }
        }
    }
}
