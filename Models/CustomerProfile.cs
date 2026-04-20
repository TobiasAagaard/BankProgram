using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShellBank.Models
{
    class CustomerProfile
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }
        public int AdvisorProfileId { get; set; }
        public int? GuardianCustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [NotMapped]
        public string DisplayName => $"{FirstName} {LastName}";

        public DateTime? DateOfBirth { get; set; }

        [StringLength(10, MinimumLength = 10)]
        public string? Username { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [NotMapped]
        public bool IsMinor => GuardianCustomerId.HasValue;

        public Bank? Bank { get; set; }
        public User? User { get; set; }
        public AdvisorProfile? AdvisorProfile { get; set; }
        public CustomerProfile? Guardian { get; set; }
        public ICollection<CustomerProfile> Dependents { get; set; } = [];
        public ICollection<Account> Accounts { get; set; } = [];
        public ICollection<AccountAccess> AccountAccesses { get; set; } = [];
    }
}
