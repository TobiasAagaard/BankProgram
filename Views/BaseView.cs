namespace BankProgram.Views
{
    class BaseView
    {
        public string? GetUserInput() => Console.ReadLine();

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}