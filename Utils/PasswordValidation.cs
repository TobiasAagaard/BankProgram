namespace ShellBank.Utils
{
    using System.Text.RegularExpressions;
    static class PasswordValidation
    {
        const int MinLength = 12;
        const string SpecialChars = @"[!@#$%^&*(),.?""':{}|<>]";
        const string UppercaseChars = @"[A-Z]";
        const string NumberChars = @"[0-9]";

        public static (bool Ok, string? Error) ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return (false, "Password cannot be empty!");
            }
            if (password.Length < MinLength)
            {
                return (false, $"Password must at least be: {MinLength} characters long!");
            }
            if (password.Length > 72)
            {
                return (false, "Password cannot be longer than 72 characters!");
            }
            if (!Regex.IsMatch(password, SpecialChars))
            {
                return (false, "Password must contain at least one special character!");
            }
            if (!Regex.IsMatch(password, UppercaseChars))
            {
                return (false, "Password must contain at least one uppercase letter!");
            }
            if (!Regex.IsMatch(password, NumberChars))
            {
                return (false, "Password must contain at least one number!");
            }
            if (password.Contains(" "))
            {
                return (false, "Password cannot contain spaces!");
            }
            return (true, null);
        }
    }
}