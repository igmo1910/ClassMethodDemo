using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var customerManager=new CustomerManager();

            var customers = new List<Customer>();
            var defaultCustomer = new Customer
            {
                Name = "İsmail",
                Surname = "Gümüş",
                Age = 37,
                City = "Ankara",
                IsDeleted = false,
                Id = 1
            };
            customers.Add(defaultCustomer);

            Console.WriteLine("1. Müşteri Ekle");
            Console.WriteLine("2. Müşteri Sil");
            Console.WriteLine("3. Müşteri Güncelle");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            var operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Müşteri Adı:");
                    customer.Name = Console.ReadLine();
                    Console.WriteLine("Müşteri Soyadı:");
                    customer.Surname = Console.ReadLine();
                    Console.WriteLine("Müşteri Şehri:");
                    customer.City = Console.ReadLine();
                    Console.WriteLine("Müşteri Yaşı:");
                    customer.Age = Convert.ToInt32(Console.ReadLine());
                    customerManager.Add(customer);
                    break;
                case 2:
                    customerManager.ListAll(customers);
                    Console.WriteLine("Silmek istediğiniz müşteriyi id'sini seçiniz:");
                    var selectedCustomer = Convert.ToInt32(Console.ReadLine());
                    customer = customers.FirstOrDefault(x => x.Id == selectedCustomer);
                    customerManager.Delete(customer);
                    break;
                case 3:
                    customerManager.ListAll(customers);
                    Console.WriteLine("Güncellemek istediğiniz müşteriyi id'sini seçiniz:");
                    selectedCustomer = Convert.ToInt32(Console.ReadLine());
                    customer = customers.FirstOrDefault(x => x.Id == selectedCustomer);
                    customerManager.Update(customer);
                    break;
            }
        }
    }
}
