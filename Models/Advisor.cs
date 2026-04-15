namespace ShellBank.Models
{
    class Advisor
    {
        private int id;
        private string name;
        private string email;
        private List<Customer> customers;
        private List<BankAccount> bankAccounts;
        
        public Advisor(int id, string name, string email, List<Customer> customers, List<BankAccount> bankAccounts)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.customers = customers ?? new List<Customer>();
            this.bankAccounts = bankAccounts ?? new List<BankAccount>();
        }

        public int AdvisorId { get { return id; } set { id = value; }}
        public string AdvisorName { get { return name; } set { name = value; }}
        public string AdvisorEmail { get { return email;} set { email = value; }}
        public List<Customer> Customers { get { return customers; } set { customers = value; }}
        public List<BankAccount> BankAccounts { get { return bankAccounts; } set { bankAccounts = value; }}
    }
}