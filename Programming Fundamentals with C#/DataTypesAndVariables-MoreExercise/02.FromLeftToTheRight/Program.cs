using System;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < cnt; i++)
            {
                string s = Console.ReadLine();
                string before = s.Substring(0, s.IndexOf(" "));
                string after = s.Substring(s.IndexOf(" ") + 1);
                
                int firstSum = 0;
                int secSum = 0;
        
                long number = long.Parse(before);
                long secondNumber = long.Parse(after);
                if (before.Contains("-"))
                {
                    for (int k = 1; k < before.Length; k++)
                    {
                        firstSum += int.Parse(before[k].ToString());
                    }
                }
                else
                {
                    for (int k = 0; k < before.Length; k++)
                    {
                        firstSum += int.Parse(before[k].ToString());
                    }
                }
                if (after.Contains("-"))
                {
                    for (int k = 1; k < after.Length; k++)
                    {
                        secSum += int.Parse(after[k].ToString());
                    }
                }
                else
                {
                    for (int k = 0; k < after.Length; k++)
                    {
                        secSum += int.Parse(after[k].ToString());
                    }
                }

                if (number > secondNumber)
                    {
                        Console.WriteLine(Math.Abs(firstSum));
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(secSum));
                    }

                }
            }
        }
    }
