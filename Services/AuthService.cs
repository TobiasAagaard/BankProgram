namespace ShellBank.Services
{
    using Microsoft.EntityFrameworkCore;
    using BC = BCrypt.Net.BCrypt;
    using ShellBank.Models;
    using ShellBank.Data;
    using ShellBank.Utils;
    class AuthService
{
    private readonly ShellBankContext data;
    private const string DummyHash = "$2a$12$abcdefghijklmnopqrstuu7hB3VK6yYjHbGuQJKl4fZ8gQ5xXx6Oa";

    public AuthService(ShellBankContext data)
    {
        this.data = data;
    }
    public (bool Ok, string? Error) RegisterAdvisor(string email, string password, int bankId, bool isAdmin, string firstName, string lastName, string displayName)
        {
            (bool ok, string? error) check = PasswordValidation.ValidatePassword(password);
            if (!check.ok)
            {
                return (false, check.error);
            }
            if (data.Users.Any(u => u.Email == email))
            {
                return (false, "This Advisor already exists.");
            }

            User user = new User
            {
                Email = email,
                PasswordHash = BC.HashPassword(password),
                UserRole = Role.Advisor,
                BankId = bankId,
            };
            AdvisorProfile advisorProfile = new AdvisorProfile
            {
                FirstName = firstName,
                LastName = lastName,
                IsAdmin = isAdmin,
                User = user
            };
            data.Users.Add(user);
            data.Advisors.Add(advisorProfile);
            data.SaveChanges();
            return (true, null);
        }

    public (bool Ok, string? Error) RegisterCustomer(string username, string password, int bankId, string firstName, string lastName)
        {

            (bool ok, string ? error) check = PasswordValidation.ValidatePassword(password);
            if (!check.ok)
            {
                return (false, check.error);
            }
            if (data.Users.Any(u => u.Username == username))
            {
                return (false, "This user already exists. Contact your bank for assistance.");
            }

            User user = new User
            {
                Username = username,
                PasswordHash = BC.HashPassword(password),
                UserRole = Role.Customer,
                BankId = bankId,
            };
            CustomerProfile customerProfile = new CustomerProfile
            {
                FirstName = firstName,
                LastName = lastName,
                User = user
            };
            
            data.Users.Add(user);
            data.Customers.Add(customerProfile);
            data.SaveChanges();
            return (true, null);
        }
    public User? AuthenticateAdvisor(string email, string password)
    {
        User? user = data.Users
            .FirstOrDefault(u => u.Email == email &&
                                 u.UserRole == Role.Advisor &&
                                 u.IsActive &&
                                 !u.IsDeleted);

        if (user == null)
        {
            BC.Verify(password, DummyHash);
            return null;
        }

        bool isPasswordValid = BC.Verify(password, user.PasswordHash);
        if (!isPasswordValid)
        {
            return null;
        }

        return user;
    }

    public User? AuthenticateCustomer(string username, string password)
    {
        User? user = data.Users
            .FirstOrDefault(u => u.Username == username &&
                                 u.UserRole == Role.Customer &&
                                 u.IsActive &&
                                 !u.IsDeleted);

        if (user == null)
        {
            BC.Verify(password, DummyHash);
            return null;
        }

        bool isPasswordValid = BC.Verify(password, user.PasswordHash);
        if (!isPasswordValid)
        {
            return null;
        }

        return user;
    }

}
}