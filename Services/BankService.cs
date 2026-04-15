namespace ShellBank.Services
{
    using ShellBank.Models;
    using ShellBank.Data;
    class BankService
    {
        private BankData data;

        public BankService(BankData data)
        {
            this.data = data;
        }

        public List<Bank> GetBanks() => data.Banks;

        public Bank CreateBank(string name)
        {
            Bank newBank = new Bank(data.GetNextBankId(), name, new List<Advisor>(), new List<Customer>());
            data.Banks.Add(newBank);
            return newBank;
        }

        public Bank? GetBankByIndex(int index)
        {
            if (index >= 0 && index < data.Banks.Count)
            {
                return data.Banks[index];
            }
            return null;
        }
    }
}