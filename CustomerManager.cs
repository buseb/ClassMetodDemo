using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + " "+ "müşteri numaralı" +" "+ customer.Ad + " " + customer.Soyad + " " + "sisteme eklenmiştir.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " "+ "müşteri numaralı" +" "+ customer.Ad + " " + customer.Soyad + " " + "sistemden silinmiştir.");
        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("............");
            Console.WriteLine("Müşteri Numarası = " + " "+customer.Id);
            Console.WriteLine("Adı ve Soyadı = " + " "+ customer.Ad + " " + customer.Soyad);
            Console.WriteLine("............");

        }

    }
}
