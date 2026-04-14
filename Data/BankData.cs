using BankProgram.Models;

namespace BankProgram.Data
{
    class BankData
    {
        public List<Bank> Banks { get; set; }
        public List<Advisor> Advisors { get; set; }
        public List<Customer> Customers { get; set; }
        public List<BankAccount> BankAccounts { get; set; }

        private int nextBankId = 1;
        private int nextAdvisorId = 1;
        private int nextCustomerId = 1;
        private int nextAccountId = 1;

        public BankData()
        {
            var Nordea = new Bank(GetNextBankId(), "Nordea", new List<Advisor>());
        }
    }
}