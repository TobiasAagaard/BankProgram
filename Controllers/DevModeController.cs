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