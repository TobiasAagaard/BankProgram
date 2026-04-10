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

            

            Console.WriteLine(customer1.GetCustomerDetails());
            Console.WriteLine(customer2.GetCustomerDetails());
    
          
        }
    }
}
