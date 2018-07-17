using System;
using System.Collections.Generic;


namespace Collection1
{
    public class Customer
    {
        public int Custid { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class TestCustomer
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer { Custid = 101, Name = " boss ", City =
                "Bangalore", Balance = 2345.00};
            Customer c2 = new Customer
            {
                Custid = 103,
                Name = " bodss ",
                City =
               "Badngalore",
                Balance = 23445.00
            };
            Customers.Add(c1); Customers.Add(c2);

            foreach (Customer obj in Customers)
            {
                Console.WriteLine(obj.Custid + " " + obj.Name + " " + obj.City + " " + obj.Balance);
            }
            Console.ReadLine();
            }
        }
    }


/*
 
101  boss  Bangalore 2345
103  bodss  Badngalore 23445



     
     */

