using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public class ServiceSale : Sale
    {
        protected decimal amount;

        public ServiceSale(decimal amount, int employeeId, DateTime date): base(employeeId, date)
        {
            Amount = amount;
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
        public override decimal GetAmount()
        {
            return amount;
        }
    }
}