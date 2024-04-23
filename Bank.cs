using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hill_OOPBank
{
    internal class Bank
    {

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; } 
            set { _balance = value; }
        }

        public Bank(decimal Balance)
        {
            _balance = Balance;
        }

        public void Checkbalance()
        {
            Console.Clear(); 
            Console.WriteLine("Your Current balance is: " + _balance.ToString("C", CultureInfo.CurrentCulture));
        }

        public decimal Withdraw(decimal Balance, decimal amount)
        {
            Console.Clear();
            if (_balance < amount && amount <= 500)
            {
                _balance = 0;
            }
            else if (amount > 500)
            {
                Console.WriteLine("Only 500 maximum may be withdrawn.\nPress any key to contiue");
                Console.ReadLine();
            }
            else { 
                _balance -= amount;
            }
            return _balance;
        }

        public decimal Deposit(decimal Balance, decimal amount)
        {
            Console.Clear();
            return _balance += amount;
        }

    }
}
