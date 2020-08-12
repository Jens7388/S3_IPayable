using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public class Product
    {
        protected string name;
        protected decimal unitPrice;

        public Product(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public virtual decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}