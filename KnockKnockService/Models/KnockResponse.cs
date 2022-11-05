using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using static KnockKnockService.Common.HelperClass;

namespace KnockKnockService.Models
{
    [DataContract]
    public class KnockResponse
    {
        [DataMember]
        public int RequestID { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public DateTime UpdatedAt { get; set; }

        [DataMember]
        public List<RequestModel> Requests { get; set; }

        [DataMember]
        public ResponseCode ResponseStatusCode { get; set; }
    }
}