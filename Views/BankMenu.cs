namespace BankProgram.Views
{
    using BankProgram.Models;
    using BankProgram.Controllers;

    class BankMenu
    {
        public void ShowBankMenu(Bank bank)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {bank.BankName}!");
            Console.WriteLine("Here are our advisors:");
        }
        public string? GetUserInput() => Console.ReadLine();
    }
}