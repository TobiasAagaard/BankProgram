namespace ShellBank.Controllers
{
    using System.Formats.Asn1;
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Views;

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
                view.ShowBankList(bankService.GetAllBanks().Select(b => b.Name).ToList());
                view.ExitOption();
                string? userInput = view.GetUserInput();

                if (userInput == "0")
                {
                    running = false;
                    view.ShowExitMessage();
                    break;
                }
                else if (int.TryParse(userInput, out int bankIndex))
                {
                    Bank? selectedBank = bankService.GetAllBanks().ElementAtOrDefault(bankIndex - 1);

                   
                    if (selectedBank != null)
                    {
                        BankController bankController = new BankController(selectedBank);
                        bankController.ShowBankMenu();
                    }
                    else
                    {
                        view.ShowError("Invalid bank selection. Please try again.");
                        view.GetUserKey();
                    }

                }
            }
        }
    }
}