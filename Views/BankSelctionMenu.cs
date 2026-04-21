namespace ShellBank.Views
{
    using Spectre.Console;
    using ShellBank.Models;

    class BankSelectionMenu
    {
        public Bank? PromptBankSelection(List<Bank> banks)
        {
            Console.Clear();

            AnsiConsole.Write(new Rule("[steelblue1]Select Your Bank[/]").RuleStyle("grey").Centered());
            AnsiConsole.WriteLine();

            if (banks.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]No banks are currently registered.[/]");
                AnsiConsole.MarkupLine("[grey]Press any key to go back...[/]");
                Console.ReadKey(intercept: true);
                return null;
            }

            List<string> choices = banks.Select(b => b.Name).ToList();
            choices.Add("[grey]← Go back[/]");

            AnsiConsole.Write(new Padder(
                new Markup("[grey]If you aren't yet a customer of a bank, contact your advisor for assistance.[/]"),
                new Padding(0, 0, 0, 1)
            ));

            string selected = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold]Choose a bank:[/]")
                    .PageSize(10)
                    .AddChoices(choices)
            );

            if (selected == "[grey]← Go back[/]")
                return null;

            Console.ReadKey(intercept: true);

            return banks.FirstOrDefault(b => b.Name == selected);
        }
    }
}
