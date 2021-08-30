using System;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.UserControll();
        }
        static void UserControll()
        {
            bool wontsToCalculate = true;
            while (wontsToCalculate)
            {
                Console.Write("Please input a number to check if it a prime number: ");
                string userInput = Console.ReadLine();
                PrimeNumber.CheckInput(userInput);
                Console.WriteLine("Do you wont to calculate new number?\n" + "Press[1] Yes\nPress[2] No");
                int input = int.Parse(Console.ReadLine());
                if (input==1)
                {
                    wontsToCalculate = true;
                }
                else if(input==2)
                {
                    wontsToCalculate = false;
                }
                else
                {
                    Console.WriteLine("Please choose [1] or [2]");
                }

            }
        }
    }
}
