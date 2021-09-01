using System;

namespace Even_or_odd_positions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing count of numbers
            int n = int.Parse(Console.ReadLine());
            //inputs for even numbers
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MaxValue;
            //input for odd numbers
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MaxValue;
            //Logic
            for (int i = 0; i < n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                //Even numbers

                if (currentNumber % 2 == 0)
                {
                    //Console.WriteLine($"evenSum={}");
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;

                    }
                    else if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;

                    }
                    //else
                    //{
                    //    Console.WriteLine("No");
                    //}
                    //Odd numbers
                    if (currentNumber % 2 != 0)
                    {
                        if (currentNumber < oddMin)
                        {
                            oddMin = evenMin;
                        }
                        else if (currentNumber > oddMax)
                        {
                            oddMax = oddMax;

                        }
                        //else
                        //{
                        //    Console.WriteLine("No");
                        //}
                        //Console.WriteLine($"oddSum={}");

                    }
                }
                        Console.WriteLine($"oddMax= {oddMax}");
                        Console.WriteLine($"oddMin= {oddMin}");
                        Console.WriteLine($"evenMin= {evenMin}");
                        Console.WriteLine($"evenMax= {evenMax}");


                

            }
        }
    }
}