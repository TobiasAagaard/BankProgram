namespace BankProgram
{
    class Menu
    {
        private MenuController menuController = new MenuController();

        public void DisplauyMenu()
        {
            menuController.ShowMenu();
        }
    }
}