namespace ShellBank.Models
{
    class Customer
    {
        public Customer(int id, string name, string email, List<BankAccount> bankAccounts)
        {
            this.CustomerId = id;
            this.CustomerName = name;
            this.Email = email;
            this.BankAccounts = bankAccounts ?? new List<BankAccount>();
        }

        public int CustomerId { get; private set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
    }
}