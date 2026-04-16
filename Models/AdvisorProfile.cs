using System.IO.Compression;

namespace ShellBank.Models
{
    class AdvisorProfile
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Role { get; set; } = "Advisor";
        public string CreatedAt { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public Bank? Bank { get; set; }
        public User? User { get; set; }
        public ICollection<CustomerProfile> Customers { get; set; } = new List<CustomerProfile>();

        public bool IsAdmin => Role == "Admin";
    }
}