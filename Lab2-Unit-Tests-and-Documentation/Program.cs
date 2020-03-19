using System;

namespace Lab2_Unit_Tests_and_Documentation
{
    public class Program
    {
        public static decimal Balance = 500;
        static void Main()
        {
            try
            {
                //put all console writelines and readlines here
                Console.WriteLine("Welcome to the ATM! Would you like to view your balance, withdraw money, add money or exit?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "view balance")
                {
                    ViewBalance(Balance);
                }
                else if (answer == "withdraw money")
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    string response = Console.ReadLine();
                    decimal number = Convert.ToInt32(response);
                    //public static decimal ToDecimal(string value, IFormatProvider provider);

                    WithdrawMoney(number);
                }
                else if (answer == "add money")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    string giveMeMoney = Console.ReadLine();
                    decimal number = Convert.ToInt32(giveMeMoney);
                    AddMoney(number);

                }
                else if (answer == "exit")
                {
                    Exit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred. Error message {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for trusting us with your money!");
            }
        }


        public static decimal ViewBalance(decimal number)
        {

            return number;

        }

        public static decimal WithdrawMoney(decimal number)
        {
            
            if (Balance <= 0)
            {
                Console.WriteLine("Sorry, insufficient funds!");
            }
            else if (Balance > 0)
            {
                Balance -= number;
            }
            return Balance;
        }

        public static string AddMoney(decimal number)
        {
            if (number > 0)
            {
                Balance += number;
                return "Deposit complete";
            }
            else
            {
                //Console.WriteLine("Invalid input");
                return "Invalid input";
            }
        }

        public static void Exit()
        
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        
        }
    }
}
