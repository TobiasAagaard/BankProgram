namespace ShellBank.Models
{
    class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<CustomerProfile> CustomerProfiles { get; set; } = new List<CustomerProfile>();
        public ICollection<AdvisorProfile> AdvisorProfiles { get; set; } = new List<AdvisorProfile>();

    }
}