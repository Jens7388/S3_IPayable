using System;
using System.Collections.Generic;
using System.Text;

namespace S3_IPayable_classes
{
    public class Product
    {
        private string name;
        private decimal unitPrice;

        public Product(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public string Name
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

        public decimal UnitPrice
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
