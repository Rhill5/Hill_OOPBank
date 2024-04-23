using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hill_OOPBank
{
    internal class Program
    {

        static void Main(string[] args)
        {

            decimal amount;
            bool CheckNumber = false;
            string numberInput = "";
            char userKey;
            Bank bank = new Bank(1000m);  
            bool isRunning = true;
            
            while (isRunning)
            {

            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Quit");
            userKey = Console.ReadKey().KeyChar;

                switch (userKey)
                {
                    case '1':
                        Notice();
                        break;
                    case '2':
                        Console.WriteLine("Amount to withdraw:\n");
                        numberInput = Console.ReadLine();
                        CheckNumber = decimal.TryParse(numberInput, out amount);
                        if (CheckNumber)
                        {
                        bank.Withdraw(bank.Balance, amount);
                        Notice();
                        }
                        else
                        {
                        Console.WriteLine("Incorrect Input");
                        }
                        break;
                    case '3':
                        Console.WriteLine("Amount to deposit:\n");
                        numberInput = Console.ReadLine();
                        CheckNumber = decimal.TryParse(numberInput, out amount);
                        bank.Deposit(bank.Balance, amount);
                        Notice();
                        break;
                    case '4': isRunning = false; break;
                    default: Console.Clear(); Console.WriteLine("Invalid Input"); break;
                }
            }
            void Notice()
            {
                bank.Checkbalance();
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
