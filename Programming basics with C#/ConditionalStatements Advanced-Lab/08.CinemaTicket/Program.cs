﻿using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Monday Tuesday Wednesday Thursday Friday Saturday Sunday

            //  12 12 14 14 12 16 16

            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                  break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }



        }
        }
    }

