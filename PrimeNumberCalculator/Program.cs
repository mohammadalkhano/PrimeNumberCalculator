using System;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please input a number to check if it a prime number...");
                string userInput = Console.ReadLine();
                PrimeNumber.CheckInput(userInput);

            }

            Console.Read();
        }
    }
}
