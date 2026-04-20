namespace ShellBank.Controllers
{
    using System.Text.RegularExpressions;
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Views;
    using Spectre.Console;

    class DevModeController
    {
        private BankService bankService;

        public DevModeController(BankService bankService)
        {
            this.bankService = bankService;
        }

        public void ShowDevModeMenu()
        {

            DevModeView view = new DevModeView();
            DevModeView.DevModeOption option = view.PromptDevModeOption();

            switch (option)
            {
                case DevModeView.DevModeOption.CreateBank:
                    string bankName = AnsiConsole.Ask<string>("Enter bank name:");
                    string registrationNumber = AnsiConsole.Ask<string>("Enter registration number (leave blank for auto-generation)", "");
                    if (Regex.IsMatch(registrationNumber, "[A-Za-z]"))
                    {
                        AnsiConsole.MarkupLine("[red]Registration number must be numeric. Auto-generating registration number.[/]");
                        break;
                    }
                    if (!string.IsNullOrEmpty(registrationNumber) && (Convert.ToInt32(registrationNumber) < 1000 || Convert.ToInt32(registrationNumber) > 9999))
                    {
                        AnsiConsole.MarkupLine("[red]Registration number must be a 4-digit number. Auto-generating registration number.[/]");
                        registrationNumber = "";
                    }
                    
                    Bank newBank = bankService.CreateBank(bankName, registrationNumber);
                    AnsiConsole.MarkupLine($"[green]Bank '{newBank.Name}' created successfully![/]");
                    AnsiConsole.MarkupLine($"[green]Registration Number: {newBank.RegistrationNumber}[/]");
                    break;
                case DevModeView.DevModeOption.CreateCustomer:
                    AnsiConsole.MarkupLine("[yellow]Customer creation not implemented yet.[/]");
                    break;
                case DevModeView.DevModeOption.CreateAdvisor:
                    AnsiConsole.MarkupLine("[yellow]Advisor creation not implemented yet.[/]");
                    break;
            }
        }
    }
}