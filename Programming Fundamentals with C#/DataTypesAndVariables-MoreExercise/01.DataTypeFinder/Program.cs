using System;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int a ;
            float b ;
            bool c;
            char ch;


            while (type!="END")
            {
                if (int.TryParse(type,out a))
                {
                    Console.WriteLine($"{type} is integer type");
                }
                else if (float.TryParse(type, out b))
                {
                    Console.WriteLine($"{type} is floating point type");
                }
               else if (bool.TryParse(type, out c))
                {
                    Console.WriteLine($"{type} is boolean type");
                }
                else if (char.TryParse(type, out ch))
                {
                    Console.WriteLine($"{type} is character type");
                }
                else
                {
                    
                    Console.WriteLine($"{type} is string type");
                    
                }
                type = Console.ReadLine();

            }
        }
    }
}
