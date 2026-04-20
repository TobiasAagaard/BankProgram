namespace ShellBank.Views
{
    using ShellBank.Models;
    using ShellBank.Services;
    using Spectre.Console;

    class DevModeView
    {
        public enum DevModeOption
        {
            CreateBank,
            CreateCustomer,
            CreateAdvisor
        }

        public DevModeOption PromptDevModeOption()
        {
            Console.Clear();
            AnsiConsole.Write(new Rule("[steelblue1]Developer Mode[/]").RuleStyle("grey").Centered());
            Console.WriteLine();

            string option = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select an option:")
                    .PageSize(10)
                    .AddChoices(Enum.GetNames(typeof(DevModeOption)))
            );

            return (DevModeOption)Enum.Parse(typeof(DevModeOption), option);
        }
    }
}