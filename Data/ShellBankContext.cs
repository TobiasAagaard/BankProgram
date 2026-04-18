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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(u => u.Email).IsUnique();
                entity.HasIndex(u => u.CPR).IsUnique();
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(a => a.AccountNumber).IsUnique();
                entity.Property(a => a.Balance).HasPrecision(18, 2);
            });

            modelBuilder.Entity<CustomerProfile>(entity =>
            {
                entity.HasOne(cp => cp.Guardian)
                    .WithMany(g => g.Dependents)
                    .HasForeignKey(cp => cp.GuardianCustomerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<AccountAccess>(entity =>
            {
                entity.HasOne(aa => aa.Customer)
                    .WithMany(c => c.AccountAccesses)
                    .HasForeignKey(aa => aa.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Bank>().HasData(
                new Bank
                {
                    Id = 1,
                    Name = "Tech College Bank",
                    RegistrationNumber = "2293"
                }
            );
        }
    }
}
