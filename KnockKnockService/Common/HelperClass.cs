using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace KnockKnockService.Common
{
    public static class HelperClass
    {
        public enum ResponseCode
        {
            Failed = 101,
            Success = 100
        }
        const string SecureKey = "WwWnBA2}Fx8L3C<*M_H}";
        public static bool IsSecureTokenValid(int requestID, bool approve, string AuthString)
        {
            bool result = false;
            try
            {
                result = (AuthString == GenerateSecureHash(requestID, approve)) ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return result;
        }
        public static string GenerateSecureHash(int requestID, bool approve)
        {
            string PlainText = requestID.ToString()+approve.ToString();
            try
            {
                byte[] keyArray;
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(PlainText);

                var hashMD5 = new MD5CryptoServiceProvider();
                keyArray = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecureKey));
                hashMD5.Clear();

                var triDESProv = new TripleDESCryptoServiceProvider();
                triDESProv.Key = keyArray;
                triDESProv.Mode = CipherMode.ECB;
                triDESProv.Padding = PaddingMode.PKCS7;

                var cTransform = triDESProv.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                triDESProv.Clear();
                string encText = Convert.ToBase64String(resultArray, 0, resultArray.Length);
                return encText;
            }
            catch (Exception ex)
            {
                return "ERROR";
            }
        }
    }   
}