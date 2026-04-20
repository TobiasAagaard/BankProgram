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

        public Bank CreateBank(string name, string? registrationNumber = null)
        {
            if (registrationNumber == null)
            {
                registrationNumber = GenerateUniqueRegistrationNumber();
            }
            Bank newBank = new Bank { Name = name, RegistrationNumber = registrationNumber, CreatedAt = DateTime.UtcNow };
            data.Banks.Add(newBank);
            data.SaveChanges();
            return newBank;
        }

        private string GenerateUniqueRegistrationNumber()
        {
            int minNumber = 1000; 
            int maxNumber = 9999;
            string registraionNumber;
            Random random = new Random(); 

            do 
            {
                registraionNumber = random.Next(minNumber, maxNumber + 1).ToString(); 
            } while (data.Banks.Any(b => b.RegistrationNumber == registraionNumber));
            return registraionNumber;

        }
       
    }
}