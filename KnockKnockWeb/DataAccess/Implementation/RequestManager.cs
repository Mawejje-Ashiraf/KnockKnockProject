using KnockKnockWeb.DataAccess.Contract;
using KnockKnockWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockWeb.DataAccess.Implementation
{
    public class RequestManager : IRequestManager
    {
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
                    AddRequest.UpdatedAt = model.UpdatedAt;
                    dbcontext.Request.Add(AddRequest);
                    dbcontext.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                return res;
            }
        }
        public List<RequestModel> GetAllRequests()
        {
            List<RequestModel> res = new List<RequestModel>();
            try
            {
                using(var dbcontext = new KnockDBEntities())
                {                    
                    var result = (from a in dbcontext.Request orderby a.CreatedAt descending
                           select new RequestModel()
                           {
                             CreatedAt = a.CreatedAt,
                             Status = (int)a.Status
                           }).ToList();
                    res = result;
                }                
                return res;
            }
            catch(Exception ex)
            {
                return res;
            }
        }
    }
}