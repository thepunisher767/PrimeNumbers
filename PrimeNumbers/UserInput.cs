using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    class UserInput
    {
        public static void Welcome()    //Welcome!
        {
            Console.WriteLine("Lets locate some primes!\n");
            Console.WriteLine("This application will find you any prime, in order, from first prime number on.\n");
        }
        public static int GetInput()   //Gets user input
        {
            Console.Write("Which prime number are you looking for?: ");
            string userInput = Console.ReadLine();
            int validInt;
            while (!int.TryParse(userInput, out validInt))
            {
                Console.Write("Please enter a valid integer: ");
                userInput = Console.ReadLine();
            }
            Console.WriteLine();
            return validInt;
        }
        public static bool GoAgain(ref bool continueFlag) //Checks to continue or not and returns bool
        {
            Console.Write("Do you want to find another prime number? (y/n): ");
            string userInput = Console.ReadLine();
            while (userInput.ToLower() != "y" && userInput.ToLower() != "n")
            {
                Console.Write("Please enter valid input (y/n): ");
                userInput = Console.ReadLine();
            }
            if (userInput == "n")
            {
                continueFlag = false;
            }
            Console.WriteLine();
            return continueFlag;
        }
        public static void Result(int userChoice, int primeIndex)
        {
            Console.WriteLine($"The number {userChoice} prime is {primeIndex}.\n");
        }

    }
}
