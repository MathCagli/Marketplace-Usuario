﻿using System.Security.Cryptography;

namespace MrktUsuario.CrossCutting.Utils
{
    public class SecurityUtils
    {
        public static String HashSHA1(String plainText)
        {
            return GetSHA1HashData(plainText);
        }

        private static string GetSHA1HashData(string data)
        {
            SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider();
            byte[] byteV = System.Text.Encoding.UTF8.GetBytes(data);
            byte[] byteH = SHA1.ComputeHash(byteV);

            SHA1.Clear();

            return Convert.ToBase64String(byteH);
        }
    }
}
