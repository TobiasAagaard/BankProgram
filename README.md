# ShellBank
A CLI bank application built in C# (.NET 10) that simulates core banking operations. Designed as a hands-on OOP exercise covering encapsulation, class design, and MVC architecture, with a SQLite-backed persistent data layer via Entity Framework Core.

## Features
- Create and navigate between multiple banks
- Manage customers and advisors linked to banks
- Multiple account types: Checking, Savings, Loan, Credit, Business, Student, ChildSavings
- Account access control (multiple customers per account)
- Guardian/dependent customer relationships
- Persistent data storage with SQLite + EF Core

## Tech Stack
- .NET 10
- Entity Framework Core 10 + SQLite
- Spectre.Console 0.55

## Getting Started
1. Clone the repo
2. Restore dependencies and apply migrations:
   ```
   dotnet restore
   dotnet ef database update
   ```
3. Build and run:
   ```
   dotnet build
   dotnet run
   ```

