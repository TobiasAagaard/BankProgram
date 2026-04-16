namespace ShellBank.Models
{
    class BankAccount
    {
    
    public BankAccount(int id, string name, decimal balance = 0)
        {
            this.AccountId = id;
            this.AccountName = name;
            this.Balance = balance;
        }
        public int AccountId { get; private set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

    }
        
}