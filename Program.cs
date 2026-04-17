namespace ShellBank
{
    using ShellBank.Controllers;
    using ShellBank.Data;
    using ShellBank.Services;

    class Program
    {

        
        static void Main(string[] args)
        { 
            ShellBankContext shellBankContext = new ShellBankContext();

            BankService bankService = new BankService(shellBankContext);

            MenuController menuController = new MenuController(bankService);
            menuController.ShowMainMenu();
        }
    }
}
