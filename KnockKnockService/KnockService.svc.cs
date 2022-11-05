using KnockKnockService.Common;
using KnockKnockService.Contract;
using KnockKnockService.Implementation;
using KnockKnockService.Models;
using System;
using static KnockKnockService.Common.HelperClass;

namespace KnockKnockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class KnockService : IKnockService
    {
        IRequester requsterModel;
        public KnockService()
        {
            requsterModel = new Requester();
        }

        /// <summary>
        /// Processing request and response for incoming requests
        /// </summary>
        /// <returns></returns>
        public KnockResponse CheckForRequests()
        {
            KnockResponse response = new KnockResponse();
            try
            {

                response.Requests = requsterModel.GetAllRequests();
                response.ResponseStatusCode = ResponseCode.Success;
                return response;
            }
            catch(Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "CheckForRequests", ex);
                response.ResponseStatusCode = ResponseCode.Failed;
                return response;
            }
        }

        /// <summary>
        /// Processing request and response for updating  specific request item
        /// </summary>
        /// <param name="requestID"></param>
        /// <param name="approve"></param>
        /// <param name="SecToken"></param>
        /// <returns></returns>
        public KnockResponse UpdateRequest(int requestID, bool approve, string SecToken)
        {
            KnockResponse response = new KnockResponse();
            try
            {
                if(HelperClass.IsSecureTokenValid(requestID,approve,SecToken))
                {
                    RequestModel UpdateModel = new RequestModel();
                    UpdateModel.RequestID = requestID;
                    UpdateModel.Status = (approve) ? 1 : 2;
                    UpdateModel.UpdatedAt = DateTime.Now;
                    if(requsterModel.UpdateRequest(UpdateModel))
                    {
                        response.ResponseStatusCode = ResponseCode.Success;
                        return response;
                    }
                    else
                    {                        
                        response.ResponseStatusCode = ResponseCode.Failed;
                        return response;
                    }
                }
                else
                {
                    response.ResponseStatusCode = ResponseCode.Failed;
                    return response;
                }
            }
            catch (Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "UpdateRequest", ex);
                response.ResponseStatusCode = ResponseCode.Failed;
                return response;
            }
        }
    }
}
