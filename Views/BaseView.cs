namespace ShellBank.Views
{
    class BaseView
    {
        public string? GetUserInput() => Console.ReadLine();

        public string? GetUserKey() => Console.ReadKey().KeyChar.ToString();

        public void ExitOption(string label = "Exit")
        {
            Console.WriteLine($"0. {label}");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowExitMessage()
        {
            Console.WriteLine("Thank you for using ShellBank. Goodbye!");
        }
        
        public void ShowError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
        }
    }
}