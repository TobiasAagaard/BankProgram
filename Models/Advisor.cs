namespace ShellBank.Models
{
    class Advisor
    {
        public Advisor(int id, string name, string email, List<Customer> customers, List<BankAccount> bankAccounts)
        {
            this.AdvisorId = id;
            this.AdvisorName = name;
            this.AdvisorEmail = email;
            this.Customers = customers ?? new List<Customer>();
            this.BankAccounts = bankAccounts ?? new List<BankAccount>();
        }

        public int AdvisorId { get; private set;}
        public string AdvisorName { get; set; }
        public string AdvisorEmail { get; set; }
        public List<Customer> Customers { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
    }
}