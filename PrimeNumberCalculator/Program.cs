using System;

namespace PrimeNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program.StartControll();
        }
        /// <summary>
        /// Start up method to controll and communicate with the user and the program  .
        /// </summary>
        private static void StartControll()
        {
           
            bool wontsToCalculate = true;
            while (wontsToCalculate)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\t\t-------------------- Prime Number Calculator --------------------");
                Console.Write("\nPlease input a number to check if it a prime number: ");

                string userInput = Console.ReadLine();
                PrimeNumber.CheckInput(userInput);
                choices:
                try
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n\nDo you wont to calculate new number?\n Press [1] Yes\n Press [2] No \n Press [3] if you wont to print all inputed Prime Numbers");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        wontsToCalculate = true;
                    }
                    else if (input == 2)
                    {
                        wontsToCalculate = false;
                        break;
                    }
                    else if (input == 3)
                    {
                        PrimeNumber.Print();
                        //wontsToCalculate = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid choose!, Please choose [1],[2] or [3]");
                        goto choices;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid choose!, Please choose [1],[2] or [3]");
                    goto choices;

                }


            }
        }
    }
}
