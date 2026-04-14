namespace BankProgram.Controllers
{
    using BankProgram.Views;

    class MenuController
    {
        private Menu view = new Menu();
        private BankCollectionController bankCollectionController = new BankCollectionController();

        public void ShowMenu()
        {
            view.ShowBanks(bankCollectionController.GetAllBanks());
            string? userInput = view.GetUserInput();
        }
        
       
    }
}