using System.ComponentModel.DataAnnotations;
namespace ShellBank.Models
{
    class User
    {
        public int Id { get; set; }
        public int BankId { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [MaxLength(72)]
        public string Username { get; set; } = string.Empty;

        [MaxLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(72)]
        public string PasswordHash { get; set; } = string.Empty;

        public Role UserRole { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Bank? Bank { get; set; }
        public ICollection<CustomerProfile> CustomerProfiles { get; set; } = new List<CustomerProfile>();
        public ICollection<AdvisorProfile> AdvisorProfiles { get; set; } = new List<AdvisorProfile>();
    }

    public enum Role { Customer, Advisor }
}
