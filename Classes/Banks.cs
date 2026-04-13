namespace BankProgram
{
    class Bank
    {
        private int id;
        private string name;
        private List<Customer> customers;

        public Bank(int id, string name, List<Customer> customers)
        {
            this.id = id;
            this.name = name;
            this.customers = customers;
        }

        public int BankId { get { return id; } private set { id = value; } }

        public string BankName { get { return name; } private set { name = value; } }
        public List<Customer> Customers { get { return customers; } private set { customers = value;}}

    }
}