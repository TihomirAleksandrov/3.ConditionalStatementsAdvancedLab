using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string working = "";

            if (day != "Sunday")
            {
                if (hour >= 10 && hour <= 18)
                {
                    working = "open";
                }
                else
                {
                    working = "closed";
                }
            }
            else
            {
                working = "closed";
            }
            Console.WriteLine(working);
        }
    }
}
