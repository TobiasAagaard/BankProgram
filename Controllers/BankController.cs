namespace ShellBank.Controllers
{
    using ShellBank.Models;
    using ShellBank.Views;

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
                view.BankMenuWelcome(bank.Name);
                view.ExitOption("Return to main menu");
                string? userInput = view.GetUserInput();
                if (userInput == "0")
                {
                    running = false;
                }
            }
        }
    }
}