namespace BankProgram
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            BankAccount[] bankAccounts = {
                new BankAccount(109234, "Tobias Christiansen", 25000.42m),
                new BankAccount(109235, "Lars Jensen", 15000.00m),
                new BankAccount(109236, "Mette Nielsen", 30000.75m)
            };


            void printAccountInfo(BankAccount[] bankAccounts)
            {
                for (int i = 0; i < bankAccounts.Length; i++)
                {
                    BankAccount account = bankAccounts[i];
                    Console.WriteLine($"Account holder: {account.Name}, Balance: {account.getBalance()} DKK");
                    
                }
            }

            printAccountInfo((bankAccounts));
        }
    }
}
