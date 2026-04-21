namespace ShellBank.Views
{
    using Spectre.Console;

    class CreateBankView
    {
        public (string, string) PromptBankName()
        {
            Console.Clear();
            AnsiConsole.Write(new Rule("[steelblue1]Create a New Bank[/]"));
            string bankName = AnsiConsole.Ask<string>("Enter the [green]name[/] of the new bank:");
            string registrationNumber = AnsiConsole.Ask<string>("Enter registration number (leave blank for auto-generation)", "");
            return (bankName, registrationNumber);
            
        }
    }
}