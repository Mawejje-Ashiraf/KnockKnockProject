using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using KnockKnockDesktop.Helpers;
using KnockKnockDesktop.KnockKnockServiceRef;

namespace KnockKnockDesktop.Services
{
    public class WCFServiceCall
    {
        KnockServiceClient client;
        const string SecureKey = "WwWnBA2}Fx8L3C<*M_H}";
        public WCFServiceCall()
        {
            client = new KnockServiceClient();
        }

        /// <summary>
        /// Send Service request for Requests and process response
        /// </summary>
        /// <returns></returns>
        public List<RequestModel> CheckRecievedRequests()
        {
            List<RequestModel> reqModel = new List<RequestModel>();
            try
            {
                var Response = client.CheckForRequests();
                if (Response.ResponseStatusCode == HelperClassResponseCode.Success)
                {
                    reqModel = (Response.Requests
                                 .Select(x => new RequestModel
                                 {
                                     RequestID = x.RequestID,
                                     Status = x.Status,
                                     CreatedAt = x.CreatedAt
                                 })).ToList();
                }
                client.Close();
            }
            catch (Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "CheckRecievedRequests", ex);
            }
            return reqModel;
        }

        /// <summary>
        /// Send Service request for updating request and process response
        /// </summary>
        /// <param name="RequestID"></param>
        /// <param name="Action"></param>
        /// <returns></returns>
        public bool UpdateRequestRecord(int RequestID, bool Action)
        {
            bool res = false;
            try
            {
                string SecureToken = GenerateSecureHash(RequestID, Action);
                var Response = client.UpdateRequest(RequestID, Action,SecureToken);
                res = (Response.ResponseStatusCode == HelperClassResponseCode.Success)?true:false;
            }
            catch (Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "UpdateRequestRecord", ex);
            }
            return res;
        }

        /// <summary>
        /// Generating secureToken for string
        /// </summary>
        /// <param name="requestID"></param>
        /// <param name="approve"></param>
        /// <returns></returns>
        public string GenerateSecureHash(int requestID, bool approve)
        {
            string PlainText = requestID.ToString() + approve.ToString();
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
