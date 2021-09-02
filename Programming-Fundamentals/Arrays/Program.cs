using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagoons = int.Parse(Console.ReadLine());

            int countOfPeople = 0;
            int sum = 0;
            int peopleInTrain = 0;

            int[] array = new int[wagoons];


            for (int i = 0; i < wagoons; i++)
            {
                countOfPeople = int.Parse(Console.ReadLine());
                array[i] = countOfPeople;
                sum += countOfPeople;
            }
            peopleInTrain = countOfPeople;


            for (int i = 0; i < wagoons; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.Write(sum);
        }
    }
}
