using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput.Welcome();
            bool continueFlag = true;
            while (continueFlag)
            {
                int userChoice = UserInput.GetInput();
                int primeIndex = PrimeCheck.GetPrime(userChoice);
                UserInput.Result(userChoice, primeIndex);
                UserInput.GoAgain(ref continueFlag);
            }
            Console.WriteLine("OK BYEEEEEEEEEE!!!!!!!");
        }
    }
}
