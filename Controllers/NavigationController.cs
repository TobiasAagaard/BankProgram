namespace ShellBank.Controllers
{
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Views;

    class NavigationController 
    {
        
        private BankService bankService;
        private AuthService authService;

        private readonly RoleSelctionMenu roleMenu = new RoleSelctionMenu();
        private readonly CustomerLoginMenu customerLoginMenu = new CustomerLoginMenu();

        public NavigationController(BankService bankService, AuthService authService)
        {
            this.bankService = bankService;
            this.authService = authService;
        }

        public void ShowMainMenu()
        {
            bool running = true;
            while (running)
            {
                RoleSelctionMenu.UserRole role = roleMenu.PromptRoleSelction();
                if (role == RoleSelctionMenu.UserRole.Customer)
                {
                    HandleCustomerFlow();
                }
                else if (role == RoleSelctionMenu.UserRole.Advisor)
                {
                    HandleAdvisorFlow();
                }
            }
        }

        public void HandleCustomerFlow()
        {
            List<Bank> Banks = bankService.GetAllBanks();
            Bank? bank = new BankSelectionMenu().PromptBankSelection(Banks);
            if (bank == null) return;

            while (true)
            {
                string? username, password;
                (username, password) = customerLoginMenu.PromptCustomerLogin(bank);
                if (username == null || password == null) return;

                User? user = authService.AuthenticateCustomer(bank.Id, username, password);
                if (user == null)
                {
                    throw new Exception("Invalid username or password. Please try again.");
                }

            }


        }

        public void HandleAdvisorFlow()
        {
            //Advisorflow
        }
    }
}