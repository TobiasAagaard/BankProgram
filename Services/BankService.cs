namespace ShellBank.Services
{
    using ShellBank.Models;
    using ShellBank.Data;
    class BankService
    {
        private readonly ShellBankContext data;

        public BankService(ShellBankContext data)
        {
            this.data = data;
        }

        public List<Bank> GetAllBanks()
        {
            return data.Banks.ToList();
        }

        public Bank CreateBank(string name)
        {
            Bank newBank = new Bank { Name = name };
            data.Banks.Add(newBank);
            data.SaveChanges();
            return newBank;
        }
    }
}