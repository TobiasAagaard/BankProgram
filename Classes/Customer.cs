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
            this.accounts = accounts;
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

        public string GetCustomerDetails()
        {
            string accountDetails = "";
            for (int i = 0; i < accounts.Count; i++)
            {
                accountDetails += accounts[i].GetAccountDetails() + "\n";
            }
            return $"Customer name: {name}\nAccounts:\n{accountDetails}";
        }

       public static string GetAllCustomersDetails(List<Customer> customers)
        {
            string allDetails = "";
            for (int i = 0; i < customers.Count; i++)
            {
                allDetails += customers[i].GetCustomerDetails() + "\n";
            }
            return allDetails;
        }
        
    }
}