namespace ShellBank
{
    using Microsoft.Extensions.DependencyModel.Resolution;
    using ShellBank.Controllers;
    using ShellBank.Data;
    using ShellBank.Services;

    class Program
    {

        
        static void Main(string[] args)
        { 

            bool isDevMode = args.Contains("--dev");

            ShellBankContext ctx = new ShellBankContext();

            BankService bankService = new BankService(ctx);
            AuthService authService = new AuthService(ctx);

             NavigationController navigationController = new NavigationController(bankService);
            navigationController.ShowMainMenu();
        }
    }
}
