namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            Customer customer1 = new Customer(1, "Toibas Aagaard Christiansen", new List<BankAccount>());
     
            customer1.AddAccount(new BankAccount(1, "Opsparing", 1000));
            customer1.AddAccount(new BankAccount(2, "Løn", 500));
            customer1.AddAccount(new BankAccount(3, "Investering", 2000));

            Customer customer2 = new Customer(2, "Mads Aagaard Christiansen", new List<BankAccount>());
            customer2.AddAccount(new BankAccount(4, "Opsparing", 150000));

            



            void printAccountInfo(List<BankAccount> bankAccounts)
            {
                for (int i = 0; i < bankAccounts.Count; i++)
                {
                    BankAccount account = bankAccounts[i];
                    Console.WriteLine($"Account holder: {account.AccountName}, Balance: {account.Balance} DKK");
                    
                }
            }

            void printCustomerInfo(Customer customer)
            {
                Console.WriteLine($"Customer name: {customer.CustomerName}");
                Console.WriteLine("Accounts:");
                printAccountInfo(customer.Accounts);
            }

            void printAllCustomers(List<Customer> customers)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    Customer customer = customers[i];
                    printCustomerInfo(customer);
                    Console.WriteLine();
                }
            }

            printAllCustomers(new List<Customer> { customer1, customer2 });
        }
    }
}
