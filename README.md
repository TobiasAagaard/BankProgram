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

