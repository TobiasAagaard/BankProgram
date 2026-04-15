namespace ShellBank
{
    using ShellBank.Controllers;
    using ShellBank.Data;
    using ShellBank.Services;

    class Program
    {

        
        static void Main(string[] args)
        { 
            BankData data = new BankData();

            BankService bankService = new BankService(data);

            MenuController menuController = new MenuController(bankService);
            menuController.ShowMainMenu();
        }
    }
}
