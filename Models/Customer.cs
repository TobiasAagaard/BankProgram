namespace BankProgram.Models
{
    class Customer
    {
        private int id;
        private string name;
        private string email;
        private List<BankAccount> accounts;

        public Customer(int id, string name, string email, List<BankAccount> accounts)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.accounts = accounts;
        }

        public string CustomerName { get { return name; } private set { name = value;}}

        public int CustomerId { get { return id; } private set { id = value;}}

        public string Email { get { return email; } private set { email = value;}}

        public List<BankAccount> Accounts { get { return accounts;} private set { accounts = value;}}

    }
}