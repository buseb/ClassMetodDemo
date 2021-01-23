using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 2521;
            customer1.Ad = "Buse";
            customer1.Soyad = "Bahşi";

            Customer customer2 = new Customer();
            customer2.Id = 1429;
            customer2.Ad = "Ali";
            customer2.Soyad = "Özer";

            Customer customer3 = new Customer();
            customer3.Id = 5876;
            customer3.Ad = "Can";
            customer3.Soyad = "Küçük";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("**************************************************");

            //Customer Add

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("****************************************************");
            //Customer Delete
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            Console.WriteLine("****************************************************");
            //Customer List

            customerManager.CustomerList(customer1);
            customerManager.CustomerList(customer2);
            customerManager.CustomerList(customer3);



        }
    }
}
