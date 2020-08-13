using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public class Salary: Expense
    {
        protected int employeeId;
        protected int month;
        protected int year;
        protected byte salaryCode;

        public Salary(int employeeId, int month, int year, byte salaryCode, decimal amount, DateTime date): base(amount, date)
        {
            EmployeeId = employeeId;
            Month = month;
            Year = year;
            SalaryCode = salaryCode;
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

        public virtual int Month
        {
            get
            {
                return month;
            }

            set
            {
                month = value;
            }
        }

        public virtual int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public virtual byte SalaryCode
        {
            get
            {
                return salaryCode;
            }

            set
            {
                salaryCode = value;
            }
        }

        public override decimal GetAmount()
        {
            switch(salaryCode)
            {
                case 9:
                    return 17000;
                case 8:
                    return 15000;
                case 4:
                    return 18000;
                case 3:
                    return 27000;
                case 2:
                    return 25000;
                default:
                    return 0;
            }
        }
    }
}