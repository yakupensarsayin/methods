using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            CustomerManager customerManager = new CustomerManager();

            while (true)
            {
                Console.WriteLine("Enter the operation you want to do: (A)dd Customer, (D)elete Customer, (S)how All Customers, (E)xit");
                string operation = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (operation)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are adding a customer\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write("Customer's First Name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Customer's Last Name: ");
                        string lastName = Console.ReadLine();

                        Customer newCustomer = new Customer();
                        newCustomer.CustomerID = customerManager.customers.Count + 1;
                        newCustomer.CustomerFirstName = firstName;
                        newCustomer.CustomerLastName = lastName;
                        customerManager.AddCustomer(newCustomer);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDone!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Read();
                        Console.Clear();
                        break;

                    case "D":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are deleting a customer\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write("Customer's ID: ");
                        int id = Int32.Parse(Console.ReadLine());

                        Customer customerToDelete = new Customer();
                        foreach (var customer in customerManager.customers)
                        {
                            if (id == customer.CustomerID)
                            {
                                customerToDelete = customer;
                                break;
                            }
                        }
                        customerManager.customers.Remove(customerToDelete);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nDone!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Read();
                        Console.Clear();
                        break;

                    case "S":
                        customerManager.ShowAllCustomers();
                        Console.Read();
                        Console.Clear();
                        break;

                    case "E":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
