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

            Customer customer3 = new Customer(3, "Mikkel Aagaard Christiansen", new List<BankAccount>());
            customer3.AddAccount(new BankAccount(5, "konto", 63000.424m));

            

            List<Customer> customers = new List<Customer>() { customer1, customer2, customer3 };
            Console.WriteLine(Customer.GetAllCustomersDetails(customers));
        }
    }
}
