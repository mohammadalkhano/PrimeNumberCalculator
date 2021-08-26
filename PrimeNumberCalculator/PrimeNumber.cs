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
        static int parsedNumber;
        static bool isPrime;
        private static List<int> primeNumbers;
        private static bool inputType;


        public static int CheckInput(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                //Here should I use try catch statment.
                var intInput=Convert.ToInt32(userInput);
                Int32.TryParse(userInput, out parsedNumber);
                inputType = userInput.GetType() == typeof(int);
                if (inputType)
                {
                    Console.WriteLine("”wrong type of input, requires a number, please try again”");
                }
                else
                {
                    CheckNumber();
                    Console.WriteLine(userInput.GetType().ToString());
                    if (isPrime)
                    {
                        primeNumbers.Add(parsedNumber);
                    }
                }

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
            return parsedNumber;
        }

        /// <summary>
        /// Checks the number if it is prime!
        /// </summary>
        /// <param name="number"></param>
        /// <returns>False Or True</returns>
        private static bool CheckNumber()
        {
            if (parsedNumber == 0 && parsedNumber % parsedNumber != 0 && parsedNumber % 2 != 0)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
            }
            return isPrime;
        }

    }
}
