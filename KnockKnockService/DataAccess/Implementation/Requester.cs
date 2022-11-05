using KnockKnockService.Common;
using KnockKnockService.Contract;
using KnockKnockService.DataAccess;
using KnockKnockService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockService.Implementation
{
    public class Requester : IRequester
    {
        /// <summary>
        /// Getting all the pending Requests
        /// </summary>
        /// <returns></returns>
        public List<RequestModel> GetAllRequests()
        {
            List<RequestModel> res = new List<RequestModel>();
            try
            {
                using (var dbcontext = new KnockDBEntities())
                {
                    var result = (from a in dbcontext.Request
                                  .Where(a=> a.Status == 0)
                                  .OrderByDescending(a => a.CreatedAt)
                                  select new RequestModel()
                                  {
                                      RequestID = a.RequestID,
                                      CreatedAt = a.CreatedAt,
                                      Status = a.Status
                                  }).ToList();
                    res = result;
                }
                return res;
            }
            catch (Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "GetAllRequests", ex);
                return res;
            }
        }

        /// <summary>
        /// Updating specific request depending on the model specified
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateRequest(RequestModel model)
        {
            bool res = false;
            try
            {
                using (var dbcontext = new KnockDBEntities())
                {                    
                    (from p in dbcontext.Request
                     where p.RequestID == model.RequestID
                     select p).ToList()
                    .ForEach(x =>{ x.Status = model.Status; x.UpdatedAt = model.UpdatedAt; });
                    dbcontext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                AppLogger.LogExceptionInFile(ex.Message.ToString(), "UpdateRequest", ex);
                return res;
            }
        }
    }
}