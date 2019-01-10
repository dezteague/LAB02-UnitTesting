using System;

namespace Lab02UnitTesting
{
    class Program
    {
        //initial balance
        public static decimal balance = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Teague Bank!");

            //boolean sets the initial condition for the while loop
            bool action = true;

            //while loop allows the user interface to run until the user exits
            while (action)
            {
                Console.WriteLine("Select one of the following actions. Enter 1/2/3/4");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. My Balance");
                Console.WriteLine("4. Exit");
                string operation = Console.ReadLine();
                int userInput = Convert.ToInt32(operation);

                //decimal amount;

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Enter deposit amount:");
                        string deposit = Console.ReadLine();
                        decimal userDeposit = Convert.ToInt32(deposit);
                        Console.WriteLine($"Your deposit was successful, your new balance is {Deposit(userDeposit)}");
                        break;
                    case 2:
                        Console.WriteLine("Enter withdrawal amount:");
                        string withdrawal = Console.ReadLine();
                        decimal userWithdrawal = Convert.ToInt32(withdrawal);
                        break;
                    case 3:
                        Console.WriteLine("Your balance is");
                        break;
                    //when the action is false, break out of the loop
                    case 4:
                        action = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid action");
                        break;
                }
                 
                Console.WriteLine("Would you like to make another transaction?");
                Console.WriteLine("y/n");
            }
        }

        static decimal Deposit(decimal value)
        {
            //+= allows the initial balance to keep adding values
            balance += value;
            return balance;
        }
    }
}
