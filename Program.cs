using System.Security.Cryptography.X509Certificates;

namespace BankProgram
{
    class Program
    {

      
        static void Main(string[] args)
        { 
            List<Bank> banks = new List<Bank>();
            

            string AddBank(string name, List<Customer> customers)
            {
                if (banks.Any(bank => bank.BankName == name))
                {
                    throw new Exception("Bank already exists");
                }
                else
                {
                    int id = banks.Count + 1;
                    banks.Add(new Bank(id, name, customers));
                    return "Bank added successfully";
                }
            }

            string RemoveBank(int id)
            {
                if (banks.Any(bank => bank.BankId == id))
                {
                    banks.RemoveAll(bank => bank.BankId == id);
                    return "Bank removed successfully";
                }
                else
                {
                    throw new Exception("Bank not found");
                }
            }
            
            Customer customer1 = new Customer(1, "Toibas Aagaard Christiansen", new List<BankAccount>());
            customer1.AddAccount(new BankAccount(1, "Opsparing", 1000));
            customer1.AddAccount(new BankAccount(2, "Løn", 500));
            customer1.AddAccount(new BankAccount(3, "Investering", 2000));

            Customer customer2 = new Customer(2, "Mads Aagaard Christiansen", new List<BankAccount>());
            customer2.AddAccount(new BankAccount(4, "Opsparing", 150000));

            Customer customer3 = new Customer(3, "Mikkel Aagaard Christiansen", new List<BankAccount>());
            customer3.AddAccount(new BankAccount(5, "konto", 63000.424m));

            List<Customer> customers = new List<Customer>() { customer1, customer2, customer3 };
            
            banks.Add(new Bank(1, "Nordea", new List<Customer>() { customer1, customer2 }));
            banks.Add(new Bank(2, "Danske Bank", new List<Customer>() { customer3 }));


            Console.WriteLine(banks[0].GetBankDetails());
            Console.WriteLine(banks[1].GetBankDetails());
            Console.WriteLine(Customer.GetAllCustomersDetails(customers));
        }
    }
}
