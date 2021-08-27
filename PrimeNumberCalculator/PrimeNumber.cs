using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCalculator
{
    public class PrimeNumber
    {
        // static string userInput;
        static int convertedInput;

        static bool isPrime;

        private static bool inputType = true;
        public static List<int> primeNumbers = new List<int>();


        public static void NotifyUser(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                //Here should I use try catch statment.
                convertedInput = Convert.ToInt32(userInput);
                //Console.WriteLine(userInput.GetType());
                //Int32.TryParse(userInput, out convertedInput);
                inputType = convertedInput.GetType() != typeof(int);
                if (inputType)
                {
                    Console.WriteLine("\tOBS wrong type of input, requires a number, please try again");
                }
                else if (convertedInput == 0 || convertedInput == 1)
                {
                    Console.WriteLine("\tOBS 1 and 0 is not prime numbers");
                }
                else if (inputType.GetType() == typeof(string))
                {
                    Console.WriteLine("\tYou have not entered a number, please try again ");
                }
                else
                {
                    CheckNumber();
                    if (isPrime)
                    {
                        Console.WriteLine("\t" + userInput + " Is a prime number");
                        //primeNumbers.Add(4);
                        primeNumbers.Add(convertedInput);
                    }
                }

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }

        }

        /// <summary>
        /// Checks the number if it is prime!
        /// </summary>
        /// <param name="number"></param>
        /// <returns>False Or True</returns>
        private static bool CheckNumber()
        {
            if (convertedInput % convertedInput != 0 && convertedInput % 2 != 0)
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
        private static void Print(List<int> numbars)
        {
            foreach (var number in numbars)
            {
                Console.WriteLine(number);
            }
        }


    }
}
