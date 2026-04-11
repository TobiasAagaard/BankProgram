namespace BankProgram
{
    class Bank
    {
        private string name;
        private List<Bank> banks;
        private List<Customer> customers;

        public Bank(string name, List<Bank> banks, List<Customer> customers)
        {
            this.name = name;
            this.banks = banks;
            this.customers = customers;
        }

        public string BankName { get { return name; } private set { name = value; } }
        public List<Customer> Customers { get { return customers; } private set { customers = value;}}

        public List<Bank> Banks { get { return banks; } private set { banks = value;}}

        public string AddCustomer(Bank bank, Customer customer)
        {
            if (!banks.Contains(bank))
            {
                throw new Exception("Bank does not exist");
            }
            else {
            customers.Add(customer);
            return "Customer added successfully";
            }ß

        }

        public string RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
            return "Customer removed successfully";
        }

        public string AddBank(Bank bank)
        {
            if (banks.Contains(bank))
            {
                throw new Exception("Bank already exists");
            }
            else
            {
                banks.Add(bank);
                return "Bank added successfully";
            }
        }
        
        public string RemoveBank(Bank bank)
        {
            if (!banks.Contains(bank))
            {
                throw new Exception("Bank deos not exist")
            }
            else
            {
                banks.Remove(bank);
                return "Bank removed successfully";
            }
        }

    }
}