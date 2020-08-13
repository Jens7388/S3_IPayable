using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public class Expense : IPayable
    {
        protected DateTime date;
        protected decimal amount;

        public Expense(decimal amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public virtual DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public virtual decimal Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public virtual bool IsProcessed { get; set; }

        public virtual decimal GetAmount()
        {
            return amount;
        }
    }
}