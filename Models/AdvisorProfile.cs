using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShellBank.Models
{
    class AdvisorProfile
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [NotMapped]
        public string DisplayName => $"{FirstName} {LastName}";

        // Stored as a bool instead of a fragile string comparison
        public bool IsAdmin { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Bank? Bank { get; set; }
        public User? User { get; set; }
        public ICollection<CustomerProfile> Customers { get; set; } = [];
    }
}
