using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S3_IPayable_classes
{
    public class ProductSale : Sale
    {
        protected Dictionary<Product, int> productQuantities;

        public ProductSale(Dictionary<Product, int> productQuantities, int employeeId, DateTime date): base(employeeId, date)
        {
            ProductQuantities = productQuantities;
        }

        public virtual Dictionary<Product, int> ProductQuantities
        {
            get
            {
                return productQuantities;
            }

            set
            {
                productQuantities = value;
            }
        }

        public void Add(Product product, int quantity)
        {
            productQuantities.Add(product, quantity);
        }

        public override decimal GetAmount()
        {
            decimal totalPrice = 0;

            foreach(KeyValuePair<Product, int> product in productQuantities)
            {
                totalPrice += (Convert.ToDecimal(product.Value) * product.Key.UnitPrice);
            }
            return totalPrice;
        }
    }
}