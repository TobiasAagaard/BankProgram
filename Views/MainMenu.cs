namespace BankProgram.Views
{
    using BankProgram.Models;
    class MainMenu
    {
        public void ShowBanks(List<Bank> banks)
        {
            for (int i = 0; i < banks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {banks[i].BankName}");
            }
        }
        public string? GetUserInput() => Console.ReadLine();

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowOptions(List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }
    }
}