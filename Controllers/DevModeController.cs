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
                    

                case DevModeView.DevModeOption.CreateAdvisor:
                    AnsiConsole.MarkupLine("[yellow]Advisor creation not implemented yet.[/]");
                    break;
            }
        }
    }
}