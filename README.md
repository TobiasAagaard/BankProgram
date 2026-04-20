# ShellBank
A CLI bank application built in C# (.NET 10) that simulates core banking operations. Designed as a OOP exercise covering encapsulation, class design, and MVC architecture, with a SQLite-backed persistent data layer via Entity Framework Core.

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

## Dev-Mode
To run the application in dev mode use the following command:
```dotnet run -- --dev
```
This feature is intended for the first-time setup of the application. It allows you to quickly create a bank and users (either as customers or advisors) by seeding initial data into the database.
