namespace BankProgram
{
    class Bank
    {
        private string name;
        private List<Customer> customers;

        public Bank(string name, List<Customer> customers)
        {
            this.name = name;
            this.customers = customers;
        }

        public string BankName { get { return name; } private set { name = value; } }
        public List<Customer> Customers { get { return customers; } private set { customers = value; } }
    }
}