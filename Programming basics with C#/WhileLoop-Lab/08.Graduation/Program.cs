using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badGrades = 0;
            int clas = 1;
            double average = 0;
            double sum = 0;
            while (clas<=12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade<4)
                {
                    badGrades++;
                    if (badGrades>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        return;
                    }
                    continue;
                }
                sum += grade;
                clas++;
            }
            average = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}
