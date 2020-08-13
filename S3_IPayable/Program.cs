using S3_IPayable_classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace S3_IPayable
{
    class Program
    {
        static void Main()
        {
            List<IPayable> payables = new List<IPayable>()
            {
                new Salary(1, 1, 2020, 2, 0, DateTime.Now),
                new ServiceSale(250, 1, DateTime.Now),
                new ProductSale(new Dictionary<Product, int>() { {new Product("ting", 690), 5} },  1, DateTime.Now),
            };

            PayableProcessor payableProcessor = new PayableProcessor(new Account(0), new Account(0));
            payableProcessor.Process(payables);
            Console.WriteLine($"Sales account: {payableProcessor.SalesAccount.Balance}");
            Console.WriteLine($"Expenses account: {payableProcessor.ExpensesAccount.Balance}");
            Console.ReadLine();
        }
    }
}