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
         [MaxLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime? DateOfBirth { get; set; }

        [NotMapped]
        public bool IsMinor => GuardianCustomerId.HasValue;

        public Bank? Bank { get; set; }
        public User? User { get; set; }
        public AdvisorProfile? AdvisorProfile { get; set; }
        public CustomerProfile? Guardian { get; set; }
        public ICollection<CustomerProfile> Dependents { get; set; } = new List<CustomerProfile>();
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        public ICollection<AccountAccess> AccountAccesses { get; set; } = new List<AccountAccess>();
    }
}
