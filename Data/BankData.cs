namespace ShellBank.Data
{
    using ShellBank.Models;
    class BankData
    {
        public List<Bank> Banks { get; } = new();
        public List<Advisor> Advisors { get; } = new();
        public List<Customer> Customers { get; } = new();
        public List<BankAccount> BankAccounts { get; } = new();

        private int nextBankId = 1;
        private int nextAdvisorId = 1;
        private int nextCustomerId = 1;
        private int nextAccountId = 1;

        public int GetNextBankId() => nextBankId++;
        public int GetNextAdvisorId() => nextAdvisorId++;
        public int GetNextCustomerId() => nextCustomerId++;
        public int GetNextAccountId() => nextAccountId++;
        public BankData(List<Bank> banks)
        {
            this.Banks = banks;
        }
        public BankData()
        {
            Banks.Add(new Bank(GetNextBankId(), "TechColleage Bank", new List<Advisor>(), new List<Customer>()));
        }
    }
}