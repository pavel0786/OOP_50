using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_50.Class
{
    class Account
    {
        private string accountName;
        private string accountNumber;
        private decimal balance;

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public bool Deposit(decimal amount)
        {       
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            balance = balance - amount;
            return true;
        }

        public Account(string Name, string No)
        {
            this.accountName = Name;
            this.accountNumber = No;
        }

    }
}
