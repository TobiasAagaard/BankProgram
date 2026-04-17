using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShellBank.Models
{
    class Account
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string AccountNumber { get; set; } = string.Empty;

        public AccountType Type { get; set; }

        [MaxLength(3)]
        public string Currency { get; set; } = "DKK";

        public bool IsActive { get; set; } = true;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public CustomerProfile? Customer { get; set; }
        public ICollection<AccountAccess> AccountAccesses { get; set; } = new List<AccountAccess>();
    }

    enum AccountType { Checking, Savings, Loan, Credit, Business, Student, ChildSavings }
}
