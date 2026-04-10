namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount(1, "Opsparing", 1000),
                new BankAccount(2, "Løn", 500),
                new BankAccount(3, "Investering", 2000)
            };



            void printAccountInfo(List<BankAccount> bankAccounts)
            {
                for (int i = 0; i < bankAccounts.Count; i++)
                {
                    BankAccount account = bankAccounts[i];
                    Console.WriteLine($"Account holder: {account.AccountName}, Balance: {account.Balance} DKK");
                    
                }
            }

            printAccountInfo((bankAccounts));
        }
    }
}
