using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double totalPrice = 0.0;
            double priceHall = 0.0;
            double pricePackage = 0.0;
            string hallName = "";

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.05);
                        break;
                    case "Gold":
                        pricePackage = 750.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.1);
                        break;
                    case "Platinum":
                        pricePackage = 1000.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.15);
                        break;
                }
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                priceHall = 5000;
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.05);
                        break;
                    case "Gold":
                        pricePackage = 750.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.1);
                        break;
                    case "Platinum":
                        pricePackage = 1000.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.15);
                        break;
                }
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
            }

            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                priceHall = 7500;
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.05);
                        break;
                    case "Gold":
                        pricePackage = 750.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.1);
                        break;
                    case "Platinum":
                        pricePackage = 1000.0;
                        totalPrice = (priceHall + pricePackage) - ((priceHall + pricePackage) * 0.15);
                        break;
                }
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
            }
        
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
