using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace S3_IPayable_classes
{
    public class Account
    {
        private decimal balance;
        public Account(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public void Deposit(decimal amount) {
             balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
    }
}