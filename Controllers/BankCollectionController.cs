namespace BankProgram
{
    class BankCollectionController
    {
        private List<Bank> banks = new();
        private int nextBankId = 1;

        public BankCollectionController()
        {
            banks.Add(new Bank(nextBankId++, "Nordea", new List<Advisor>()));
        }

        public void CreateBank()
        {
            Console.WriteLine("Enter Bank Name:");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Bank name cannot be empty. Please try again.");
                return;
            }

            Bank newBank = new Bank(nextBankId++, name, new List<Advisor>());
            banks.Add(newBank);
            Console.WriteLine($"Bank '{name}' created with ID: {newBank.BankId}");
        }
        public List<Bank> GetAllBanks()
        {
            return banks;
        }
    }
}