﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated!");
        }

        public void ListAll(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşteri id: " + customer.Id);
                Console.WriteLine("Müşteri adı: " + customer.Name);
                Console.WriteLine("Müşteri soyadı: " + customer.Surname);
                Console.WriteLine("------");
            }

        }
    }
}
