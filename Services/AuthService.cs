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
    public (bool Ok, string? Error) RegisterAdvisor(string email, string password, int bankId)
        {
            (bool ok, string? error) check = PasswordValidation.ValidatePassword(password);
            if (!check.ok)
            {
                return (false, check.error);
            }
            if (data.Users.Any(u => u.Email == email))
            {
                return (false, "Email is already in use.");
            }

            User user = new User
            {
                Email = email,
                PasswordHash = BC.HashPassword(password),
                UserRole = Role.Advisor,
                BankId = bankId
            };
            data.Users.Add(user);
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

    public User? AuthenticateCustomer(string cpr, string password)
    {
        User? user = data.Users
            .FirstOrDefault(u => u.CPR == cpr &&
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