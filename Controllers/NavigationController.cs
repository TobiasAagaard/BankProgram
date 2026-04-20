namespace ShellBank.Controllers
{
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Views;

    class NavigationController 
    {
        
        private BankService bankService;

        public NavigationController(BankService bankService)
        {
            this.bankService = bankService;
        }

        public void ShowMainMenu()
        {
            bool running = true;
            while (running)
            {
                RoleSelctionMenu role = new RoleSelctionMenu();
                role.PromptRoleSelction();
                BankSelectionMenu bankMenu = new BankSelectionMenu();
                Bank? selectedBank = bankMenu.PromptBankSelection(bankService.GetAllBanks());
            }
        }
    }
}