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
                    else if (convertedInput < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\tOBS Negative numbers can't be prime");
                    }
                    else if (inputType.GetType() == typeof(string))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\tYou have not entered a number, please try again ");
                    }
                    else
                    {
                        CheckNumber(convertedInput);
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
                catch (Exception e)
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
        private static bool CheckNumber(int number)
        {

            if (number <= 1)
            {
                return isPrime = false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return isPrime = false;
            }

            isPrime = true;

            return isPrime;

        }
        /// <summary>
        /// Checks Next Prime Number.
        /// </summary>
        public static int CheckNextPrime()
        {
            Sort();
            int nextNumber = 0;
            var highestPrimeNumber = primeNumbers[primeNumbers.Count - 1] + 1;
            for (nextNumber = highestPrimeNumber; nextNumber < 1000; nextNumber++)
            {
                if (CheckNumber(nextNumber))
                {
                    primeNumbers.Add(nextNumber);

                }
                break;

            }
            return nextNumber;

        }       

        /// <summary>
        /// Sorts list of numbers.<br/>
        /// "Insertion Sort" algorithm to sort list of numbers.
        /// </summary>
        private static void Sort()
        {
            //primeNumbers.Sort();
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                var number = primeNumbers[i];
                var currentNumber = i;
                while (currentNumber > 0 && primeNumbers[currentNumber - 1] > number)
                {
                    primeNumbers[currentNumber] = primeNumbers[currentNumber - 1];
                    currentNumber--;
                }
                primeNumbers[currentNumber] = number;
            }
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
