namespace ShellBank.Models
{
    class Account
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public AccountType Type { get; set; }
        public string Currency { get; set; } = "USD";
        public bool IsActive { get; set; } = true;
        public decimal Balance { get; set; }
        public string CreatedAt { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public CustomerProfile? Customer { get; set; }
        public ICollection<AccountAccess> AccountAccesses { get; set; } = new List<AccountAccess>();

    }
    enum AccountType { Checking, Savings, Loan, Credit, Bussiness, Student, ChildSavings }
}