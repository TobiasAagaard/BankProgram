namespace ShellBank.Views
{
    using Spectre.Console;
    
    class CreateCustomerView
    {
        public (int, string, string, string, string, string, string, DateTime?) PromptCustomerDetails()
        {
            int bankId = AnsiConsole.Ask<int>("Enter the [green]bank ID[/] of the bank the customer will be associated with:");
            string email = AnsiConsole.Ask<string>("Enter the [green]email[/] of the new customer:");
            string password = AnsiConsole.Ask<string>("Enter the [green]password[/] for the new customer:");
            string verifiedPassword = AnsiConsole.Ask<string>("Verify the [green]password[/] for the new customer:");
            string firstName = AnsiConsole.Ask<string>("Enter the [green]first name[/] of the new customer:");
            string lastName = AnsiConsole.Ask<string>("Enter the [green]last name[/] of the new customer:");
            string phoneNumber = AnsiConsole.Ask<string>("Enter the [green]phone number[/] of the new customer:");
            DateTime? dateOfBirth = AnsiConsole.Ask<DateTime?>("Enter the [green]date of birth[/] of the new customer:");

            return (bankId, email, password, verifiedPassword, firstName, lastName, phoneNumber, dateOfBirth);
        }
    }
}