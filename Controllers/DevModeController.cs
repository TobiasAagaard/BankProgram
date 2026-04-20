namespace ShellBank.Controllers
{
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
                    string registrationNumber = AnsiConsole.Ask<string>("Enter registration number:");
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