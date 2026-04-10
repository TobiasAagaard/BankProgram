namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount(109234, "Tobias Christiansen", 25000.42m),
                new BankAccount(109235, "Lars Jensen", 15000.00m),
                new BankAccount(109236, "Mette Nielsen", 30000.75m)
            };


            void printAccountInfo(List<BankAccount> bankAccounts)
            {
                for (int i = 0; i < bankAccounts.Count; i++)
                {
                    BankAccount account = bankAccounts[i];
                    Console.WriteLine($"Account holder: {account.Name}, Balance: {account.Balance()} DKK");
                    
                }
            }

            printAccountInfo((bankAccounts));
        }
    }
}
