using System;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            PrimeNumber.CheckInput(userInput);
            Console.Read();
        }
    }
}
