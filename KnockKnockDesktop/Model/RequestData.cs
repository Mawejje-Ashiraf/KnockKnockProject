using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnockDesktop.Model
{
    public class RequestData
    {
        public int RequestID { get; set; }
        public int No { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
    }
}
