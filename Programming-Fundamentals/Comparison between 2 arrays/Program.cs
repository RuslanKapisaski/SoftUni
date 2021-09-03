using System;
using System.Linq;

namespace Comparison_between_2_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentArray = secondArray[i];


                for (int l = 0; l < firstArray.Length; l++)
                {
                   

                    if (currentArray == firstArray[l])
                    {
                        Console.Write(currentArray + " ");
                    }
                }
            }

        }
    }
}
