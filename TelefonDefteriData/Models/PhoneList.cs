using System;
using System.Collections.Generic;

#nullable disable

namespace TelefonDefteriData.Models
{
    public partial class PhoneList
    {
        public PhoneList()
        {
            CallLogs = new HashSet<CallLog>();
        }

        public int ListId { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public bool? Status { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CallLog> CallLogs { get; set; }
    }
}
