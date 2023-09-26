using System;

namespace _05.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            
            bool isBalanced = true;
            int opCnt = 0;
            int clCnt = 0;
            int deviCnt = 0;
            for (int i = 0; i < interval; i++)
            {
                string str = Console.ReadLine();
               bool isChar = char.TryParse(str, out char ch);
                if (ch=='(')
                {
                    opCnt++;
                    deviCnt++;
                    if (deviCnt>=2)
                    {
                        isBalanced = false;
                        break;

                    }                   
                }
                else if (ch==')') 
                {
                    clCnt++;
                    deviCnt--;
                    if (deviCnt<0)
                    {
                        isBalanced = false;
                        break;
                    }
                }  
            }
            if (isBalanced &&opCnt==clCnt)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
