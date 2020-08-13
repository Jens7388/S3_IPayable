using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public abstract class Sale: IPayable
    {          
        protected DateTime date;
        protected int employeeId;

        protected Sale(int employeeId, DateTime date)
        {
            EmployeeId = employeeId;
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

        public virtual int EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        public virtual bool IsProcessed{ get; set; }

        public abstract decimal GetAmount();
    }
}