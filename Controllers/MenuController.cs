namespace ShellBank.Controllers
{
    using System.Formats.Asn1;
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Views;

    class MenuController 
    {
        
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
                var role = new RoleSelctionMenu();
                role.PromptRoleSelction();
                Console.ReadLine();
            }
        }
    }
}