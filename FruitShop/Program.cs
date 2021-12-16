using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            double bananaPrice = 0;
            double applePrice = 0;
            double orangePrice = 0;
            double grapefruitPrice = 0;
            double kiwiPrice = 0;
            double pineapplePrice = 0;
            double grapesPrice = 0;

            bool isCorrect = true;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                bananaPrice = 2.50;
                applePrice = 1.20;
                orangePrice = 0.85;
                grapefruitPrice = 1.45;
                kiwiPrice = 2.70;
                pineapplePrice = 5.50;
                grapesPrice = 3.85;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                bananaPrice = 2.70;
                applePrice = 1.25;
                orangePrice = 0.90;
                grapefruitPrice = 1.60;
                kiwiPrice = 3.00;
                pineapplePrice = 5.60;
                grapesPrice = 4.20;
            }
            else
            {
                isCorrect = false;
            }

            if (fruit == "banana")
            {
                totalPrice = bananaPrice * amount;
            }
            else if (fruit == "apple")
            {
                totalPrice = applePrice * amount;
            }
            else if (fruit == "orange")
            {
                totalPrice = orangePrice * amount;
            }
            else if (fruit == "grapefruit")
            {
                totalPrice = grapefruitPrice * amount;
            }
            else if (fruit == "kiwi")
            {
                totalPrice = kiwiPrice * amount;
            }
            else if (fruit == "pineapple")
            {
                totalPrice = pineapplePrice * amount;
            }
            else if (fruit == "grapes")
            {
                totalPrice = grapesPrice * amount;
            }
            else
            {
                isCorrect = false;
            }

            if (isCorrect == false)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
