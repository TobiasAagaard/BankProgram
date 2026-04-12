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

        public string AddCustomer(Customer customer)
        {
            if (customers.Contains(customer))
            {
                throw new Exception("Customer already exists");
            }
            else {
                customers.Add(customer);
                return "Customer added successfully";
            }

        }

        public string RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
            return "Customer removed successfully";
        }

        public string GetBankDetails()
        {

            return $"Bank Name: {name}, Number of Customers: {customers.Count} \n";
        }

    }
}