using System.Security.Cryptography;
using System.Text;
using System;

namespace AISShopComputerParts.Logic.Autorization
{
    public class HashPassword
    {
        public string Hash;

        public HashPassword(string passwd)
        {
            Hash = GetHash(passwd);
        }

        private string GetHash(string str)
        {
            var sha2 = SHA256.Create();
            var hbyte = sha2.ComputeHash(Encoding.UTF8.GetBytes(str));

            return BitConverter.ToString(hbyte).Replace("-", "").ToLower();
        }
    }
}
