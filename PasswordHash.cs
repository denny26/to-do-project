using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class PasswordHash
    {
        public static string Hash(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }
}
