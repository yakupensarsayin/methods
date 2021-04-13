using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CustomerManager
    {
        public List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void ShowAllCustomers()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.CustomerID);
                Console.WriteLine("Customer's First Name: " + customer.CustomerFirstName);
                Console.WriteLine("Customer's Last Name: " + customer.CustomerLastName + "\n");
            }
        }
    }
}
