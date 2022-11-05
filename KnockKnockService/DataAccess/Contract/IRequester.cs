using KnockKnockService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnockService.Contract
{
    public interface IRequester
    {
        List<RequestModel> GetAllRequests();
        bool UpdateRequest(RequestModel model);
    }
}
