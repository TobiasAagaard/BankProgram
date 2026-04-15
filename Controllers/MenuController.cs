namespace BankProgram.Controllers
{
    using BankProgram.Models;
    using BankProgram.Services;
    using BankProgram.Views;

    class MenuController : BankMenu
    {
        private MainMenu view = new MainMenu();
        private BankService bankService;

        public MenuController(BankService bankService)
        {
            this.bankService = bankService;
        }

        public void ShowMainMenu()
        {
            bool running = true;
            while (running)
            {
                view.MainMenuWelcome();
                view.ShowBankList(bankService.GetBanks().Select(b => b.BankName).ToList());
                string? userInput = view.GetUserInput();
                if (int.TryParse(userInput, out int bankIndex))
                {
                    Bank? selectedBank = bankService.GetBankByIndex(bankIndex - 1);
                    if (selectedBank != null)
                    {
                        BankController bankController = new BankController(selectedBank);
                        bankController.ShowBankMenu();
                    }
                    else
                    {
                        view.ShowError("Invalid bank selection. Please try again.");
                    }

                }
            }
        }
    }
}