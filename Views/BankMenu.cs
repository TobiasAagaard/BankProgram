namespace BankProgram.Views
{
    class BankMenu : BaseView
    {
        public void BankMenuWelcome(string bankName)
        {
            Console.Clear();
            ShowMessage($"Welcome to {bankName}!");
        }
    }
}