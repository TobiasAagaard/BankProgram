namespace ShellBank
{
    using ShellBank.Controllers;
    using ShellBank.Data;
    using ShellBank.Services;

    class Program
    {

        
        static void Main(string[] args)
        { 
            ShellBankContext ctx = new ShellBankContext();

            BankService bankService = new BankService(ctx);
            AuthService authService = new AuthService(ctx);

            MenuController menuController = new MenuController(bankService);
            menuController.ShowMainMenu();
        }
    }
}
