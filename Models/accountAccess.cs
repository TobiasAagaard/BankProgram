namespace ShellBank.Models
{
    class AccountAccess
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }

        public AccessLevel AccessLevel { get; set; }

        public Account? Account { get; set; }
        public CustomerProfile? Customer { get; set; }
    }

    enum AccessLevel { Owner, ReadOnly, ReadWrite, Advisor }
}
