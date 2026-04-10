using System.Reflection.Metadata.Ecma335;

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
         
        public string AccountName {get { return name; } private set { name = value; } }
        public int AccountId { get { return id; } private set { id = value;}}
        public decimal Balance { get { return balance;} private set { balance = value;}}

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        
        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new Exception("Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }
        }
        
}