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
                    CreateBankView createBankView = new CreateBankView();
                    (string bankName, string registrationNumber) = createBankView.PromptBankName();
                    if (registrationNumber != "" && !Regex.IsMatch(registrationNumber, @"^\d{4}$"))
                    {
                        AnsiConsole.MarkupLine("[red]Invalid registration number. It must be a 4-digit number.[/]");
                        return;
                    }
                    Bank newBank = bankService.CreateBank(bankName, registrationNumber);
                    AnsiConsole.MarkupLine($"[green]{newBank.Name} was created successfully with registration number {newBank.RegistrationNumber}![/]");
                    break;
                case DevModeView.DevModeOption.CreateCustomer:
                    string email = AnsiConsole.Ask<string>("Enter customer email:");
                    string password = AnsiConsole.Ask<string>("Enter customer password:");
                    string verifiedPassword = AnsiConsole.Ask<string>("Verify customer password:");
                    while (password != verifiedPassword)
                    {
                        AnsiConsole.MarkupLine("[red]Passwords do not match. Please try again.[/]");
                        password = AnsiConsole.Ask<string>("Enter customer password:");
                        verifiedPassword = AnsiConsole.Ask<string>("Verify customer password:");
                    } 
                    string firstName = AnsiConsole.Ask<string>("Enter customer first name:");
                    string lastName = AnsiConsole.Ask<string>("Enter customer last name:");
                    DateTime? dateOfBirth = AnsiConsole.Ask<DateTime?>("Enter customer date of birth:");
                    int bankId = AnsiConsole.Ask<int>("Enter bank ID for the customer:");
                    AuthService authService = new AuthService(new Data.ShellBankContext());
                    var result = authService.RegisterCustomer(email, password, bankId, firstName, lastName, dateOfBirth);
                    if (result.Ok)                    {
                        AnsiConsole.MarkupLine($"[green]Customer '{firstName} {lastName}' created successfully![/]");
                    }
                    else                    {
                        AnsiConsole.MarkupLine($"[red]Error creating customer: {result.Error}[/]");
                    }
                    break;

                case DevModeView.DevModeOption.CreateAdvisor:
                    AnsiConsole.MarkupLine("[yellow]Advisor creation not implemented yet.[/]");
                    break;
            }
        }
    }
}