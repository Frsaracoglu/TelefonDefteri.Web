using System;
using System.Collections.Generic;

#nullable disable

namespace TelefonDefteriData.Models
{
    public partial class CallLog
    {
        public int CallId { get; set; }
        public int? ListId { get; set; }
        public int? UserId { get; set; }
        public string CalledName { get; set; }
        public string CalledLastName { get; set; }
        public string CalledPhone { get; set; }
        public DateTime? CallDate { get; set; }
        public bool? CallResult { get; set; }
        public DateTime? CallLast { get; set; }
        public DateTime? CallNext { get; set; }

        public virtual PhoneList List { get; set; }
        public virtual User User { get; set; }
    }
}
