namespace BankProgram.Controllers
{
    using BankProgram.Models;
    using BankProgram.Views;

    class MenuController
    {
        private MainMenu view = new MainMenu();
    

        public void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                List<Bank> banks = bankCollectionController.GetAllBanks();
                view.ShowBanks(banks);
                Console.WriteLine("0. Exit");
                Console.Write("Select your bank: ");
                string? userInput = view.GetUserInput();

                if (userInput == "0")
                {
                    running = false;
                    Console.WriteLine("Exiting the program.");
                } else if (int.TryParse(userInput, out int choice) && choice > 0 && choice <= banks.Count)
                {
                    Bank selectedBank = banks[choice - 1];
                    BankController bankController = new BankController(selectedBank);
                    bankController.ShowBankMenu();
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
                }
            }
        }
        
       
    }