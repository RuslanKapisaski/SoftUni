using System;

namespace EXAM_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int tissue = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            //logic
            double paperPrice = 5.80;
            double tissuePrice = 7.20;
            double gluePrice = 1.20;

            double totalPriceForPaper = paper * paperPrice;
            double totalPriceForTissue = tissue * tissuePrice;
            double totalPriceForGlue = glue * gluePrice;


            double discount1 = (totalPriceForPaper + totalPriceForTissue + totalPriceForGlue) * discount/100;
            double totalPrice = (totalPriceForPaper + totalPriceForTissue + totalPriceForGlue);
            double finalTotalPrice = totalPrice - discount1;


            Console.WriteLine($"{finalTotalPrice:f3}");
        
        }
    }
}
