namespace BankProgram
{
    class BankAccount
    {
        private int id;
        private decimal balance;
        private string name;
   

        public BankAccount(int id, string name, decimal balance = 0)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
         
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal getBalance()
        {
            return balance;
        }

        public void deposit(decimal amount)
        {
            balance += amount;
        }
        
        public void withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }
        }
        
}