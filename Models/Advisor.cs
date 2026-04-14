namespace BankProgram.Models
{
    class Advisor
    {
        private int id;
        private string name;
        private string email;
        private List<Customer> customers;
        
        public Advisor(int id, string name, string email, List<Customer> customers)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.customers = customers;
        }

        public int AdvisorId { get { return id; } private set { id = value; }}
        public string AdvisorName { get { return name; } private set { name = value; }}
        public string AdvisorEmail { get { return email;} private set { email = value; }}
        public List<Customer> Customers { get { return customers; } private set { customers = value; }}
    }
}