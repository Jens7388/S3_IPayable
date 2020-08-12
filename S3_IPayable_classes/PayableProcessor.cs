using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace S3_IPayable_classes
{
    public class PayableProcessor
    {
        private Account salesAccount;
        private Account expensesAccount;

        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            ExpensesAccount = expensesAccount;
            SalesAccount = salesAccount;
        }

        public Account SalesAccount
        {
            get
            {
                return salesAccount;
            }

            set
            {
                salesAccount = value;
            }
        }

        public Account ExpensesAccount
        {
            get
            {
                return expensesAccount;
            }

            set
            {
                expensesAccount = value;
            }
        }

        public virtual void Process(List<IPayable> payables)
        {
            foreach(IPayable payable in payables)
            {
                if(payable is Sale)
                {
                    salesAccount.Deposit(payable.GetAmount());
                }
                else
                {
                    expensesAccount.Withdraw(payable.GetAmount());
                }              
            }
        }
    }
}