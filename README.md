# ShellBank
A simple bank CLI application built in C# that simulates core banking operations such as managing banks, customers, and accounts.
Designed as a hands-on exercise to practice OOP principles like encapsulation and class design, following an MVC-style architecture.

## Features
- Select and navigate between multiple banks
- Banks contain customers and advisors
- Customers hold one or more bank accounts with individual balances

## Project Structure
```
ShellBank/
├── Controllers/
│   ├── MenuController.cs   # Main menu navigation
│   └── BankController.cs   # Bank-level menu navigation
├── Models/
│   ├── Bank.cs             # Bank entity
│   ├── BankAccount.cs      # Account entity with balance
│   ├── Customer.cs         # Customer entity with linked accounts
│   └── Advisor.cs          # Advisor entity
├── Views/
│   ├── BaseView.cs         # Shared view helpers
│   ├── MainMenu.cs         # Main menu UI
│   └── BankMenu.cs         # Bank menu UI
├── Services/
│   └── BankService.cs      # Business logic for bank operations
├── Data/
│   └── BankData.cs         # In-memory seed data
└── Program.cs              # Entry point
```

## How To Run
1. Clone the repo
2. Open the project in your C# code editor like Visual Studio or VS Code
3. Build and run the application with the commands:
   ```
   dotnet build
   dotnet run
   ```
