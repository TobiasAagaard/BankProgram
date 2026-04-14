namespace BankProgram
{
    using BankProgram.Controllers;

    class Program
    {

        
        static void Main(string[] args)
        { 
            MenuController menuController = new MenuController();
            menuController.ShowMenu();
        }
    }
}
