using System;
using System.Security.Cryptography;
using System.Text;

namespace E_Study.Application
{
    public static class Util
    {
        public static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted);
        }
    }
}
