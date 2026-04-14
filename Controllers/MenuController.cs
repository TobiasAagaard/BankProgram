namespace BankProgram.Controllers
{
    using BankProgram.Services;
    using BankProgram.Views;

    class MenuController
    {
        private MainMenu view = new MainMenu();
        private BankService bankService;

        public MenuController(BankService bankService)
        {
            this.bankService = bankService;
        }

        public void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                var banks = bankService.GetBanks();
                var bankNames = banks.Select(b => b.BankName).ToList();

                view.ShowOptions(bankNames);
                view.ShowMessage("0. Exit");
                view.ShowMessage("Select your bank: ");

                string? input = view.GetUserInput();

                if (input == "0")
                {
                    running = false;
                }
                else if (int.TryParse(input, out int choice))
                {
                    var bank = bankService.GetBankByIndex(choice - 1);
                    if (bank != null)
                    {
                        BankController bankController = new BankController(bank);
                        bankController.ShowBankMenu();
                    }
                    else
                    {
                        view.ShowMessage("Invalid selection. Please try again.");
                    }
                }
            }
        }
    }
}