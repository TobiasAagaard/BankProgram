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

        public string CreateBank()
        {
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                return $"Invalid bank name. Bank creation failed.";
            }

            Bank newBank = new Bank(nextBankId++, name, new List<Advisor>());
            banks.Add(newBank);
            return $"Bank '{name}' created with ID: {newBank.BankId}";
        }
        public List<Bank> GetAllBanks()
        {
            return banks;
        }

    }
}