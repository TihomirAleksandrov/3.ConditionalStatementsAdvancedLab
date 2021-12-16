using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string grocery = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            double coffeePrice = 0;
            double waterPrice = 0;
            double beerPrice = 0;
            double sweetsPrice = 0;
            double peanutsPrice = 0;

            switch (city)
            {
                case "Sofia":
                    coffeePrice = 0.50;
                    waterPrice = 0.80;
                    beerPrice = 1.20;
                    sweetsPrice = 1.45;
                    peanutsPrice = 1.60;
                    break;
                    
                case "Plovdiv":
                    coffeePrice = 0.40;
                    waterPrice = 0.70;
                    beerPrice = 1.15;
                    sweetsPrice = 1.30;
                    peanutsPrice = 1.50;
                    break;

                case "Varna":
                    coffeePrice = 0.45;
                    waterPrice = 0.70;
                    beerPrice = 1.10;
                    sweetsPrice = 1.35;
                    peanutsPrice = 1.55;
                    break;
            }
            switch (grocery)
            {
                case "coffee":
                    totalPrice = coffeePrice * amount;
                    break;

                case "water":
                    totalPrice = waterPrice * amount;
                    break;

                case "beer":
                    totalPrice = beerPrice * amount;
                    break;

                case "sweets":
                    totalPrice = sweetsPrice * amount;
                    break;

                case "peanuts":
                    totalPrice = peanutsPrice * amount;
                    break;
            }
            Console.WriteLine(totalPrice);
        }
    }
}
