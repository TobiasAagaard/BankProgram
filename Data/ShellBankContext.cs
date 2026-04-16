namespace ShellBank.Data
{
    using Microsoft.EntityFrameworkCore;
    using ShellBank.Models;

    class ShellBankContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        private readonly string _dbPath;

        public ShellBankContext()
        {
            _dbPath = Path.Combine(AppContext.BaseDirectory, "database", "ShellBank.db");
            Directory.CreateDirectory(Path.GetDirectoryName(_dbPath)!);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_dbPath}");
        }
       
    }
}