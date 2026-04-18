namespace ShellBank.Views
{
    using Spectre.Console;

    class RoleSelctionMenu
    {
        public enum UserRole
        {
            Customer,
            Advisor,
        }

        public UserRole PromptRoleSelction()
        {
            Console.Clear();

            AnsiConsole.Write(
                new FigletText("ShellBank")
                    .Centered()
                    .Color(Color.Green));

            Console.WriteLine();

            string role = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Please select your [green]role[/]:")
                    .PageSize(20)
                    .AddChoices(Enum.GetNames(typeof(UserRole)))
            );

            return (UserRole)Enum.Parse(typeof(UserRole), role);
        }
    }
}