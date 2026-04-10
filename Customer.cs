namespace BankProgram
{
    class Customer
    {
        private int id;
        private string name;
        private List<BankAccount> accounts;

        public Customer(int id, string name, List<BankAccount> accounts)
        {
            this.id = id;
            this.name = name;
            this.accounts = new List<BankAccount>();
        }

        public string CustomerName { get { return name; } private set { name = value;}}

        public int CustomerId { get { return id; } private set { id = value;}}

        public List<BankAccount> Accounts { get { return accounts;} private set { accounts = value;}}

        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }

        public void RemoveAccount(BankAccount account)
        {
            accounts.Remove(account);
        }
    }
}