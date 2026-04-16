namespace ShellBank.Data
{
    using Microsoft.EntityFrameworkCore;
    using ShellBank.Models;

    class ShellBankContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AdvisorProfile> Advisors { get; set; }
        public DbSet<CustomerProfile> Customers { get; set; }
        public DbSet<Account> BankAccounts { get; set; }
        public DbSet<AccountAccess> AccountAccesses { get; set; }

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