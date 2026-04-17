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