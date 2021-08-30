using System;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.UserControll();
        }
        /// <summary>
        /// Asks the user for new calculation.
        /// </summary>
        private static void UserControll()
        {
            bool wontsToCalculate = true;
            while (wontsToCalculate)
            {
                Console.Write("Please input a number to check if it a prime number: ");

                string userInput = Console.ReadLine();
                PrimeNumber.CheckInput(userInput);
                Console.WriteLine("\n\nDo you wont to calculate new number?\n\n" + "Press [1] Yes\nPress [2] No \nPress [3] if you wont to print all inputed Prime Numbers");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        wontsToCalculate = true;
                    }
                    else if (input == 2)
                    {
                        wontsToCalculate = false;
                    }
                    else if (input == 3)
                    {
                        PrimeNumber.Print();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choose!, Please choose [1],[2] or [3]");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid choose!, Please choose [1],[2] or [3]");
                }


            }
        }
    }
}
