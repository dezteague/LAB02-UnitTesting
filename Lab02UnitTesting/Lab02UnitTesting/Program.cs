using System;

namespace Lab02UnitTesting
{
    public class Program
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
                Console.WriteLine("");
                Console.WriteLine("Please select one of the following actions. Enter 1/2/3/4");
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
                        Deposit(userDeposit);
                        Console.WriteLine($"Your deposit was successful, your new balance is {balance}");
                        break;
                    case 2:
                        Console.WriteLine("Enter withdrawal amount:");
                        string withdrawal = Console.ReadLine();
                        decimal userWithdrawal = Convert.ToInt32(withdrawal);
                        decimal wdMethod = Withdraw(userWithdrawal);
                        if (wdMethod == 0)
                        {
                            Console.WriteLine($"Sorry, you have insufficient funds, your balance is {balance}");
                            break;
                        }
                        else
                        {
                            Withdraw(userWithdrawal);
                            Console.WriteLine($"Your withdrawal was successful, your new balance is {balance}");
                            break;
                        }
                    case 3:
                        Console.WriteLine($"Your balance is {CurrentBalance()}");
                        break;
                    //when the action is false, break out of the loop
                    case 4:
                        action = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid action");
                        break;
                }
            }
        }

        public static decimal Deposit(decimal value)
        {
            //+= allows the initial balance to keep adding values
            balance += value;
            return balance;
        }

        public static decimal Withdraw(decimal value)
        {
            if (value <= balance)
            {
                balance -= value;
                return balance;
            }
            else
            {
                return 0;
            }      
        }

        public static decimal CurrentBalance()
        {
            return balance;
        }
    }
}
