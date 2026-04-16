namespace ShellBank.Models
{
    class Bank
    {
        public Bank(int id, string name, List<Advisor> advisors, List<Customer> customers)
        {
            this.BankId = id;
            this.BankName = name;
            this.Advisors = advisors ?? new List<Advisor>();
            this.Customers = customers ?? new List<Customer>();
          
        }

        public int BankId { get; private set;}
        public string BankName { get ; set; }
        public List<Advisor> Advisors { get; set; }
        public List<Customer> Customers { get; set; }

    }
}