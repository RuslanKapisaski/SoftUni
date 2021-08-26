﻿using System;

namespace Softuni_15._03._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            //Logical actions

            

            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{ minutes}:0{ seconds}");
            }
            else
            {
                Console.WriteLine($"{ minutes}:{seconds}");
            }

        }
    }
}
