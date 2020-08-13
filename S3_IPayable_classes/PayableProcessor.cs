using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace S3_IPayable_classes
{
    public class PayableProcessor
    {
        protected Account salesAccount;
        protected Account expensesAccount;

        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            ExpensesAccount = expensesAccount;
            SalesAccount = salesAccount;
        }

        public virtual Account SalesAccount
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

        public virtual Account ExpensesAccount
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

        public virtual bool IsProcessed { get; set; }

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
                IsProcessed = true;
            }
        }
    }
}