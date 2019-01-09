using System;

namespace Lab02UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Teague Bank!");

            bool action = true;
            while (action)
            {
                Console.WriteLine("Select on of the following actions. Enter (1,2,3,4)");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. My Balance");
                Console.WriteLine("4. Exit");
                string operation = Console.ReadLine();
                int userInput = Convert.ToInt32(operation);

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Enter desposit amount:");
                        break;
                    case 2:
                        Console.WriteLine("Enter withdrawal amount:");
                        break;
                    case 3:
                        Console.WriteLine("Your balance is");
                        break;
                }
            }
        }
    }
}
