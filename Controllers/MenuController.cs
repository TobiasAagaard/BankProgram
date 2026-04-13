namespace BankProgram
{
    class MenuController
    {
        private BankCollectionController bankCollectionController = new BankCollectionController();

        public void ShowMenu()
        {
            Console.WriteLine("1. Create Bank");
            Console.WriteLine("2. List Banks");
            string? userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    bankCollectionController.CreateBank();
                    break;
                case "2":
                    List<Bank> banks = bankCollectionController.GetAllBanks();
                    for (int i = 0; i < banks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {banks[i].BankName}");
                    }
                    break;
        }
    }
    }
}