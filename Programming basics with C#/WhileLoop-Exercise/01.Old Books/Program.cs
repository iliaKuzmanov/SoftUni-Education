using System;

namespace _01.Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int cnt = 0;
            bool isFound = false;
            string book = Console.ReadLine();

            while (book!="No More Books")
            {
                
                if (book==favBook)
                {
                    isFound = true;
                    break;
                }
                cnt++;
                book = Console.ReadLine();
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {cnt} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {cnt} books.");
            }
        }
    }
}
