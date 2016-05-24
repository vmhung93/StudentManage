using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Common.External_Lib
{
    public static class Security
    {
        public static string HashPassword(string userName, string password)
        {
            var hasher = new SHA1CryptoServiceProvider();

            byte[] dataBytes = Encoding.Unicode.GetBytes(string.Concat(userName, password));
            byte[] hashedBytes = hasher.ComputeHash(dataBytes);
            hasher.Clear();

            return Convert.ToBase64String(hashedBytes);
        }
    }
}