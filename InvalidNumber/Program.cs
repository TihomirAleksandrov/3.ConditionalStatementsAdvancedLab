using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string validNumber = "";

            if ((number >= 100 && number <= 200) || number == 0)
            {
                
            }
            else
            {
                validNumber = "invalid";
            }
            Console.WriteLine(validNumber);
        }
    }
}
