using System;

namespace Padawan_equipment
{
    class Program
    {
        static void Main(string[] rgs)
        {
            //inputs
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());



            //logic
            double freeBelt = 0;  double totalMoneyNeeded = (countOfStudents *  priceOfRobes) + (priceOfBelts*( countOfStudents -  (countOfStudents/6)) +(Math.Ceiling(countOfStudents*1.1) * priceOfLightsabers));
            
           
            if (money>=totalMoneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoneyNeeded-money:F2}lv more.");
            }


        }
    }
}
