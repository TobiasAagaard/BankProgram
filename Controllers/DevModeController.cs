namespace ShellBank.Controllers
{
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Views;

    class DevModeController
    {
        private BankService bankService;

        public DevModeController(BankService bankService)
        {
            this.bankService = bankService;
        }
        
    }
}