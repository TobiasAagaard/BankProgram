namespace ShellBank.Utils
{
    using System;
    using System.Text;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    static class PasswordMask
    {
        public static string ReadPassword()
        {
            StringBuilder password = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(intercept: true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    password.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            return password.ToString();
        }
    }

}