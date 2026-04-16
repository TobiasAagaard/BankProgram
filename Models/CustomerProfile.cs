using System.Runtime.InteropServices;

namespace ShellBank.Models
{
    class CustomerProfile
    {
       public int Id { get; set; }
       public int BankId { get; set; }
       public int UserId { get; set; }
       public int AdvisorProfileId { get; set; }
       public int? GuardianCustomerId { get; set; }
       public string FirstName { get; set; } = string.Empty;
       public string LastName { get; set; } = string.Empty;
       public string? Email { get; set; }
       public string Role { get; set; } = "Customer";
       public string? DateOfBirth { get; set; }
       public string? CPR { get; set; }
       public string CreatedAt { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


       public Bank? Bank { get; set; }
       public User? User { get; set; }
       public AdvisorProfile? AdvisorProfile { get; set; }
       public CustomerProfile? Guardian { get; set; }
       public ICollection<CustomerProfile> Dependents { get; set; } = new List<CustomerProfile>();


       public bool IsMinor => GuardianCustomerId.HasValue;
    }
}