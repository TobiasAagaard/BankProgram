namespace BankProgram.Controllers
{
    using BankProgram.Models;
    using BankProgram.Views;

    class BankController
    {
        private Bank bank;
        private BankMenu view = new BankMenu();

        public BankController(Bank bank)
        {
            this.bank = bank;
        }

        public void ShowBankMenu()
        {
            bool running = true;
            while (running)
            {
                view.BankMenuWelcome(bank.BankName);
                string? userInput = view.GetUserInput();
                
            }
        }
    }
}