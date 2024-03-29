﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TelefonDefteriData.Models
{
    public partial class User
    {
        public User()
        {
            CallLogs = new HashSet<CallLog>();
            PhoneLists = new HashSet<PhoneList>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CallLog> CallLogs { get; set; }
        public virtual ICollection<PhoneList> PhoneLists { get; set; }
    }
}
