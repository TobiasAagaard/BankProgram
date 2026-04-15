namespace ShellBank.Models
{
    class Bank
    {
        private int id;
        private string name;
        private List<Advisor> advisors;
        private List<Customer> customers;

        public Bank(int id, string name, List<Advisor> advisors, List<Customer> customers)
        {
            this.id = id;
            this.name = name;
            this.advisors = advisors ?? new List<Advisor>();
            this.customers = customers ?? new List<Customer>();
          
        }

        public int BankId { get { return id; } set { id = value; } }
        public string BankName { get { return name; } set { name = value; } }
        public List<Advisor> Advisors { get { return advisors; } set { advisors = value; }}
        public List<Customer> Customers { get { return customers; } set { customers = value; }}

    }
}