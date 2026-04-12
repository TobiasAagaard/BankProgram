

namespace BankProgram
{
    class BanksManager
    {
        private List<Bank> banks = new();

        public BanksManager()
        {
            this.banks = new List<Bank>();
        }

        public string AddBank(string name, List<Customer> customers)
        {
            int bankId = banks.Count + 1;
            if (banks.Any(banks => banks.BankId == bankId))
            {
                throw new Exception("Bank already exists");
            }
            else
            {
                banks.Add(new Bank(bankId, name, customers));
                return "Bank created successfully";
            }
        }

        public string RemoveBank (int id, string name)
        {
            if (banks.Any(banks => banks.BankId == id && banks.BankName == name))
            {
                banks.RemoveAll(banks => banks.BankId == id && banks.BankName == name);
                return "Bank deleted successfully";
            }
            else
            {
                throw new Exception("Bank does not exist");
            }
        }

    }
}