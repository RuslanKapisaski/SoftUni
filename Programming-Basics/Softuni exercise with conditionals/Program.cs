using System;

namespace Softuni_exercise_with_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double swimingWorldRecordInSeconds = double.Parse(Console.ReadLine());
            double swimingDistance = double.Parse(Console.ReadLine());
            double timeInSwimingPerSecondsPerMeter = double.Parse(Console.ReadLine());


            //Ivan's things
            double IvanAttempt = swimingDistance * timeInSwimingPerSecondsPerMeter;
            double amountsOfSlowdown = Math.Floor(swimingDistance / 15);
            double swimingRecordOfIvan = IvanAttempt + (amountsOfSlowdown * 12.5);

            //Logical steps

            if (swimingRecordOfIvan < swimingWorldRecordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimingRecordOfIvan:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {swimingRecordOfIvan - swimingWorldRecordInSeconds:F2} seconds slower.");
            }

        }
    }
}
