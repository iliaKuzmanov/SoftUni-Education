using System;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s="";
            char a = char.Parse(Console.ReadLine());
            s += a;
            char b = char.Parse(Console.ReadLine());
            s += b;
            char c = char.Parse(Console.ReadLine());
            s += c;
            
            Console.WriteLine(s);
        }
    }
}
