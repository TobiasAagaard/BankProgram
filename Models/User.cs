using System.Runtime.InteropServices.Marshalling;

namespace ShellBank.Models
{
    class User
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public string? Email { get; set; } 
        public int CPR { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        public Role UserRole { get; set; }
        public string IsActive { get; set; } = "true";
        public string IsDeleted { get; set; } = "false";
        public string CreatedAt { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


        public Bank? Bank { get; set; }       
        public ICollection<CustomerProfile> CustomerProfiles { get; set; } = new List<CustomerProfile>();
        public ICollection<AdvisorProfile> AdvisorProfiles { get; set; } = new List<AdvisorProfile>();
    }
    enum Role { Customer, Advisor}
}

