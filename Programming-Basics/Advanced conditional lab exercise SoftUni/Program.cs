using System;

namespace Advanced_conditional_lab_exercise_SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUTS
            string type = Console.ReadLine();
            double rows = int.Parse(Console.ReadLine());
            double columns = int.Parse(Console.ReadLine());

            double price = 1;
     
            


            if (type == "Premiere")
            {
                price= rows*columns*12;
            }


            if (type == "Normal")
            {
                price = rows * columns * 7.50;
            }

            if (type == "Discount")
            {
                price = rows * columns * 5.00;
            }
            Console.WriteLine($"{price:f2} leva");

        }
    }
}
