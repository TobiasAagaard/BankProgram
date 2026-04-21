# ShellBank

A CLI banking application built in **C# (.NET 10)** that simulates core banking operations from a terminal. Designed as an OOP exercise covering encapsulation, class design, and MVC architecture, with a SQLite-backed persistent data layer via Entity Framework Core.

---

## Features

- **Multi-role access** — separate flows for Customers and Advisors
- **Bank management** — create and select banks with unique 4-digit registration numbers
- **User authentication** — BCrypt-hashed passwords with timing-safe login for both customers and advisors
- **Account system** — supports multiple account types: Checking, Savings, Loan, Credit, Business, Student, and Child Savings
- **Dev mode** — seed initial banks and users for quick first-time setup

---

## Tech Stack

| Technology | Version |
|---|---|
| .NET | 10 |
| Entity Framework Core + SQLite | 10.0.6 |
| Spectre.Console For TUI | 0.55.1 |

---

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [EF Core CLI tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet):
  ```bash
  dotnet tool install --global dotnet-ef
  ```

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/TobiasAagaard/ShellBank
   cd ShellBank
   ```

2. **Restore dependencies and apply migrations**
   ```bash
   dotnet restore
   dotnet ef database update
   ```
   This creates the SQLite database at `database/ShellBank.db` and seeds an initial bank (`Tech College Bank`, reg. `2293`).
   > **Note:** Note: To inspect the SQLite database, you can use software like DataGrip or DB Browser for SQLite.
4. **Build and run**
   ```bash
   dotnet build
   dotnet run
   ```

---

## Dev Mode

Run the application in dev mode for first-time setup and data seeding:

```bash
dotnet run -- --dev
```

Dev mode provides a quick-setup menu with the following options:

| Option | Description |
|---|---|
| `CreateBank` | Create a new bank with a custom or auto-generated 4-digit registration number |
| `CreateCustomer` | *(Coming soon)* Create a customer account |
| `CreateAdvisor` | *(Coming soon)* Create an advisor account |

