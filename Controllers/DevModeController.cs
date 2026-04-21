namespace ShellBank.Controllers
{
    using System.Text.RegularExpressions;
    using ShellBank.Models;
    using ShellBank.Services;
    using ShellBank.Utils;
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
                    CreateCustomerView createCustomerView = new CreateCustomerView();
                    (int bankId, string email, string password, string verifiedPassword, string firstName, string lastName, string phoneNumber, DateTime? dateOfBirth) = createCustomerView.PromptCustomerDetails();
                    while (password != verifiedPassword || !PasswordValidation.ValidatePassword(password).Ok)
                    {
                        if (password != verifiedPassword)
                        {
                            AnsiConsole.MarkupLine("[red]Passwords do not match. Please try again.[/]");
                        }
                        else if (!PasswordValidation.ValidatePassword(password).Ok)
                        {
                            AnsiConsole.MarkupLine("[red]The password must be at least 8 characters long and contain a mix of uppercase, lowercase, numbers, and special characters. Please try again.[/]");
                        }
                    }
                    AuthService authService = new AuthService(new Data.ShellBankContext());
                    var result = authService.RegisterCustomer(email, password, bankId, firstName, lastName, phoneNumber, dateOfBirth);
                    if (result.Ok)
                    {
                        AnsiConsole.MarkupLine($"[green]Customer {firstName} {lastName} was created successfully![/]");
                    }
                    else
                    {
                        AnsiConsole.MarkupLine($"[red]Failed to create customer: {result.Error}[/]");
                    }
                    break;

                case DevModeView.DevModeOption.CreateAdvisor:
                    AnsiConsole.MarkupLine("[yellow]Advisor creation not implemented yet.[/]");
                    break;
            }
        }
    }
}