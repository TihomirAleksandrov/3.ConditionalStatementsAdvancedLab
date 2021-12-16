using System;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string inRange = "";

            if (number >= -100 && number <= 100 && number != 0)
            {
                inRange = "Yes";
            }
            else
            {
                inRange = "No";
            }
            Console.WriteLine(inRange);
        }
    }
}
