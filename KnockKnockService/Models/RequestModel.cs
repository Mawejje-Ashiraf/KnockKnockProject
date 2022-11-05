using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnockService.Models
{
    public class RequestModel
    {
        public int RequestID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Status { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}