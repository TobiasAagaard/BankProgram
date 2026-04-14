namespace BankProgram
{
    using BankProgram.Controllers;
    using BankProgram.Data;
    using BankProgram.Services;

    class Program
    {

        
        static void Main(string[] args)
        { 
            BankData data = new BankData();

            BankService bankService = new BankService(data);

            MenuController menuController = new MenuController(bankService);
            menuController.ShowMenu();
        }
    }
}
