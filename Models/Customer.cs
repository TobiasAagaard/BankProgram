namespace ShellBank.Models
{
    class Customer
    {
        private int id;
        private string name;
        private string email;
        private List<BankAccount> bankAccounts;

        public Customer(int id, string name, string email, List<BankAccount> bankAccounts)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.bankAccounts = bankAccounts ?? new List<BankAccount>(); 
        }

        public string CustomerName { get { return name; } set { name = value;}}

        public int CustomerId { get { return id; } set { id = value;}}

        public string Email { get { return email; } set { email = value;}}
        public List<BankAccount> BankAccounts { get { return bankAccounts; } set { bankAccounts = value; }}
    }
}