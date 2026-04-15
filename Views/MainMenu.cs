namespace ShellBank.Views
{
    class MainMenu : BaseView
    {
        public void MainMenuWelcome()
        {
            Console.Clear();
            ShowMessage("Welcome to ShellBank!");
            ShowMessage("Please select a bank:");
        }

        public void ShowBankList(List<string> bankNames)
        {
            for (int i = 0; i < bankNames.Count; i++)
            {
                ShowMessage($"{i + 1}. {bankNames[i]}");
            }
        }
    }
}