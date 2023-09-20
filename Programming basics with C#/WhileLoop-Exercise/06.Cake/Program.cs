using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cake = 0;
            int pieces = width * length;
            string command = Console.ReadLine();
            bool isNull = false;
            while (command!="STOP")
            {
                 cake = int.Parse(command);
                pieces -= cake;

                if (pieces<0)
                {
                    
                    pieces = Math.Abs(pieces);
                    isNull = true;
                    break;
                }
                command = Console.ReadLine();

            }
            if (isNull)
            {
                Console.WriteLine($"No more cake left! You need {pieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
