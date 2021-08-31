using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCalculator
{
    public class PrimeNumber
    {
        static int convertedInput;
        static bool isPrime;
        private static bool inputType = false;
        private static List<int> primeNumbers = new List<int>();

        /// <summary>
        /// Checks user input
        /// </summary>
        /// <param name="userInput"></param>
        public static void CheckInput(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                //Here should I use try catch statment.
                //convertedInput = Convert.ToInt32(userInput);
                try
                {
                    convertedInput = int.Parse(userInput);

                    //Int32.TryParse(userInput, out convertedInput);
                    //inputType = convertedInput.GetType() != typeof(int);
                    if (convertedInput == 0 || convertedInput == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\tOBS 1 and 0 is not prime numbers");
                    }
                    else if (inputType.GetType() == typeof(string))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\tYou have not entered a number, please try again ");
                    }
                    else
                    {
                        CheckNumber();
                        if (isPrime)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t" + userInput + " Is a prime number");
                            //primeNumbers.Add(4);
                            primeNumbers.Add(convertedInput);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\t" + userInput + " Is not a prime number");
                        }
                    }

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\tOBS wrong type of input, requires a number, please try again");
                }

            }
            else
            {
                Console.WriteLine("Please enter a number, You did not input anythink!");
            }

        }

        /// <summary>
        /// Checks the number if it is prime!
        /// </summary>
        /// <param name="number"></param>
        /// <returns>False Or True</returns>
        private static bool CheckNumber()
        {
            if (convertedInput % convertedInput == 0 && convertedInput % 2 == 0)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
            }
            return isPrime;

        }
        /// <summary>
        ///Prints list of numbers. 
        /// </summary>
        /// <param name="numbars"></param>
        public static void Print()
        {
            if (primeNumbers.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The list is empty! You did not input any prime number before!");
            }
            else
            {
                Console.WriteLine("Prime numbers list: ");
                foreach (var number in primeNumbers)
                {
                    Console.WriteLine(" " + number);
                }

            }

        }

    }
}
