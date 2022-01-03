using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonDefteriEntity
{
    public class CallLog
    {
        public int CallId { get; set; }

        public int? ListId { get; set; }
        public string CalledName { get; set; }
        public string CalledLastName { get; set; }
        public string CalledPhone { get; set; }
        public DateTime? CallDate { get; set; }
        public bool? CallResult { get; set; }
        public DateTime? CallLast { get; set; }
        public DateTime? CallNext { get; set; }

    }
}
