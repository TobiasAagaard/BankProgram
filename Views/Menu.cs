namespace BankProgram.Views
{
    using BankProgram.Models;
    class Menu
    {
        public void ShowBanks(List<Bank> banks)
        {
            for (int i = 0; i < banks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {banks[i].BankName}");
            }
        }
        public string? GetUserInput() => Console.ReadLine();
    }
}