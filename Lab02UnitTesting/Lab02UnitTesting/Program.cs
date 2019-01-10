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
                //convert user selection string into an integer
                string transaction = Console.ReadLine();
                int userInput = Convert.ToInt32(transaction);

                switch (userInput)
                {
                    //for all switch cases, convert user string into a decimal type
                    case 1:
                        Console.WriteLine("Enter deposit amount:");
                        string deposit = Console.ReadLine();
                        decimal userDeposit = Convert.ToInt32(deposit);
                        //invoke the deposit method
                        Deposit(userDeposit);
                        //use string interpolation to print balance after deposit
                        Console.WriteLine($"Your deposit was successful, your new balance is {balance}");
                        break;
                    case 2:
                        Console.WriteLine("Enter withdrawal amount:");
                        string withdrawal = Console.ReadLine();
                        decimal userWithdrawal = Convert.ToInt32(withdrawal);
                        //when the withdraw method is invoked, the new variable (wdMethod) will be used in conditional
                        //if statement does not allow user to withdraw more than balance (refer to withdraw method, line 81)
                        decimal wdMethod = Withdraw(userWithdrawal);
                        if (wdMethod == 0)
                        {
                            Console.WriteLine($"Sorry, invalid transaction. Withdrawal must not exceed {balance}");
                            break;
                        }
                        else
                        {
                            Withdraw(userWithdrawal);
                            Console.WriteLine($"Your withdrawal was successful, your new balance is {balance}");
                            break;
                        }
                    case 3:
                        //prints balance 
                        Console.WriteLine($"Your balance is {CurrentBalance()}");
                        break;
                    //when the action is false, break out of the loop
                    case 4:
                        action = false;
                        break;
                    //if the user inputs anything other than what's provided in switch cases, default will run
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
            //-= allows the user to make withdrawals as long as the quantity does not exceed the balance
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
