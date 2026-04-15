namespace ShellBank.Models
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
         
        public string AccountName {get { return name; } set { name = value; } }
        public int AccountId { get { return id; } set { id = value;}}
        public decimal Balance { get { return balance;} set { balance = value;}}

        }
        
}