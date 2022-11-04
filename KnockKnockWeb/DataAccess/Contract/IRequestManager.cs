using KnockKnockWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnockWeb.DataAccess.Contract
{
    public interface IRequestManager
    {
        bool AddRequest(RequestModel model);
        List<RequestModel> GetAllRequests();
    }
}
