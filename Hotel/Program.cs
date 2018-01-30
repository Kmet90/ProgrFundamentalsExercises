using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.00;
            double priceDouble = 0.00;
            double priceSuite = 0.00;
            double totalPriceStudio = 0.00;
            double totalPriceDouble = 0.00;
            double totalPriceSuite = 0.00;

            if (month == "May" || month == "October")
            {
                priceStudio = 50.00;
                priceDouble = 65.00;
                priceSuite = 75.00;
            }

            if (month == "June" || month == "September")
            {
                priceStudio = 60.00;
                priceDouble = 72.00;
                priceSuite = 82.00;
            }
            if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68.00;
                priceDouble = 77.00;
                priceSuite = 89.00;
            }


            if (nights > 7 && (month == "May" || month == "October"))
            {
                priceStudio *= 0.95;
            }

            if (nights > 14 && (month == "June" || month == "September"))
            {
                priceDouble *= 0.9;
            }

            if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                priceSuite *= 0.85;
            }

            totalPriceSuite = priceSuite * nights;
            totalPriceStudio = priceStudio * nights;
            totalPriceDouble = priceDouble * nights;

            if (nights > 7 && (month == "September" || month == "October"))
            {
                totalPriceStudio -= priceStudio;
            }

            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");
        }
    }
}
