using KnockKnockWeb.DataAccess.Contract;
using KnockKnockWeb.Helpers;
using KnockKnockWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockWeb.DataAccess.Implementation
{
    public class RequestManager : IRequestManager
    {
        /// <summary>
        /// Saving new request
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddRequest(RequestModel model)
        {
            bool res = false;
            try
            {
                using(var dbcontext = new KnockDBEntities())
                {
                    Request AddRequest = new Request();
                    AddRequest.CreatedAt = model.CreatedAt;
                    AddRequest.Status = model.Status;                    
                    dbcontext.Request.Add(AddRequest);
                    dbcontext.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "AddRequest", ex);
                return res;
            }
        }

        /// <summary>
        /// Getting requests from the DB
        /// </summary>
        /// <returns></returns>
        public List<RequestModel> GetAllRequests()
        {
            List<RequestModel> res = new List<RequestModel>();
            try
            {
                using(var dbcontext = new KnockDBEntities())
                {                    
                    var result = (from a in dbcontext.Request.OrderByDescending(a=>a.CreatedAt)
                                   select new RequestModel()
                                   {
                                     CreatedAt = a.CreatedAt,
                                     Status = a.Status
                                   }).ToList();
                    res = result;
                }                
                return res;
            }
            catch(Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "GetAllRequests", ex);
                return res;
            }
        }
    }
}