using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            string s = "";
            for (int i = first; i <= last; i++)
            {
                char ch = (char)i;
                s+= ch;
                s+=" ";
            }
            Console.WriteLine(s);
        }
    }
}
