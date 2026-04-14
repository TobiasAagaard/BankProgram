using System.Security.Cryptography.X509Certificates;

namespace BankProgram
{
    class Program
    {

        
        static void Main(string[] args)
        { 
            MenuController menuController = new MenuController();
            menuController.ShowMenu();
        }
    }
}
