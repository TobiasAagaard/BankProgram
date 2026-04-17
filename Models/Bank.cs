using System.ComponentModel.DataAnnotations;

namespace ShellBank.Models
{
    class Bank
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(4, MinimumLength = 4)]
        public string? RegistrationNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<User> Users { get; set; } = [];
        public ICollection<CustomerProfile> CustomerProfiles { get; set; } = [];
        public ICollection<AdvisorProfile> AdvisorProfiles { get; set; } = [];
    }
}
