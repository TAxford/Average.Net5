﻿using System;

namespace Average.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please ennter -1 once you are ready to calculate the average.");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("---------------------------------------------------");
                    //Calculate average and let the teacher know
                }
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a vlue between 1 and 20!");
                    }
                    continue;
                }



            }



        }
    }
}
