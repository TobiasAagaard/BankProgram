namespace ShellBank.Views
{
    using Spectre.Console;
    using ShellBank.Models;
    using ShellBank.Utils;

    class CustomerLoginMenu
    {
        public (string?, string?) PromptCustomerLogin(Bank bank)
        {
            Console.Clear();

            AnsiConsole.Write(new Rule($"[steelblue1]{bank.Name}[/]").RuleStyle("grey").Centered());
            AnsiConsole.WriteLine();

            AnsiConsole.MarkupLine("[bold]Customer Login[/]");
            Console.WriteLine();

            AnsiConsole.Markup("Enter your [green]username[/]: ");
            string? username = Console.ReadLine();
            AnsiConsole.Markup("Enter your [green]password[/]: ");
            string? password = PasswordMask.ReadPassword();
            return (username, password);
        }
    }
}